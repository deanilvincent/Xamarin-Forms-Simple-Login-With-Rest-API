using CrossPlatformBasicLoginSystem.Models;
using CrossPlatformBasicLoginSystem.RestAPIClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatformBasicLoginSystem.ServicesHandler
{
    public class LoginService
    {
        RestClient<UserDetailCredentials> _restClient = new RestClient<UserDetailCredentials>();

        public async Task<bool> CheckLoginIfExists(string username, string password)
        {
            var check = await _restClient.checkLogin(username, password);

            return check;
        }
    }
}
