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
    
    public partial class ULB_Agencies_Share
    {
        public long ULBId { get; set; }
        public string StateCode { get; set; }
        public string DistrictCode { get; set; }
        public string CityCode { get; set; }
        public string ULBAgencyShare { get; set; }
        public string ActiveFlag { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
