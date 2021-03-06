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
    
    public partial class Users_Register
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string DesignationId { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<long> DisttId { get; set; }
        public Nullable<int> CityId { get; set; }
        public string ZipCode { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public Nullable<System.DateTime> PasswordChangeDate { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public string TaskName { get; set; }
        public Nullable<bool> UserStatus { get; set; }
    
        public virtual City_Master City_Master { get; set; }
        public virtual Distt_Master Distt_Master { get; set; }
        public virtual RoleMaster RoleMaster { get; set; }
        public virtual State_Master State_Master { get; set; }
    }
}
