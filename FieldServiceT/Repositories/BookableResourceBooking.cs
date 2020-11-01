using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FieldServiceT.Models;
using FieldServiceT.Helpers;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
namespace FieldServiceT.Repositories
{
    public interface IBookableResourceBooking<T> where T : BookedResource
    {
        public List<T> GetBookedResourceBokings();
        public T GetBookingResource(string id);
    }
    public class BookableResourceBooking<T> : IBookableResourceBooking<T> where T : BookedResource
    {
        TokenService _tokenService;
        public BookableResourceBooking(TokenService tokenService)
        {
            _tokenService = tokenService;
        }
        private async Task<string> GetTokenAsync()
        {
            var token = await _tokenService.GetAuthenticationResultAsync();
            return token.AccessToken;
        }
        public string BaseURL { get; set; }
        public T GetBookingResource(string id)
        {
            return null;
        }
        public List<T> GetBookedResourceBokings()
        {
            throw new NotImplementedException();
        }
    }
}


