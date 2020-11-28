using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assignment1.Data
{
    public class AdultService : IAdultService
    {
        //private string uri = "http://dnp.metamate.me";
        private string uri = "https://localhost:5005";
        private readonly HttpClient client;


        public AdultService() {
            client = new HttpClient();
        }
        
        
        public async Task<IList<Adult>> GetAdultsAsync() {
            Task<string> stringAsync = client.GetStringAsync(uri + "/Adults");
            string message = await stringAsync;

            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            // Console.WriteLine(message);

            return result;
        }

        public async Task AddAdultAsync(Adult adult) {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson, Encoding.UTF8, "application/json");
            await client.PostAsync(uri + "/adults", content);
        }

        public async Task RemoveAdultAsync(int adultId) {
            await client.DeleteAsync($"{uri}/adults/{adultId}");
        }

        public async Task UpdateAdultAsync(Adult adult) {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson, Encoding.UTF8, "application/json");
            await client.PatchAsync($"{uri}/adults/{adult.Id}", content);
        }
    }
}