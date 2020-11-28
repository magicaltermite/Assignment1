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
            Console.WriteLine(userName + password);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:5005/users?username=Sonny&password=123");

            if (response.StatusCode == HttpStatusCode.OK) {
                string userAsJson = await response.Content.ReadAsStringAsync();
                Console.WriteLine(userAsJson + "user");
                
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);

                Console.WriteLine(resultUser);
                return resultUser;
            }
            throw new Exception("User not found");
        }
    }
}