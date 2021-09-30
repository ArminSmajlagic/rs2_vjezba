using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Models.API;
namespace WEB_API.Security
{

    public class BasicAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> optionsMonitor, ILoggerFactory loggerFactory, UrlEncoder encoder, ISystemClock systemClock) : base(optionsMonitor, loggerFactory, encoder, systemClock)
        {

        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Not good pw or us.");
            }

            Korisnik user = null;

            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credsByte = Convert.FromBase64String(authHeader.Parameter);
                var creds = Encoding.UTF8.GetString(credsByte).Split(':');
                var username = creds[0];
                var password = creds[1];

                user.username = username;
                user.password = password;
                return user;
            }
            catch (Exception ex)
            {

                return AuthenticateResult.Fail("Not good pw or us.");
            }
        }
    }
}
