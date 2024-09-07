using ConsultarFipeLibrary.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultarFipeLibrary.Services
{
    public class FipeApiService
    {
        private readonly RestClient _client;

        public FipeApiService()
        {
            _client = new RestClient("https://parallelum.com.br/fipe/api/v1/");
        }

        public async Task<List<Brand>> GetBrandsAsync(string type)
        {
            var request = new RestRequest($"{type}/marcas", Method.Get);
            var response = await _client.GetAsync<List<Brand>>(request);
            return response;
        }

        public async Task<List<Model>> GetModelsAsync(string type, string brandCode)
        {
            var request = new RestRequest($"{type}/marcas/{brandCode}/modelos", Method.Get);
            var response = await _client.GetAsync<ModelResponse>(request);
            return response?.Modelos;
        }

        public async Task<List<Year>> GetYearsAsync(string type, string brandCode, string modelCode)
        {
            var request = new RestRequest($"{type}/marcas/{brandCode}/modelos/{modelCode}/anos", Method.Get);
            var response = await _client.GetAsync<List<Year>>(request);
            return response;
        }
        public async Task<Value> GetValueAsync(string type, string brandCode, string modelCode, string yearCode)
        {
            var request = new RestRequest($"{type}/marcas/{brandCode}/modelos/{modelCode}/anos/{yearCode}", Method.Get);
            var response = await _client.GetAsync<Value>(request);
            return response;
        }

    }
}
