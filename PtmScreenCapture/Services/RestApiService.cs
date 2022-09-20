using PtmScreenCapture.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtmScreenCapture.Services
{
    internal class RestApiService
    {
        private static RestClient restClient = new RestClient("https://localhost:7126/api");

        public static async Task<List<T>> GetEntityListAsync<T>()
        {
            RestRequest request = new RestRequest(typeof(T).Name, Method.Get);
            var response = await restClient.GetAsync<List<T>>(request);
            return response;
        }

        public static async Task InsertMongoDocAsync<T>(T doc)
        {
            RestRequest request = new RestRequest(typeof(T).Name, Method.Post);
            request.AddBody(doc);
            var response = await restClient.PostAsync(request);            
        }

        public static async Task UpdateMongoDocAsync<T>(T doc)
        {
            RestRequest request = new RestRequest(typeof(T).Name, Method.Put);
            request.AddBody(doc);
            var response = await restClient.PutAsync(request);
        }

        public static async Task DeleteMongoDocAsync<T>(string id)
        {
            RestRequest request = new RestRequest(typeof(T).Name, Method.Delete);
            request.AddQueryParameter("id", id);
            var response = await restClient.DeleteAsync(request);
        }
    }
}
