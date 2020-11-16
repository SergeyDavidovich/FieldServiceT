using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FieldServiceT.Models
{
    public class QuestionnaireItem
    {
        public string QuestionnaireId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
