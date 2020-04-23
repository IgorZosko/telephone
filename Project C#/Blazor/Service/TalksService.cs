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
    public class TalkService
    {
        string baseUrl = "https://localhost:44323/";

        public async Task<Talk[]> GetTalksAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Talks");
            return JsonConvert.DeserializeObject<Talk[]>(json);
        }

        public async Task<Talk> GetTalksByIdAsync(string id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Talks/{id}");
            return JsonConvert.DeserializeObject<Talk>(json);
        }

        public async Task<HttpResponseMessage> InsertTalkAsync(Talk student)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/Talks", getStringContentFromObject(student));
        }

        public async Task<HttpResponseMessage> UpdateTalkAsync(string id, Talk student)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/Talks/{id}", getStringContentFromObject(student));
        }

        public async Task<HttpResponseMessage> DeleteTalkAsync(string id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/Talks/{id}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
