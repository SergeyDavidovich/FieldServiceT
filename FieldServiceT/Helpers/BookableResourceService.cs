using FieldServiceT.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FieldServiceT.Helpers
{
    public class BookableResourceService
    {
        private string baseUrl= "https://eg8pfua3iofsrjt3zb.crm.dynamics.com/api/data/v9.0/bookableresourcebookings";
        public BookableResourceService()
        {}
        public AuthenticationResult Token { get; set; }
        public async Task<List<BookedResource>> GetResourcesAsync()
        {
            {
                //GET serviceRoot/ Me / Friends ?$filter = Friends / any(f: f / FirstName eq 'Scott')
                // baseUrl qBuilder ?$filter = bookingstatuses/any(s:s/bookingstatusid eq _bookingstatus_value

                //$select = Id,Name &$expand = RelatedObj($select = PropertyName)
                //EntitySet ?$select = Id,Name,RelatedObj / PropertyName &$expand = RelatedObj

                string tempQuery = baseUrl + "?$select=name,createdon,duration&$expand=BookingStatus($select=name)";

               var queryUri = new Uri(tempQuery);

                using (var client = new System.Net.Http.HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token.AccessToken);

                    var response = await client.GetAsync(queryUri);
                    var strjson = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<ODataResponse<BookedResource>>(strjson);

                    return result.Value;
                }
            }
        }
    }
    internal class ODataResponse<T>
    { public List<T> Value { get; set; } }
}
