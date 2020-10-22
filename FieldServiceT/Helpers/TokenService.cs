using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Net.Http.Headers;
//using Microsoft.IdentityModel.Protocols;

namespace FieldServiceT.Helpers
{
    public static class TokenService
    {
        private static readonly string tenantId = "d9dad9e8-9725-4c21-8426-0df9b7fc5c77";
        private static readonly string appKey = "gRs6L1vWI82qk-cpkkp-3OKz-c92N36b.x";
        private static readonly string clientId = "6b542434-9649-4bb6-91c8-c2688e5b4024";

        private static readonly string CRMHost = "https://eg8pfua3iofsrjt3zb.crm.dynamics.com/";


    public static async Task<AuthenticationResult> GetAuthenticationResultAsync()
    {
        String authorityUrl = "https://login.microsoftonline.com/" + tenantId;

        try
        {
            AuthenticationContext authContext = new AuthenticationContext(authorityUrl);

            ClientCredential clientCredential = new ClientCredential(clientId, appKey);

            AuthenticationResult token = await authContext.AcquireTokenAsync(CRMHost, clientCredential).ConfigureAwait(false);

            return token;
        }
        catch (Exception)
        {
            throw;
        }
    }

    //public static async Task Authentificate(AuthenticationResult token)
    //{
    //    using (var client = new System.Net.Http.HttpClient())
    //    {
    //        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);

    //        var response = await client.GetAsync("https://eg8pfua3iofsrjt3zb.api.crm6.dynamics.com/api/data/v9.0/bookableresourcebookings");
    //        var contacts = await response.Content.ReadAsStringAsync();
    //    }
    //}
}
}

