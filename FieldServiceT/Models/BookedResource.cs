using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FieldServiceT.Models
{
    public class BookedResource
    {
        [Key]
        [JsonProperty("bookableresourcebookingid")]
        public string BookableResourceBookingId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("starttime")]
        public DateTime StartTime { get; set; }

        [JsonProperty("endtime")]
        public DateTime EndTime { get; set; }

        [JsonProperty("msdyn_workorder")]
        public WorkOrder WorkOrder { get; set; }

        
    }
}
