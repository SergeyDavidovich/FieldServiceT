using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FieldServiceT.Models
{
    public class BookedResource
    {
        [Key]
        public string BookableResourceBookingId { get; set; }
        [Display(Name = "CREATED ON")]
        public DateTime CreatedOn { get; set; }
        public int Duration { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string StatusCode { get; set; }
        public string Name { get; set; }
        public BookingStatus BookingStatus
        {
            set
            {
                StatusName = value.Name;
            }
        }

        public string StatusName { get; set; }
    }
    public class BookingStatus
    {
        public string Name { get; set; }
    }
}
