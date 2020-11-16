using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FieldServiceT.Models
{
    public class Questionnaire
    {
        public Questionnaire() { }
        public string Id { get; set; }
        public string CreatorId { get; set; }
        public string WorkOrderId { get; set; }
        public string DateOfCreation { get; set; }
        public List<QuestionnaireItem> QuestionnaireItems { get; set; }
    }
}


//{
//    "Id" : "",
//    "WorkOrderId": "",
//    "CreatorId": "",
//    "DateOfCreation": "",
//    "QuestionnaireItems": [
//        {
//        "ReportId" : "",
//            "Question": "",
//            "Answer": "",
//        }
//    ]
//}

