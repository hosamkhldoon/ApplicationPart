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
    public  class ContactQueryClient
    {
        private string BaseUrl = "https://localhost:44391/";
        private HttpClient client;
        public List<Contact> GetContact(ContactQueryService ContactDataFilter)
        {

            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(5);
            HttpResponseMessage response = client.PutAsJsonAsync("api/Contact", ContactDataFilter).Result;


            if (response.IsSuccessStatusCode)
            {
                var body = response.Content.ReadAsStringAsync().Result;
                List<Contact> ContactData = JsonConvert.DeserializeObject<List<Contact>>(body);
                return ContactData;
            }
            return null;
        }
    }
}
