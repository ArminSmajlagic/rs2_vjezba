using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace AuthServer.SecurityConfig
{
    public class AuthConfig
    {
        
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>()
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }


        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>()
            {
                new ApiScope(name:"TheMainApi",displayName:"read the data"),             
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>()
            {
                new ApiResource("TheMainApi")
                {
                    Scopes = new List<string>{ "TheMainApi" },
                    ApiSecrets = new List<Secret>{ new Secret("desk_cli_1".ToSha256()) },

                }    
            };
        }


        public static IEnumerable<Client> GetClients() => 
            new List<Client>()
            {
                new Client()
                {
                    ClientName = "Desktop_Client",
                    ClientId = "desk_cli_1",
                    ClientSecrets = { new Secret("desk_cli_1".ToSha256()) } ,
                    AllowedGrantTypes =  GrantTypes.ClientCredentials ,
                    AllowedScopes = { "TheMainApi" }
                },
                new Client()
                {
                    ClientName = "Mobile_Client",
                    ClientId = "mob_cli_1",
                    ClientSecrets = { new Secret("mob_cli_1".ToSha256()) } ,
                    AllowedGrantTypes = GrantTypes.ClientCredentials
                },
                new Client()
                {
                    ClientName = "swagger_Client",
                    ClientId = "swagger_cli_1",
                    ClientSecrets = { new Secret("swagger_cli_1".ToSha256()) } ,
                    AllowedGrantTypes = GrantTypes.ClientCredentials
                }
            };
    }
}
