using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Telephone.Controllers;
using TelephoneShared.Models;

namespace Blazor.Service
{
    public class SubscribeService
    {
        string baseUrl = "https://localhost:44323/";

        public async Task<Subscribe[]> GetSubscribesAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Subscribes");
            return JsonConvert.DeserializeObject<Subscribe[]>(json);
        }

        public async Task<Subscribe> GetSubscribesByIdAsync(string id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Subscribes/{id}");
            return JsonConvert.DeserializeObject<Subscribe>(json);
        }

        public async Task<HttpResponseMessage> InsertSubscribeAsync(Subscribe student)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/Subscribes", getStringContentFromObject(student));
        }

        public async Task<HttpResponseMessage> UpdateSubscribeAsync(string id, Subscribe student)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/Subscribes/{id}", getStringContentFromObject(student));
        }

        public async Task<HttpResponseMessage> DeleteSubscribeAsync(string id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/Subscribes/{id}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
