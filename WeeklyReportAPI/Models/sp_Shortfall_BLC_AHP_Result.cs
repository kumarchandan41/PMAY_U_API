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
    
    public partial class sp_Shortfall_BLC_AHP_Result
    {
        public string SrNo { get; set; }
        public string Component { get; set; }
        public string FinYear { get; set; }
        public Nullable<double> Completed { get; set; }
        public Nullable<double> Actual_Completed { get; set; }
        public Nullable<double> Shortfall_Completed { get; set; }
    }
}