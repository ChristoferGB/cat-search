using cat_search.Model;
using RestSharp;
using System.Text.Json;

namespace cat_search.Services
{
    public class ApiService
    {
        private readonly RestClient client;
        private readonly string BASE_URL = "https://api.thecatapi.com/v1/";
        private readonly JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true,
        };

        public ApiService() 
        {
            client = new RestClient();
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
    }
}
