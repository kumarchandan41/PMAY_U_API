using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeeklyReportAPI.ViewModel;
using WeeklyReportAPI.Models;

namespace WeeklyReportAPI.Controllers
{
    [RoutePrefix("API/HFAMaster")]
    public class HFAMasterController : ApiController
    {
        [HttpPost]
        [Route("InsertMasterData")]
        public string AddHfaMaster(StateMasterVM data)
        {
            string message = "";
            if(data != null)
            {
                State_Master objMaster = new State_Master();
                objMaster.States_UT = data.StateName;
                objMaster.Codes = data.StateCode;
                objMaster.Division = data.Division;
                EmployeeEntities objEntity = new EmployeeEntities();
                objEntity.State_Master.Add(objMaster);
                int i = objEntity.SaveChanges();
                if(i >0)
                {
                    message = "State details has been inserted";
                }
                else
                {
                    message = "State insertion has been faild";
                }
            }
            return message;
        }

        [HttpPost]
        [Route("InsertDistt_MasterData")]
        public string InsertDistt_MasterData(DistrictMasterVM data)
        {
            string message = "";
            if (data != null)
            {

        //        DisttId { get; set;
        //        }
        //public string District { get; set; }
        //public string Distt { get; set; }
        //public string StateCode { get; set; }
        //public string Dcode { get; set; }
        //public string sunDisttCode { get; set; }
        //public string BackwardDistrict { get; set; }
        //public string Minority { get; set; }
        //public string ActiveFlag { get; set; }
        //public string Status { get; set; }
        //public string StatesName

                Distt_Master objMaster = new Distt_Master();
                objMaster.StateCode = data.StateCode;
                objMaster.District = data.District;
                objMaster.DisttId = data.DisttId;
                objMaster.Distt = data.Distt;
                objMaster.BackwardDistrict = data.BackwardDistrict;
                objMaster.Minority = data.Minority;
                objMaster.ActiveFlag = data.ActiveFlag;
                objMaster.Status = data.Status;
  
                EmployeeEntities objEntity = new EmployeeEntities();
                objEntity.Distt_Master.Add(objMaster);
                int i = objEntity.SaveChanges();
                if (i > 0)
                {
                    message = "Distt details has been inserted";
                }
                else
                {
                    message = "Distt insertion has been faild";
                }
            }
            return message;
        }

        [HttpPost]
        [Route("UpdateStateData")]
        public string UpdateHfaMaster(StateMasterVM data)
        {
            string message = "";
            if (data != null)
            {
                
                EmployeeEntities objEntity = new EmployeeEntities();
                State_Master objMaster = new State_Master();
                objMaster = objEntity.State_Master.Where(a => a.Codes == data.StateCode).FirstOrDefault();

                if (objMaster != null)
                {
                   objMaster.States_UT = data.StateName;
                    objMaster.Codes = data.StateCode;
                    objMaster.Division = data.Division;
                                   
                    int i = objEntity.SaveChanges();
                    if (i > 0)
                    {
                        message = "State details has been updated";
                    }
                    else
                    {
                        message = "State updation has been faild";
                    }
                }
              
            }
            return message;
        }
        [HttpGet]
        [Route("GetMasterData")]
        public IEnumerable<State_Master> GetHfaMaster()
        {
            IEnumerable<State_Master> lstStateMaster = new List<State_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.Configuration.ProxyCreationEnabled = false;
            lstStateMaster = objEntity.State_Master.ToList();
            return lstStateMaster;
        }
        [HttpGet]
        [Route("GetDisttData")]
        public IEnumerable<Distt_Master> GetDisttHfaMaster()
        {
            IEnumerable<Distt_Master> lstDisttMaster = new List<Distt_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.Configuration.ProxyCreationEnabled = false;
            lstDisttMaster = objEntity.Distt_Master.ToList();
            return lstDisttMaster;
        }

        [HttpGet]
        [Route("GetAllDisttData")]
        public IEnumerable<DistrictMasterVM> GetAllDisttData()
        {
            IEnumerable<DistrictMasterVM> lstDisttMaster = new List<DistrictMasterVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.Configuration.ProxyCreationEnabled = false;
            lstDisttMaster = (from a in objEntity.Distt_Master
                              join b in objEntity.State_Master on a.StateCode equals b.Codes
                              orderby a.District
                              select new DistrictMasterVM
                              {
                                  DisttId = a.DisttId,
                                  District = a.District,
                                  Distt = a.Distt,
                                  StateCode = a.StateCode,
                                  Dcode = a.Dcode,
                                  sunDisttCode = a.sunDisttCode,
                                  BackwardDistrict = a.BackwardDistrict,
                                  Minority = a.Minority,
                                  ActiveFlag = a.ActiveFlag,
                                  Status = a.Status,
                                  StatesName = b.States_UT
                              }).OrderBy(c => c.StatesName).ToList();
            return lstDisttMaster;
         

    }

    [HttpGet]
        [Route("GetAllCityData")]
        public IEnumerable<CityMasterVM> GetAllCityData()
        {
            IEnumerable<CityMasterVM> lstCityMaster = new List<CityMasterVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.Configuration.ProxyCreationEnabled = false;
            lstCityMaster =  (from a in objEntity.City_Master
                              join b in objEntity.Distt_Master on a.Dcode equals b.Dcode
                              join c in objEntity.State_Master on b.StateCode equals  c.Codes
                              orderby a.City
                              select new CityMasterVM
                             {
                                  District = b.District,
                                  Dcode = a.Dcode,
                                  City =a.City,
                                  CityCode =a.CityCode,
                                  StatesName = c.States_UT,
                                  Codes = b.StateCode,
                                  ActiveFlag = b.ActiveFlag,
                                  Status = c.Status
                              }).ToList();
            return lstCityMaster;
        }
    }
}

