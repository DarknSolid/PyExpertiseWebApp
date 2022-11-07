using System.Net.Http.Json;

namespace WebApp
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// Used to handle if the Api is offline or won't connect.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="postObject"></param>
        /// <returns>Returns null if a HttpRequestException is thrown</returns>
        public static async Task<HttpResponseMessage?> HandlePostRequest<T>(this HttpClient client, string url, T postObject)
        {
            try
            {
                return await client.PostAsJsonAsync(url, postObject);
            }
            catch (HttpRequestException e)
            {
                return null;
            }
        }
    }
}
