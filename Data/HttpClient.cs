using System.Net.Http;
using System.Net.Http.Headers;
using System;
using System.Threading.Tasks;

namespace Azure_Firewall_Enterprise_Policy_Manager.Data
{
    public static class FirewallHttp
    {
        private static Uri baseUrl = new Uri("https://management.azure.com/");
        private static HttpClient httpClient;
        static FirewallHttp()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = baseUrl;
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<string> GetHttp(string token, string requestUri)
        {
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",token);
            HttpResponseMessage result = await httpClient.GetAsync(requestUri);
            return await result.Content.ReadAsStringAsync();
        }
    }    
}