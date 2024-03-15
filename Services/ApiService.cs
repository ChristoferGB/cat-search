using cat_search.Model;
using cat_search.Model.Exceptions;
using cat_search.Model.Requests;
using cat_search.Model.Responses;
using RestSharp;
using System.Configuration;
using System.Text.Json;

namespace cat_search.Services
{
    public class ApiService
    {
        private readonly RestClient client;
        private readonly string BASE_URL = "https://api.thecatapi.com/v1/";
        private readonly string ApiKey;
        private readonly JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true,
        };

        public ApiService() 
        {
            client = new RestClient();
            ApiKey = ConfigurationManager.AppSettings["ApiKey"];
        }

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
            FavouriteRequest favouriteRequest = new(imageId, subId);

            string json = JsonSerializer.Serialize(favouriteRequest);

            var request = new RestRequest(BASE_URL + "favourites", Method.Post)
                .AddHeader("x-api-key", ApiKey)
                .AddBody(json);

            RestResponse response = client.Execute(request) ?? throw new ApiNullResponseException();

            return response;
        }

        public List<Favourite> GetFavourites()
        {
            var request = new RestRequest(BASE_URL + "favourites/", Method.Get).AddHeader("x-api-key", ApiKey);

            RestResponse response = client.Execute(request) ?? throw new ApiNullResponseException();

            List<FavouritesResponse>? favouritesResponseList = JsonSerializer.Deserialize<List<FavouritesResponse>>(response.Content, options) 
                ?? throw new DeserializationException(response, new Exception("JSON deserialization error: GetBreedAttributes()"));

            List<Favourite> favouritesList = new(); //incluir automapper

            foreach (var favouriteResponse in favouritesResponseList)
            {
                var attributes = GetBreedAttributes(favouriteResponse.Sub_id);

                Favourite favourite = new(favouriteResponse.Id, favouriteResponse.Image_id, favouriteResponse.Sub_id);

                favourite.SetName(attributes.Name);

                favouritesList.Add(favourite);
            }

            return favouritesList;
        }

        public RestResponse DeleteFavourite(int favouriteId)
        {
            var request = new RestRequest(BASE_URL + "favourites/" + favouriteId, Method.Delete)
                .AddHeader("x-api-key", ApiKey);

            RestResponse response = client.Execute(request) ?? throw new ApiNullResponseException();

            return response;
        }
    }
}
