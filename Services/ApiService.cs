using cat_search.Model;
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

        public List<Breed>? GetListOfBreeds()
        {
            var request = new RestRequest(BASE_URL + "breeds/", Method.Get);
            RestResponse response = client.Execute(request);

            return JsonSerializer.Deserialize<List<Breed>>(response.Content, options);
        }

        public BreedAttributes? GetBreedAttributes(string id)
        {
            var request = new RestRequest(BASE_URL + "breeds/" + id, Method.Get);
            RestResponse response = client.Execute(request);

            return JsonSerializer.Deserialize<BreedAttributes>(response.Content, options);
        }

        public RestResponse PostFavoriteBreed(string imageId, string subId)
        {
            FavouriteRequest favouriteRequest = new(imageId, subId);

            string json = JsonSerializer.Serialize(favouriteRequest);

            var request = new RestRequest(BASE_URL + "favourites", Method.Post)
                .AddHeader("x-api-key", ApiKey)
                .AddBody(json);

            var response = client.Execute(request);

            return response;
        }

        public List<Favourite> GetFavourites()
        {
            var request = new RestRequest(BASE_URL + "favourites/", Method.Get).AddHeader("x-api-key", ApiKey);
            RestResponse response = client.Execute(request);

            var favouritesResponseList = JsonSerializer.Deserialize<List<FavouritesResponse>>(response.Content, options);

            List<Favourite> favouritesList = new();

            foreach (var favouriteResponse in favouritesResponseList)
            {
                var attributes = GetBreedAttributes(favouriteResponse.Sub_id);
                Favourite favourite = new(favouriteResponse.Id, favouriteResponse.Image_id, favouriteResponse.Sub_id);
                favourite.SetName(attributes.Name);
                favouritesList.Add(favourite);
            }

            return favouritesList;
        }
    }
}
