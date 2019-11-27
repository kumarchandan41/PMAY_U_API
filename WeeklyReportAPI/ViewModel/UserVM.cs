using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class UserVM
    {
       
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DesigId { get; set; }
        public string StateId { get; set; }
        public string CityId { get; set; }
        public string LastLoginDate { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string TaskId { get; set; }
    }
}