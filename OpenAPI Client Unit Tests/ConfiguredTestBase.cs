using Bol.OpenAPI.Client;
using Microsoft.Extensions.Configuration;

namespace OpenAPI_Client_Unit_Tests
{
    public class ConfiguredTestBase
    {
        protected readonly OpenApiClient _client;

        public ConfiguredTestBase()
        {
            // the type specified here is just so the secrets library can 
            // find the UserSecretId we added in the csproj file
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<ConfiguredTestBase>();

            var configuration = builder.Build();
            _client = new OpenApiClient(configuration["ApiKey"]);
        }
    }
}