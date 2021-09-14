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

namespace ApiClients
{
    public class UserClient
    {
        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client;
        public User ReadUser(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/User/" + id).Result;

            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                User UserData = JsonConvert.DeserializeObject<User>(body);
                return UserData;
            }
            return null;
        }
        public User LoginUser(User UserLogin)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("api/User/GETUSER",UserLogin).Result;

           
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                User UserData = JsonConvert.DeserializeObject<User>(body);
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
            HttpResponseMessage response = client.DeleteAsync("api/User/" + id).Result;



            if (response.IsSuccessStatusCode)
            {
                return "Deleted Successfully";
            }


            return "";


        }
        public string CreateUser(User user)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("api/User", user).Result;



            if (response.IsSuccessStatusCode)
            {
                return "Created Successfully";
            }


            return "";


        }
        public string UpdateUser(int id,User user)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PutAsJsonAsync("api/User/" + id, user).Result;



            if (response.IsSuccessStatusCode)
            {
                return "Update Successfully";
            }


            return "";


        }
    }
}
