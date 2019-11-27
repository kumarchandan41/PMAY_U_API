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
    
    public partial class Project_Fund_Release
    {
        public long ReleaseId { get; set; }
        public string Codes { get; set; }
        public string Dcode { get; set; }
        public string CityCode { get; set; }
        public string Release { get; set; }
        public string Source { get; set; }
        public string SanctionNumber { get; set; }
        public Nullable<double> HFAAmount { get; set; }
        public Nullable<double> TSPAmount { get; set; }
        public Nullable<double> SCSPAmount { get; set; }
        public string ProjectCode { get; set; }
        public string Installment { get; set; }
        public Nullable<System.DateTime> TxtSCSPDate { get; set; }
        public Nullable<double> FirstInstallment { get; set; }
    }
}
