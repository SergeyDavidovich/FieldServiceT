using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FieldServiceT.Models
{
    internal class ODataResponse<T>
    {
        public List<T> Value
        {
            get;
            set;
        }
    }
}
