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
    
    public partial class Register_Users
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string DesignationId { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> DisttId { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Zipcode { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public Nullable<System.DateTime> PasswordChangeDate { get; set; }
        public string RoleId { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public string TaskId { get; set; }
    }
}