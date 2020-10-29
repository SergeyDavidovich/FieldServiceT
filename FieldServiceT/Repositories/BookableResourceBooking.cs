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
    public interface IBookableResourceBooking<T> where T: BookedResource
    {
        public List<T> BookedResourceBokings();
        public T GetBookingResource(string id);
    }



    public class BookableResourceBooking<T> : IBookableResourceBooking<T> where T : BookedResource
    {
        //public BookableResourceBooking(TokenService tokenService)
        //    {}
        public string BaseURL { get; set; }

        public List<T> BookedResourceBokings()
        {
            return null;
        }

        public T GetBookingResource(string id)
        {
            return null;
        }
    }
}


