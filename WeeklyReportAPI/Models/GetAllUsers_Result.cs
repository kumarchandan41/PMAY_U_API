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
    
    public partial class GetAllUsers_Result
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Designation { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public string LastLoginDate { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public Nullable<int> TaskId { get; set; }
    }
}
