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
using RecipeList.Services.Helpers;

namespace RecipeList.Services
{
    public class RecipeApiService : IRecipeService
    {
        private readonly ApiHelper helper;

        public RecipeApiService(string baseUrl)
        {
            helper = new ApiHelper(baseUrl);
        }

        public async Task<List<Recipe>> GetRecipesAsync()
        {
            var errorHandlers = new Dictionary<ErrorCode, ApiHelper.ErrorHandler<List<Recipe>>>();
            return await helper.GetAsync<List<Recipe>>("recipes", errorHandlers);
        }

        public async Task<RecipeDetails> GetRecipeAsync(long id)
        {
            var errorHandlers = new Dictionary<ErrorCode, ApiHelper.ErrorHandler<RecipeDetails>>
            {
                [ErrorCode.NotFound] = res =>
                    new RecipeNotFoundException(res.GetErrorData<long>("id"))
            };
            return await helper.GetAsync<RecipeDetails>($"recipes/{id}", errorHandlers);
        }

        public async Task<RecipeDetails> CreateRecipeAsync(RecipeDetails recipe)
        {
            var errorHandlers = new Dictionary<ErrorCode, ApiHelper.ErrorHandler<RecipeDetails>>
            {
                [ErrorCode.InvalidRequest] = res =>
                    new InvalidRecipeException((InvalidRecipeException.Reason)res.GetErrorData<long>("reasons"))
            };
            return await helper.PostAsync("recipes", recipe, errorHandlers);
        }
    }
}