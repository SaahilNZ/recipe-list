using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RecipeList.Model;
using RecipeList.Services.Exceptions;

namespace RecipeList.Services.Helpers
{
    public class ApiHelper
    {
        public delegate Exception ErrorHandler<T>(ApiResponse<T> response);

        private readonly string baseUrl;
        
        public ApiHelper(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        private async Task<T> HandleResponseAsync<T>(HttpResponseMessage response,
            Dictionary<ErrorCode, ErrorHandler<T>> errorHandlers)
        {
            using (var content = response.Content)
            {
                string json = await content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ApiResponse<T>>(json);

                if (data.Status == ErrorCode.Success)
                {
                    return data.Response;
                }
                else if (errorHandlers.TryGetValue(data.Status, out var handler))
                {
                    throw handler(data);
                }
                else
                {
                    throw new InvalidOperationException($"An unhandled error occured: '{data.ErrorMessage}' ({data.Status})");
                }
            }
        }

        public async Task<T> GetAsync<T>(string endpoint,
            Dictionary<ErrorCode, ErrorHandler<T>> errorHandlers)
        {
            var url = new Uri(new Uri(baseUrl), endpoint);
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    return await HandleResponseAsync<T>(response, errorHandlers);
                }
            }
        }

        public async Task<T> PostAsync<T>(string endpoint, T postData,
            Dictionary<ErrorCode, ErrorHandler<T>> errorHandlers)
        {
            var url = new Uri(new Uri(baseUrl), endpoint);
            using (var client = new HttpClient())
            {
                var encodedData = new StringContent(JsonConvert.SerializeObject(postData),
                    Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync(url, encodedData))
                {
                    return await HandleResponseAsync<T>(response, errorHandlers);
                }
            }
        }
    }
}