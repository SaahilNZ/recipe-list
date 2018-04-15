using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RecipeList.Model;
using RecipeList.Services.Exceptions;

namespace RecipeList.Services
{
    public class RecipeApiService : IRecipeService
    {
        public async Task<List<Recipe>> GetRecipesAsync()
        {
            string apiUrl = "http://recipelistapi.azurewebsites.net/api/recipes";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(apiUrl))
                {
                    using (var content = response.Content)
                    {
                        string json = await content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<ApiResponse<List<Recipe>>>(json);
                        
                        switch (data.Status)
                        {
                            case ErrorCode.Success:
                                return data.Response;
                            default:
                                throw new InvalidOperationException($"An unhandled error occured: '{data.ErrorMessage}' ({data.Status})");
                        }
                    }
                }
            }
        }

        public async Task<RecipeDetails> GetRecipeAsync(int id)
        {
            string apiUrl = $"http://recipelistapi.azurewebsites.net/api/recipes/{id}";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(apiUrl))
                {
                    using (var content = response.Content)
                    {
                        string json = await content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<ApiResponse<RecipeDetails>>(json);
                        
                        switch (data.Status)
                        {
                            case ErrorCode.Success:
                                return data.Response;
                            case ErrorCode.RecipeNotFound:
                                throw new RecipeNotFoundException(data.GetErrorData<int>("id"));
                            default:
                                throw new InvalidOperationException($"An unhandled error occured: '{data.ErrorMessage}' ({data.Status})");
                        }
                    }
                }
            }
        }
    }
}