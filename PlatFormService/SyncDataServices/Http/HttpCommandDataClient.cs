using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PlatFormService.Dtos;

namespace PlatFormService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommadDataClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public HttpCommandDataClient(HttpClient httpClient,IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task SendPlatformToCommad(PlatformReadDto plat)
        {
             var httpContent = new StringContent(
                JsonSerializer.Serialize(plat),
                Encoding.UTF8,"application/json");

            var response = await _httpClient.PostAsync($"{_configuration["CommadService"]}",httpContent);

            if(response.IsSuccessStatusCode)
            {
                Console.WriteLine("--> Sync POST to CommandService was OK!");
            }
            else    
            {
                Console.WriteLine("--> Sync POST to CommadService was not OK!");
            }
        }
    }
}