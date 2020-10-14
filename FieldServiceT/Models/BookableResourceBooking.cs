using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FieldServiceT.Models
{
    public class BookableResourceBooking
    {
        public string BookableBesourceBookingId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Duration { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int StateCode { get; set; }
    }
}
