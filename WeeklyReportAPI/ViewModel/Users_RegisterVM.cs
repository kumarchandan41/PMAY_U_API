﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class Users_RegisterVM
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string DesignationId { get; set; }
        public string States_UT { get; set; }
        //public string StateName { get; set; }
        public string District { get; set; }
        public string City { get; set; } 
        public string ZipCode { get; set; }
        public string LastLoginDate { get; set; }
        public string PasswordChangeDate { get; set; }
        public string RoleName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }

        public string PhoneNo { get; set; }
        public string TaskName { get; set; }
        public bool? UserStatus { get; set; }        
    }
}