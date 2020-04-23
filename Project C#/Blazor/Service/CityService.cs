using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Telephone.Controllers;
using Telephone.Models;

namespace Blazor.Service
{
    public class CityService
    {
        string baseUrl = "https://localhost:44323/";

        public async Task<City[]> GetCitysAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Cities");
            return JsonConvert.DeserializeObject<City[]>(json);
        }

        public async Task<City> GetCitysByIdAsync(int id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Cities/{id}");
            return JsonConvert.DeserializeObject<City>(json);
        }

        public async Task<HttpResponseMessage> InsertCityAsync(City student)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/Cities", getStringContentFromObject(student));
        }

        public async Task<HttpResponseMessage> UpdateCityAsync(string id, City student)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/Cities/{id}", getStringContentFromObject(student));
        }

        public async Task<HttpResponseMessage> DeleteCityAsync(int id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/Cities/{id}" );
        }   
        
        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
