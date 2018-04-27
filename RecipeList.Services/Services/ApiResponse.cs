using System;
using System.Collections.Generic;

namespace RecipeList.Services
{
    public enum ErrorCode
    {
        Success = 0,
        NotFound = 1,
        InvalidRequest = 2
    }

    public class ApiResponse<T>
    {
        public T Response { get; set; }
        public string ErrorMessage { get; set; }
        public ErrorCode Status { get; set; }
        public Dictionary<string, object> ErrorData { get; set; }

        private ApiResponse() { }

        public static ApiResponse<T> FromData(T response)
        {
            return new ApiResponse<T>
            {
                Response = response,
                ErrorMessage = string.Empty,
                Status = ErrorCode.Success,
                ErrorData = null
            };
        }

        public static ApiResponse<T> FromErrorCode(string message, ErrorCode errorCode, Dictionary<string, object> errorData)
        {
            return new ApiResponse<T>
            {
                Response = default(T),
                ErrorMessage = message,
                Status = errorCode,
                ErrorData = errorData
            };
        }

        public TData GetErrorData<TData>(string key)
        {
            return (TData)ErrorData[key];
        }
    }
}