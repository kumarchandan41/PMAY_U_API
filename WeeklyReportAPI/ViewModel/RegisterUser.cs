using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class RegisterUser
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string DesignationId { get; set; }
        public string StateId { get; set; }
        public string DisttId { get; set; }
        public string CityId { get; set; }
        public string LastLoginDate { get; set; }
        public string PasswordChangeDate { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string ZipCode { get; set; }
        public string RoleId { get; set; }
        public string TaskName { get; set; }
    }
}
