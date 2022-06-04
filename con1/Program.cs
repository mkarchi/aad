using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
namespace app50
{
    class Program
    {
        private const string _clientId = "d7f68151-db20-4e03-876f-8f5c7ac5f07b";
        private const string _tenantId = "e08f8953-3554-4910-80b6-a247b4aff33c";
        public static async Task Main(string[] args)
        {
            var app = PublicClientApplicationBuilder
            .Create(_clientId)
            .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
            .WithRedirectUri("http://localhost")
            .Build();
            string[] scopes = { "user.read" };
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();
            Console.WriteLine($"Token:\t{result.AccessToken}");
        }
    }
}
