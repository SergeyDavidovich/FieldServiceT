using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FieldServiceT.Models
{
    public class WOQuestionnaire
    {
        public WOQuestionnaire() { }
        public string ReportId { get; set; }
        public string WorkOrderId { get; set; }
        public string CreatorId { get; set; }
        public string DateOfCreation { get; set; }
        public string TotalityWorkOrderNumber { get; set; }
        public string ClientAssignmentCaseID { get; set; }
        public string MODName { get; set; }
        public string DetailedCloseOutNotes { get; set; }
        public string BillablePartsMaterialsUsed { get; set; }
        public string CreatCableUsedorId { get; set; }
        public string CableFootageUsed { get; set; }
        public string CableType { get; set; }
        public string CableColor { get; set; }
        public string Materials { get; set; }
        public string Hardware { get; set; }
        public string OtherMaterialsExplanation { get; set; }
        public string WorkComplete { get; set; }
        public string CompletionDate { get; set; }
        public string RevisitRequired { get; set; }
        public string StoreLocationName { get; set; }
        public string CheckInTime { get; set; }
        public string CheckOutTime { get; set; }
        public string NameTitleofClientSupportStaff { get; set; }
        public string IssuesorEscalations { get; set; }
        public string Issueexplanation { get; set; }
        public string SOWFamiliarity { get; set; }
        public string Efficiency { get; set; }
        public string Preparedness { get; set; }
        public string FileName1 { get; set; }
        public string FileName2 { get; set; }
        public string FileName3 { get; set; }
        public string FileName4 { get; set; }
        public string FileName5 { get; set; }
        public string FileName6 { get; set; }
        public string FileName7 { get; set; }
    }
}
//{
//  "ReportId": "",
//  "WorkOrderId": "",
//  "CreatorId": "",
//  "DateOfCreation": "",
//  "TotalityWorkOrderNumber": "",
//  "ClientAssignmentCaseID": "",
//  "MODName": "",
//  "DetailedCloseOutNotes": "",
//  "BillablePartsMaterialsUsed": "",
//  "CableUsed": "",
//  "CableFootageUsed": "",
//  "CableType": "",
//  "CableColor": "",
//  "Materials": "",
//  "Hardware": "",
//  "OtherMaterialsExplanation": "",
//  "WorkComplete": "",
//  "CompletionDate": "",
//  "RevisitRequired": "",
//  "StoreLocationName": "",
//  "CheckInTime": "",
//  "CheckOutTime": "",
//  "NameTitleofClientSupportStaff": "",
//  "IssuesorEscalations": "",
//  "Issueexplanation": "",
//  "SOWFamiliarity": "",
//  "Efficiency": "",
//  "Preparedness": "",
//  "FileName1": "",
//  "FileName2": "",
//  "FileName3": "",
//  "FileName4": "",
//  "FileName5": "",
//  "FileName6": "",
//  "FileName7": ""
//}
