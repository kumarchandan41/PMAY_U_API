using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeeklyReportAPI.Models;

namespace WeeklyReportAPI.Controllers
{
    [RoutePrefix("API/Authenticate")]
    public class AuthenticateController : ApiController
    {
        [Route("LoginMaster")]
        [HttpGet]
        public string LoginUser(string Username, string password)
        {
            string status = "User name or password is incorrect";
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                status = objEntity.user_Master.Where(a => a.UserName == Username && a.Password == password).FirstOrDefault().RoleId;

            }
            catch (Exception)
            {
                throw;
            }
            return status;
        }
    }
}
