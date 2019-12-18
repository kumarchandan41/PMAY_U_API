using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeeklyReportAPI.Models;
using WeeklyReportAPI.ViewModel;

namespace WeeklyReportAPI.Controllers
{
    [RoutePrefix("API/RegistrationApi")]
    public class RegistrationController : ApiController
    {

        [Route("LoginMaster")]
        [HttpGet]
        public bool getUserOld(string Username, string password)
        {
            bool status = false;
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                status = objEntity.user_Master.Where(a => a.UserName == Username && a.Password == password).Any();

            }
            catch (Exception ex)
            {
                throw;
            }
            return status;
        }
        [Route("Login_Master1")]
        [HttpGet]
        public string AddUser(user_Master data)
        {
            string str = "";
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objEntity.user_Master.Add(data);
                int i = objEntity.SaveChanges();
                if(i>0)
                {
                    str = "Registration has been successfull";
                }
                else
                {
                    str = "Registration faild";
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return str;
        }
        [Route("CheckIdPass")]
        [HttpGet]
        public bool getUser(string Username,string password )
      {
            bool status = false;
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                status = objEntity.Users_Register.Where(a=>a.UserName==Username && a.Password==password).Any();
               
            }
            catch (Exception ex)
            {
                throw;
            }
            return status;
        }
        [Route("UpdatePassword")]
        [HttpGet]
        public string UpdatePassword(string Username, string oldPassword,string newPassword)
        {
            string status = "";
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
              var  data = objEntity.Users_Register.Where(a => a.UserName == Username && a.Password == oldPassword).FirstOrDefault();
                if(data !=null)
                {
                    objEntity.Configuration.ProxyCreationEnabled = false;
                    data.Password = newPassword;
                 
                    int i = objEntity.SaveChanges();
                    if(i>0)
                    {
                        status = "success";
                    }
                    else
                    {
                        status = "faild";
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return status;
        }
        [Route("Login_Master")]
        [HttpGet]
        public string GetLogin(string Username, string password)
        {
            string loginType = "";
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            { //&& a.UserStatus==true
                var data = objEntity.Users_Register.Where(a => a.UserName == Username && a.Password == password ).Select(b=>b.UserType.ToUpper()).FirstOrDefault();
                if(data ==null)
                {
                    loginType = "Error";
                }
                else
                {
                    loginType = data;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return loginType;
        }
        [Route("GetUsers_RegisterDetail")]
        [HttpGet]
        public IEnumerable<Users_Register> GetExcel()
        {
            IEnumerable<Users_Register> objExcel = new List<Users_Register>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.Users_Register.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return objExcel;
        }
        [Route("Get_StateDetails")]
        [HttpGet]
        public IEnumerable<States> BindStates()
        {  
            IEnumerable<States> objState = new List<States>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objState = objEntity.HFA_GetStates().Select(a=> new States
                {
                    Codes=a.Codes.ToString(),
                    States_UT=a.States_UT //,
                    //Status =a.Status,
                     //Division=a.Division
                }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return objState;
        }

        [Route("HFA_DisttDetails")]
        [HttpGet]
        public IEnumerable<HFA_GetDistt_Result> BindDistricts(string stateCode)
        { 
            IEnumerable<HFA_GetDistt_Result> objDistt = new List<HFA_GetDistt_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objDistt = objEntity.HFA_GetDistt(stateCode);
            }
            catch (Exception)
            {
                throw;
            }
            return objDistt.ToList();
        }
        [Route("HFA_CityDetails")]
        [HttpGet]
        public IEnumerable<HFA_GetCity_Result> BindCity(string dCode)
        {    
            IEnumerable<HFA_GetCity_Result> objCity = new List<HFA_GetCity_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objCity = objEntity.HFA_GetCity(dCode).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return objCity.ToList();
        }
        [HttpPost]
        [Route("UserRegister")]
        public string InsertUser(RegisterUser data)
        {
            string message = "";
            if (data != null)
            {
                Users_Register obj = new Users_Register();
                obj.UserName = data.FirstName;
                obj.LastName = data.LastName;
                obj.Address = data.Address;

                obj.Password = data.Password;
                obj.DesignationId = data.DesignationId;
                obj.EmailId = data.EmailId;
                obj.MobileNo = data.MobileNo;
                obj.PhoneNo = data.PhoneNo;
                
                obj.StateId = Convert.ToInt32(data.StateId);
                obj.DisttId = Convert.ToInt32(data.DisttId);
                obj.CityId = Convert.ToInt32(data.CityId);

                obj.ZipCode = data.ZipCode;
                obj.LastLoginDate = Convert.ToDateTime(data.LastLoginDate);
                obj.PasswordChangeDate = Convert.ToDateTime(data.PasswordChangeDate);
                obj.TaskName = data.TaskName;
                EmployeeEntities objEntity = new EmployeeEntities();
                objEntity.Users_Register.Add(obj);
                int i = objEntity.SaveChanges();
                if (i > 0)
                {
                    message = "User registration has been succeffully";
                }
                else
                {
                    message = "Registration faild";
                }
            }
            return message;
        }

        [Route("GetUserManagement")]
        [HttpGet]
        public IEnumerable<UserManagementVM> GetUserMange()
        {
            IEnumerable<UserManagementVM> objUser = new List<UserManagementVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objUser = objEntity.Users_Register.Select(a => new UserManagementVM
                {
                    States_Id = a.State_Master.StateId.ToString(),
                    UserId = a.UserId.ToString(),
                    UserName = a.UserName.ToString(),
                    LastName = a.LastName.ToString(),
                    UserType = a.UserType.ToString(),
                    Address = a.Address.ToString(),
                    Password = a.Password.ToString(),
                    DesignationId = a.DesignationId,  
                    StateName = a.State_Master.States_UT,
                    District = a.Distt_Master.District,
                    DisttId = a.Distt_Master.DisttId,
                    City = a.City_Master.City,
                    CityId = a.City_Master.CityId,
                    ZipCode = a.ZipCode,
                    LastLoginDate = a.LastLoginDate.ToString(),
                    PasswordChangeDate = a.PasswordChangeDate.ToString(),
                    RoleName = objEntity.RoleMasters.Where(b=>b.RoleId==a.RoleId).Select(c=>c.RoleName).FirstOrDefault(),
                    EmailId = a.EmailId,
                    MobileNo = a.MobileNo,
                    PhoneNo = a.PhoneNo,
                    TaskName = a.TaskName,
                    UserStatus = a.UserStatus,
                }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return objUser;
        }

        [HttpPost]
        [Route("UpdateCity_MasterData")]
        public string UpdateCity_MasterData(City_Master data)
        {
            string message = "";
            if (data != null)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
                var d = objEntity.City_Master.Where(a => a.CityCode == data.CityCode).FirstOrDefault();
                if(d !=null)
                {
                    d.City = data.City;
//                    d.StateCode = data.StateCode;
                    d.CityCode = data.CityCode;
                    d.Dcode = data.Dcode;
                    d.Status = data.Status;
                }
              
                int i = objEntity.SaveChanges();
                if (i > 0)
                {
                    message = "City Master data saved succeffully";
                }
                else
                {
                    message = "Save failed";
                }
            }
            return message;
        }


    }
}
