using cat_search.Model;
using cat_search.Model.Exceptions;
using cat_search.Model.Requests;
using RestSharp;
using System.Configuration;
using System.Text.Json;

namespace cat_search.Services
{
    public class ApiService
    {
        private readonly RestClient client = new();
        private readonly JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true,
        };
        private readonly string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
        private const string BASE_URL = "https://api.thecatapi.com/v1/";

        public List<Breed> GetListOfBreeds()
        {
            var request = new RestRequest(BASE_URL + "breeds/", Method.Get);

            RestResponse response = client.Execute(request) ?? throw new ApiNullResponseException();

            List<Breed>? breeds = JsonSerializer.Deserialize<List<Breed>>(response.Content, options);

            return breeds 
                ?? throw new DeserializationException(response, new Exception("JSON deserialization error: GetListOfBreeds()"));
        }

        public BreedAttributes GetBreedAttributes(string id)
        {
            var request = new RestRequest(BASE_URL + "breeds/" + id, Method.Get);

            RestResponse response = client.Execute(request) ?? throw new ApiNullResponseException();

            BreedAttributes? attributes = JsonSerializer.Deserialize<BreedAttributes>(response.Content, options);

            return attributes 
                ?? throw new DeserializationException(response, new Exception("JSON deserialization error: GetBreedAttributes()"));
        }

        public RestResponse PostFavoriteBreed(string imageId, string subId)
        {
            FavouriteRequest favoriteRequest = new(imageId, subId);

            string json = JsonSerializer.Serialize(favoriteRequest);

            var request = new RestRequest(BASE_URL + "favourites", Method.Post)
                .AddHeader("x-api-key", ApiKey)
                .AddBody(json);

            RestResponse response = client.Execute(request) ?? throw new ApiNullResponseException();

            return response;
        }

        public List<Favorite> GetFavorites()
        {
            var request = new RestRequest(BASE_URL + "favourites/", Method.Get).AddHeader("x-api-key", ApiKey);

            RestResponse response = client.Execute(request) ?? throw new ApiNullResponseException();

            List<Favorite>? favoritesList = JsonSerializer.Deserialize<List<Favorite>>(response.Content, options) 
                ?? throw new DeserializationException(response, new Exception("JSON deserialization error: GetBreedAttributes()"));

            foreach (var favorite in favoritesList)
            {
                var attributes = GetBreedAttributes(favorite.Sub_id);

                favorite.SetName(attributes.Name);
            }

            return favoritesList;
        }

        public RestResponse DeleteFavorite(int favouriteId)
        {
            var request = new RestRequest(BASE_URL + "favourites/" + favouriteId, Method.Delete)
                .AddHeader("x-api-key", ApiKey);

            RestResponse response = client.Execute(request) ?? throw new ApiNullResponseException();

            return response;
        }
    }
}
