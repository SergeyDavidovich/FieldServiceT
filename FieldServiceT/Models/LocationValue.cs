using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace FieldServiceT.Models
{
    public class LocationValue
    {
        [JsonProperty("Latitude")]
        public string Latitude { get; set; }

        [JsonProperty("Longitude")]
        public string Longitude { get; set; }

        [JsonProperty("BKBid")]
        public string BKBid { get; set; }

        [JsonProperty("ButtonId")]
        public string ButtonId { get; set; }
    }
}
