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
    
    public partial class ClssCityWiseExcel
    {
        public long sid { get; set; }
        public string state_Name { get; set; }
        public Nullable<double> State_Code { get; set; }
        public string District_Name { get; set; }
        public Nullable<double> District_Code { get; set; }
        public string City_Name { get; set; }
        public Nullable<double> City_Code { get; set; }
        public Nullable<double> Loan_Amount { get; set; }
        public Nullable<double> SubsidyAmountCredited { get; set; }
        public Nullable<double> NoofBeneficiaries { get; set; }
    }
}
