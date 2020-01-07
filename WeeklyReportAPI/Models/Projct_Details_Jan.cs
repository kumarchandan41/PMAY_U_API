//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeeklyReportAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projct_Details_Jan
    {
        public long ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string StateCode { get; set; }
        public string DistrictCode { get; set; }
        public string CityCode { get; set; }
        public Nullable<System.DateTime> CSMCDate { get; set; }
        public string CSMCNumber { get; set; }
        public string Scheme { get; set; }
        public string SchemeComponent { get; set; }
        public string ProjectAgencies { get; set; }
        public string ProjectStatus { get; set; }
        public string ProjectDuration { get; set; }
        public string ProjectTitle { get; set; }
        public Nullable<decimal> ProjectCost { get; set; }
        public Nullable<decimal> CentralAssistance { get; set; }
        public string StateGrant { get; set; }
        public string ULB { get; set; }
        public string BeneficiaryShare { get; set; }
        public string OtherCost { get; set; }
        public string NewSanction { get; set; }
        public string UpgradeSanction { get; set; }
        public Nullable<decimal> TotalSanction { get; set; }
        public string FirstInstallment { get; set; }
        public string ActiveFlag { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
