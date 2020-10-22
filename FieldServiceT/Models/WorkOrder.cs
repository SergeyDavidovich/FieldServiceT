using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FieldServiceT.Models
{
    public class WorkOrder
    {
        public WorkOrder() { }

        [JsonProperty("msdyn_name")]
        public string Name { get; set; }

        [JsonProperty("msdyn_addressname")]
        public string Addressname { get; set; }

        [JsonProperty("msdyn_address1")]
        public string Address1 { get; set; }
    }
}


// msdyn_name
// new_title – этого поля нет в тестовой среде
// new_assignmentids - этого поля нет в тестовой среде
// msdyn_addressname
// msdyn_address1
