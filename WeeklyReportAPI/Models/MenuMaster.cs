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
    
    public partial class MenuMaster
    {
        public long MenuId { get; set; }
        public string MenuName { get; set; }
        public Nullable<long> MenuRef { get; set; }
        public string MenuPath { get; set; }
        public string MenuIcon { get; set; }
        public Nullable<int> SequenceNo { get; set; }
        public Nullable<System.DateTime> DOC { get; set; }
        public string Status { get; set; }
    }
}
