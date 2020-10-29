using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FieldServiceT.Models
{
    public class BookedResourceScreen
    {
        public string BookableResourceBookingId { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        string woname;
        public string WOName
        {
            get=>woname;
            set
            {
                woname = value;
            }
        }
        public string WOAddress1 { get; set; }
        public string WOAddressName { get; set; }
        public string WOSummary { get; set; }
        public string StatusName { get; set; }

        public string Avatar { get; set; }
    }
}
