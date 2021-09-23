using FileWorxObjects;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;


namespace ApiClients
{
    public class BusinessClient
    {
        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client; 
        public BusinessObject ReadNewsOrPhotoOrUser(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.GetAsync("api/Business/" + id).Result;

  
            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                BusinessObject BusinessData = JsonConvert.DeserializeObject<BusinessObject>(body);
                return BusinessData;
            }
            return null;
        }
   
        public string DeleteNewsOrPhotoOrUser(int id)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.DeleteAsync("api/Business/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return "Deleted Successfully";
            }


            return "";


        }

    }
}
