using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Data;
using Models;

namespace Assignment1.Data
{
    public class UserWebService : IUserService
    {

        private string uri = "https://localhost:5005";

        
        public async Task<User> ValidateUser(string userName, string password)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"{uri}/users?username={userName}&password={password}");

            if (response.StatusCode == HttpStatusCode.OK) {
                string userAsJson = await response.Content.ReadAsStringAsync();
                
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);

                return resultUser;
            }
            throw new Exception("User not found");
        }
    }
}