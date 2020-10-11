using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace FieldServiceT.Models
{
    public class BookableResource
    {
        public string BookableResourceId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public int ResourceType { get; set; }
        public string TimeZone { get; set; }

    }
}
