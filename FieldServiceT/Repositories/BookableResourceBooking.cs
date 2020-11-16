using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FieldServiceT.Models;
using FieldServiceT.Helpers;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;

namespace FieldServiceT.Repositories
{
    public interface IBookableResourceBooking<BookedResource>
    {
        public Task<List<BookedResource>> GetBookedResourceBokings();
        //public BookedResource GetBookingResource(string id);
    }
    public class BookableResourceBooking<BookedResource> : IBookableResourceBooking<BookedResource>
    {
        public BookableResourceBooking() { }
        public string AccessToken { get; set; }
        public string BaseURl { get; set; }
        public string UserMail { get; set; }
        public async Task<List<BookedResource>> GetBookedResourceBokings()
        {
            string userId = (await GetSystemUserAsync(this.BaseURl, this.UserMail, this.AccessToken)).SystemUserId;
            string bookableResourceId = await GetBookableResourceIdAsync(this.BaseURl, userId, this.AccessToken);
            var bookableResourceBookings = await GetBookableResourceBookingsAsync(this.BaseURl, this.AccessToken, bookableResourceId);
            return bookableResourceBookings;
        }
        public async Task<SystemUser> GetSystemUserAsync(string baseUrl, string userMail, string accessToken)
        {
            string query = baseUrl + "systemusers?$select=systemuserid,fullname&$filter=internalemailaddress eq '" + userMail + "'";
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var response = await client.GetAsync(new Uri(query));
                var strjson = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ODataResponse<SystemUser>>(strjson).Value.First<SystemUser>();
                return result;
            }
        }
        private async Task<string> GetBookableResourceIdAsync(string baseUrl, string userId, string accessToken)
        {
            {
                string query = baseUrl + "bookableresources";
                query += "?$select=bookableresourceid";
                query += "&$filter=_userid_value eq '" + userId + "'";

                using (var client = new System.Net.Http.HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    var response = await client.GetAsync(new Uri(query));
                    var strjson = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<ODataResponse<BookableResource>>(strjson).Value.FirstOrDefault<BookableResource>();

                    if (result == null)
                        return null;
                    else
                        return result.BookableResourceId;
                }
            }
        }

        private async Task<List<BookedResource>> GetBookableResourceBookingsAsync(string baseUrl, string accessToken, string bookableResourceId)
        {
            string query = baseUrl + "bookableresourcebookings";
            query += "?$filter=_resource_value eq '" + bookableResourceId + "'";
            query += "&$select=name,starttime,endtime";
            query += "&$expand=msdyn_workorder($select = msdyn_name, msdyn_address1,msdyn_addressname,msdyn_workordersummary ),";
            query += "BookingStatus($select=name)";

            HttpResponseMessage response;

            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                response = await client.GetAsync(new Uri(query));
            }
            var strjson = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<ODataResponse<BookedResource>>(strjson).Value;
            return result;
        }


        //public BookedResource GetBookingResource(string id)
        //{
        //    return BookedResource;
        //}
    }
}


