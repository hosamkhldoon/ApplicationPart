using FileWorxObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace ApiClients
{
    public class UserClient
    {
        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client;
        public UserReadService ReadUser(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.GetAsync("api/User/" + id).Result;

           
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                UserReadService UserData = JsonConvert.DeserializeObject<UserReadService>(body);
                return UserData;
            }
            return null;
        }
        public UserCeackLogin LoginUser(UserCeackLogin UserLogin)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.PostAsJsonAsync("api/User/GETUSER",UserLogin).Result;

           
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                UserCeackLogin UserData = JsonConvert.DeserializeObject<UserCeackLogin>(body);
                return UserData;
            }
            return null;



        }
        public string DeleteUser(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.DeleteAsync("api/User/" + id).Result;



            if (response.IsSuccessStatusCode)
            {
                return "Deleted Successfully";
            }


            return "";


        }
        public string CreateUser(UserUpdateService user)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.PostAsJsonAsync("api/User", user).Result;



            if (response.IsSuccessStatusCode)
            {
                return "Saved Successfully";
            }


            return "";


        }
        public string UpdateUser(int id,UserUpdateService user)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.PutAsJsonAsync("api/User/" + id, user).Result;



            if (response.IsSuccessStatusCode)
            {
                return "Update Successfully";
            }


            return "";


        }
    }
}
