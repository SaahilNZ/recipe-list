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

namespace RecipeList.Services
{
    public class RecipeApiService : IRecipeService
    {
        private delegate Exception ErrorHandler<T>(ApiResponse<T> response);

        private readonly string baseUrl;
        
        public RecipeApiService(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        private async Task<T> GetAsync<T>(string endpoint,
            Dictionary<ErrorCode, ErrorHandler<T>> errorHandlers)
        {
            var url = new Uri(new Uri(baseUrl), endpoint);
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
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
            }
        }

        private async Task PostAsync<T>(string endpoint, T postData,
            Dictionary<ErrorCode, ErrorHandler<T>> errorHandlers)
        {
            var url = new Uri(new Uri(baseUrl), endpoint);
            using (var client = new HttpClient())
            {
                var encodedData = new StringContent(JsonConvert.SerializeObject(postData),
                    Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, encodedData);
            }
        }

        public async Task<List<Recipe>> GetRecipesAsync()
        {
            var errorHandlers = new Dictionary<ErrorCode, ErrorHandler<List<Recipe>>>();
            return await GetAsync<List<Recipe>>("recipes", errorHandlers);
        }

        public async Task<RecipeDetails> GetRecipeAsync(long id)
        {
            var errorHandlers = new Dictionary<ErrorCode, ErrorHandler<RecipeDetails>>
            {
                [ErrorCode.RecipeNotFound] = res =>
                    new RecipeNotFoundException(res.GetErrorData<long>("id"))
            };
            return await GetAsync<RecipeDetails>($"recipes/{id}", errorHandlers);
        }

        public async Task<RecipeDetails> PostRecipeAsync(RecipeDetails recipe)
        {
            var errorHandlers = new Dictionary<ErrorCode, ErrorHandler<RecipeDetails>>();
            await PostAsync("recipes", recipe, errorHandlers);
            return recipe;
        }
    }
}