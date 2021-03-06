using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using FileWorxObjects;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http.Json;
using DTO;
namespace ApiClients
{
    public class UserQueryClient
    {
        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client;
        public  List<User> GetUsers(UserQueryService UserDataFilter)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.PutAsJsonAsync("api/User",UserDataFilter).Result;

            
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                List<User> UserData = JsonConvert.DeserializeObject<List<User>>(body);
                return UserData;
            }
            return null;
        }
       
    }
}
