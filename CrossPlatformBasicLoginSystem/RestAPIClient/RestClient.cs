using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatformBasicLoginSystem.RestAPIClient
{
    public class RestClient<T>
    {
        private const string MainWebServiceUrl = "http://localhost:59477/";
        private const string LoginWebServiceUrl = "http://testingme333-001-site1.etempurl.com/api/UserCredentials/";

        public async Task<bool> checkLogin(string username, string password)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(LoginWebServiceUrl + "username=" + username + "/" + "password=" + password);

            return response.IsSuccessStatusCode;
        }
    }
}
