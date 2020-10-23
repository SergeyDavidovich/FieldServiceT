using FieldServiceT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FieldServiceT.Repositories
{
    public class BookableResourceRepo <T> where T: BookedResource
    {
        public string BaseURL { get; set; }
    }

    public class Repo<T>
    {

    }

}


