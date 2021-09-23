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
    public class PhotoClient
    {
        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client;
        public Photo ReadPhoto(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.GetAsync("api/Photo/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                Photo PhotoData = JsonConvert.DeserializeObject<Photo>(body);
                return PhotoData;
            }
            return null;
        }
        public string DeletePhoto(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.DeleteAsync("api/Photo/" + id).Result;



            if (response.IsSuccessStatusCode)
            {
                return "Deleted Successfully";
            }


            return "";


        }
        public string CreatePhoto(Photo photo)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.PostAsJsonAsync("api/Photo", photo).Result;



          
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;

                return body;
            }
            return null;


        }
        public string UpdatePhoto(int id, Photo photo)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.PutAsJsonAsync("api/Photo/" + id, photo).Result;



            if (response.IsSuccessStatusCode)
            {
                return "Update Successfully";
            }


            return "";


        }
    }
}
