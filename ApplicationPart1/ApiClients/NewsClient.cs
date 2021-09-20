using FileWorxObjects;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;


namespace ApiClients
{
   public class NewsClient
    {
        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client;
        public News ReadNews(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(30);
            HttpResponseMessage response = client.GetAsync("api/News/" + id).Result;

        
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                News NewsData = JsonConvert.DeserializeObject<News>(body);
                return NewsData;
            }
            return null;
        }
        public string DeleteNews(int id)
        {
            client = new HttpClient();

            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(30);
            HttpResponseMessage response = client.DeleteAsync("api/News/"+ id).Result;



            if (response.IsSuccessStatusCode)
            {
              
                return "Deleted Successfully";
            }


            return "";


        }
        public string CreateNews(News news)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(30);
            HttpResponseMessage response = client.PostAsJsonAsync("api/News", news).Result;


          
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
               
                return body;
            }
            return null;


        }
        public string UpdateNews(int id, News news)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(30);
            HttpResponseMessage response = client.PutAsJsonAsync("api/News/"+id, news).Result;



            if (response.IsSuccessStatusCode)
            {
                return "Update Successfully";
            }


            return "";


        }
    }
}
