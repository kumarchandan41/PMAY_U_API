using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ExcelDataReader;
//using MasterApi.Models;

using System.Data.Entity.SqlServer;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using WeeklyReportAPI.Models;
using WeeklyReportAPI.ViewModel;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace WeeklyReportAPI.Controllers
{
    [RoutePrefix("Api/Admin_Value")]
    public class Admin_ValuesController : ApiController
    {
        [HttpGet]
        [Route("GetSchemeData")]
        //get api for scheme master
        public List<Scheme_Master> GetSchemeData()
        {
            List<Scheme_Master> lst = new List<Scheme_Master>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.Scheme_Master.AsEnumerable<Scheme_Master>().OrderBy(x => x.SchemeName).ToList();
            }
            return lst;
        }

        [HttpPost]
        [Route("SubmitSchemeData")]
        //post api for scheme master
        public HttpResponseMessage SubmitSchemeData(Scheme_Master obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {

                if (ent.Scheme_Master.Any(ac => ac.SchemeName.Equals(obj.SchemeName)))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                else
                {
                    ent.Scheme_Master.Add(obj);
                    ent.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
        }

        //[HttpGet]
        //[Route("DeleteSchemeData")]
        ////delete api for scheme master
        //public HttpResponseMessage DeleteSchemeData(int id)
        //{
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        Scheme_Master record = ent.Scheme_Master.Where(x => x.SchemeId == id).FirstOrDefault<Scheme_Master>();
        //        ent.Scheme_Master.Remove(record);
        //        ent.SaveChanges();
        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }

        //}

        [HttpGet]
        [Route("DeleteSchemeData/{id}")]
        //delete api for scheme master
        public HttpResponseMessage DeleteSchemeData(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Scheme_Master record = ent.Scheme_Master.Where(x => x.SchemeId == id).FirstOrDefault<Scheme_Master>();
                ent.Scheme_Master.Remove(record);
                ent.SaveChanges();
                var message = Request.CreateResponse(HttpStatusCode.OK);
                return message;
            }

        }


        [HttpPost]
        [Route("UpdateSchemeData")]
        //update api for scheme master
        public HttpResponseMessage UpdateSchemeData(Scheme_Master value)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Scheme_Master record = ent.Scheme_Master.Where(x => x.SchemeId == value.SchemeId).FirstOrDefault<Scheme_Master>();
                record.SchemeName = value.SchemeName;
                record.SchemeShortName = value.SchemeShortName;
                record.SchemePeriod = value.SchemePeriod;
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        //[HttpGet]
        //[Route("GetComponentData")]
        ////get api for component master
        //public List<ComponentMaster> GetComponentData([FromUri]string id = null)
        //{
        //    List<ComponentMaster> lst = new List<ComponentMaster>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        lst = ent.ComponentMasters.AsEnumerable<ComponentMaster>().Where(x => x.SchemeShortName == id).OrderBy(x => x.Cname).ToList();

        //    }
        //    return lst;
        //}

        [HttpGet]
        [Route("GetComponentData/{id}")]
        //get api for component master
        public List<ComponentMaster> GetComponentData([FromUri]string id = null)
        {
            List<ComponentMaster> lst = new List<ComponentMaster>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.ComponentMasters.AsEnumerable<ComponentMaster>().Where(x => x.SchemeShortName == id).OrderBy(x => x.Cname).ToList();

            }
            return lst;
        }


        [HttpPost]
        [Route("SubmitSchemeComponentData")]
        //post api for component master
        public HttpResponseMessage SubmitSchemeComponentData(ComponentMaster obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {


                ent.ComponentMasters.Add(obj);
                ent.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);


            }

        }

        //[HttpGet]
        //[Route("DeleteSchemeComponentData")]
        ////delete api for component master
        //public HttpResponseMessage DeleteSchemeComponentData(int id)
        //{
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        ComponentMaster record = ent.ComponentMasters.Where(x => x.Cid == id).FirstOrDefault<ComponentMaster>();
        //        ent.ComponentMasters.Remove(record);
        //        ent.SaveChanges();
        //    }
        //    var message = Request.CreateResponse(HttpStatusCode.OK);
        //    return message;
        //}
        [HttpGet]
        [Route("DeleteSchemeComponentData/{id}")]
        //delete api for component master
        public HttpResponseMessage DeleteSchemeComponentData(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                ComponentMaster record = ent.ComponentMasters.Where(x => x.Cid == id).FirstOrDefault<ComponentMaster>();
                ent.ComponentMasters.Remove(record);
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }


        [HttpPost]
        [Route("UpdateSchemeComponentData")]
        //update api for component master
        public HttpResponseMessage UpdateSchemeComponentData(ComponentMaster value)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                ComponentMaster record = ent.ComponentMasters.Where(x => x.Cid == value.Cid).FirstOrDefault<ComponentMaster>();
                record.SchemeShortName = value.SchemeShortName;
                record.Cname = value.Cname;
                record.SchemeComponentName = value.SchemeComponentName;
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        //[HttpGet]
        //[Route("GetStateData")]
        //public List<State_Master> GetStateData(int pageNo = 2, int pageSize = 50)
        //{


        //    // Get total number of records

        //    List<State_Master> lst = new List<State_Master>();

        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        int skip = (pageNo - 1) * pageSize;
        //        int total = ent.State_Master.Count();
        //        lst = ent.State_Master.AsEnumerable<State_Master>().Take(pageSize).ToList();

        //    }
        //    return lst;
        //}

        [HttpGet]
        [Route("GetStateData")]
        //get api for state master
        public IEnumerable<State_Master> GetStateData()
        {
            IEnumerable<State_Master> lst = new List<State_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.Configuration.ProxyCreationEnabled = false;
            lst = objEntity.State_Master.ToList();
            return lst;
        }


        [HttpPost]
        [Route("SubmitStateData")]
        //post api for state master
        public HttpResponseMessage SubmitStateData(State_Master obj)
        {

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                if (ent.State_Master.Any(ac => ac.States.Equals(obj.States)))
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    ent.State_Master.Add(obj);
                    ent.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }

        }

        [HttpGet]
        [Route("DeleteStateData/{id}")]
        //delete api for state master
        public HttpResponseMessage DeleteStateData(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                State_Master record = ent.State_Master.Where(x => x.StateId == id).FirstOrDefault<State_Master>();
                ent.State_Master.Remove(record);
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        [HttpPost]
        [Route("UpdateStateData")]
        //update api for state master
        public HttpResponseMessage UpdateStateData(State_Master value)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                State_Master record = ent.State_Master.Where(x => x.StateId == value.StateId).FirstOrDefault<State_Master>();
                record.States_UT = value.States_UT;
                record.Codes = value.Codes;
                record.Division = value.Division;
                record.UpdatedOn = value.UpdatedOn;
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        //[HttpGet]
        //[Route("GetDistrictData")]
        ////get api for district master
        //public List<Distt_Master> GetDistrictData([FromUri]string id)
        //{
        //    List<Distt_Master> lst = new List<Distt_Master>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        lst = ent.Distt_Master.AsEnumerable<Distt_Master>().Where(x => x.StateCode == id).OrderBy(x => x.District).ToList();

        //    }
        //    return lst;
        //}

        [HttpGet]
        [Route("GetDistrictData/{id}")]
        public IEnumerable<HFA_GetDistt_Result> GetDistrictData([FromUri]string id)
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetDistt_Result> objDistt = new List<HFA_GetDistt_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objDistt = objEntity.HFA_GetDistt(id);
            }
            catch (Exception ex)
            {
                throw;
            }
            return objDistt.ToList();
        }



        [HttpPost]
        [Route("SubmitDistrictData")]
        //post api for district master
        public HttpResponseMessage SubmitDistrictData(Distt_Master obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {

                if (ent.Distt_Master.Any(ac => ac.District.Equals(obj.District)))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                else
                {
                    ent.Distt_Master.Add(obj);
                    ent.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }

        }


        [HttpGet]
        [Route("DeleteDistrictData/{id}")]
        //delete api for district master
        public HttpResponseMessage DeleteDistrictData(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Distt_Master record = ent.Distt_Master.Where(x => x.DisttId == id).FirstOrDefault<Distt_Master>();
                ent.Distt_Master.Remove(record);
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        [HttpPost]
        [Route("UpdateDistrictData")]
        //update api for state master
        public HttpResponseMessage UpdateDistrictData(Distt_Master value)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Distt_Master record = ent.Distt_Master.Where(x => x.DisttId == value.DisttId).FirstOrDefault<Distt_Master>();
                record.District = value.District;
                record.Dcode = value.Dcode;
                record.BackwardDistrict = value.BackwardDistrict;
                record.Minority = value.Minority;
                record.StateCode = value.StateCode;
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        [HttpGet]
        [Route("GetConsistuencyData")]
        //get api for constituency master
        public List<Constituency_Mster> GetConsistuencyData()
        {
            List<Constituency_Mster> lst = new List<Constituency_Mster>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.Constituency_Mster.AsEnumerable<Constituency_Mster>().ToList();

            }
            return lst;
        }

        [HttpPost]
        [Route("SubmitConstituencyData")]
        //post api for constituency master
        public HttpResponseMessage SubmitConstituencyData(Constituency_Mster obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {

                if (ent.Constituency_Mster.Any(ac => ac.ConstituencyName.Equals(obj.ConstituencyName)))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                else
                {
                    ent.Constituency_Mster.Add(obj);
                    ent.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }

        }

        //[HttpGet]
        //[Route("DeleteConstituencyData")]
        ////delete api for constituency master
        //public HttpResponseMessage DeleteConstituencyData(int id)
        //{
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        Constituency_Mster record = ent.Constituency_Mster.Where(x => x.ConstituencyId == id).FirstOrDefault<Constituency_Mster>();
        //        ent.Constituency_Mster.Remove(record);
        //        ent.SaveChanges();
        //    }
        //    var message = Request.CreateResponse(HttpStatusCode.OK);
        //    return message;
        //}
        [HttpGet]
        [Route("DeleteConstituencyData/{id}")]
        //delete api for constituency master
        public HttpResponseMessage DeleteConstituencyData(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Constituency_Mster record = ent.Constituency_Mster.Where(x => x.ConstituencyId == id).FirstOrDefault<Constituency_Mster>();
                ent.Constituency_Mster.Remove(record);
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        [HttpPost]
        [Route("UpdateConstituencyData")]
        //update api for state master
        public HttpResponseMessage UpdateConstituencyData(Constituency_Mster value)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Constituency_Mster record = ent.Constituency_Mster.Where(x => x.ConstituencyId == value.ConstituencyId).FirstOrDefault<Constituency_Mster>();
                record.ConstituencyName = value.ConstituencyName;
                record.ConstituencyNumber = value.ConstituencyNumber;
                record.NameShittingMp = value.NameShittingMp;
                record.CityCode = value.CityCode;

                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }


        //[HttpGet]
        //[Route("GetCityData")]
        ////get api for city master
        //public List<City_Master> GetCityData([FromUri]string id = null, [FromUri]string dcode = null)
        //{

        //    List<City_Master> lst = new List<City_Master>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        if (dcode == "null")
        //        {
        //            lst = ent.City_Master.AsEnumerable<City_Master>().Where(x => x.StateCode == id || x.Dcode == dcode).ToList();
        //        }
        //        else
        //        {
        //            lst = ent.City_Master.AsEnumerable<City_Master>().Where(x => x.StateCode == id && x.Dcode == dcode).ToList();
        //        }


        //    }
        //    return lst;
        //}
        [HttpGet]
        [Route("GetCityData/{id}/{dcode}")]
        //get api for city master
        public IEnumerable<City_Master> GetCityData([FromUri]string id = null, [FromUri]string dcode = null)
        {
            IEnumerable<City_Master> lst = new List<City_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.Configuration.ProxyCreationEnabled = false;
            lst = objEntity.City_Master.Where(x => x.StateCode == id && x.Dcode == dcode).ToList();
            return lst;
        }
        //[HttpGet]
        //[Route("GetCityConstituency")]
        ////get api for city master
        //public List<City_Master> GetCityConstituency()
        //{
        //    List<City_Master> lst = new List<City_Master>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {

        //        lst = ent.City_Master.AsEnumerable<City_Master>().OrderBy(x => x.City).ToList();

        //    }
        //    return lst;
        //}
        [HttpGet]
        [Route("GetCityConstituency")]
        //get api for city master
        public IEnumerable<City_Master> GetCityConstituency()
        {
            IEnumerable<City_Master> lst = new List<City_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.Configuration.ProxyCreationEnabled = false;
            lst = objEntity.City_Master.ToList();
            return lst;
        }


        [HttpPost]
        [Route("SubmitCityData")]
        //post api for city master
        public HttpResponseMessage SubmitCityData(City_Master obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {

                if (ent.City_Master.Any(ac => ac.City.Equals(obj.City)))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                else
                {
                    ent.City_Master.Add(obj);
                    ent.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

            }


        }

        //[HttpGet]
        //[Route("DeleteCityData")]
        ////delete api for city master
        //public HttpResponseMessage DeleteCityData(int id)
        //{
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        City_Master record = ent.City_Master.Where(x => x.CityId == id).FirstOrDefault<City_Master>();
        //        ent.City_Master.Remove(record);
        //        ent.SaveChanges();
        //    }
        //    var message = Request.CreateResponse(HttpStatusCode.OK);
        //    return message;
        //}
        [HttpGet]
        [Route("DeleteCityData/{id}")]
        //delete api for city master
        public HttpResponseMessage DeleteCityData(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                City_Master record = ent.City_Master.Where(x => x.CityId == id).FirstOrDefault<City_Master>();
                ent.City_Master.Remove(record);
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }
        [HttpPost]
        [Route("UpdateCityData")]
        //update api for city master
        public HttpResponseMessage UpdateCityData(City_Master value)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                City_Master record = ent.City_Master.Where(x => x.CityId == value.CityId).FirstOrDefault<City_Master>();
                record.City = value.City;
                record.CityCode = value.CityCode;
                record.Dcode = value.Dcode;
                record.StateCode = value.StateCode;

                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        //[HttpGet]
        //[Route("GetStateDistrictId")]
        //// get district on behalf of state
        //public List<Distt_Master> GetStateDistrictId([FromUri]string id)
        //{
        //    List<Distt_Master> lst = new List<Distt_Master>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        lst = ent.Distt_Master.Where(x => x.StateCode == id).OrderBy(x => x.District).ToList();
        //        // lst.Add(query);

        //    }
        //    return lst;
        //}

        [HttpGet]
        [Route("GetStateDistrictId/{id}")]
        public IEnumerable<HFA_GetDistt_Result> GetStateDistrictId([FromUri]string id)
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetDistt_Result> objDistt = new List<HFA_GetDistt_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objDistt = objEntity.HFA_GetDistt(id);
            }
            catch (Exception ex)
            {
                throw;
            }
            return objDistt.ToList();
        }


        //[HttpGet]
        //[Route("GetDistrictCityId")]
        //// get city on behalf of district
        //public List<City_Master> GetDistrictCityId([FromUri]string id)
        //{
        //    List<City_Master> lst = new List<City_Master>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        lst = ent.City_Master.Where(x => x.Dcode == id).ToList();

        //    }
        //    return lst;
        //}

        //[Route("GetDistrictCityId")]
        //[HttpGet]
        //public IEnumerable<HFA_GetCity_Result> GetDistrictCityId(string id)
        //{    //http://localhost:57855/Api/Builder/StateDetails
        //    IEnumerable<HFA_GetCity_Result> objCity = new List<HFA_GetCity_Result>();
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    try
        //    {
        //        objCity = objEntity.HFA_GetCity(id).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    return objCity.ToList();
        //}
        [HttpGet]
        [Route("GetDistrictCityId/{id}")]
        // get city on behalf of district
        public IEnumerable<City_Master> GetDistrictCityId([FromUri]string id)
        {

            IEnumerable<City_Master> lst = new List<City_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.Configuration.ProxyCreationEnabled = false;
            lst = objEntity.City_Master.Where(x => x.Dcode == id).ToList();
            return lst;
        }

        [HttpGet]
        [Route("GetCSMCNumber")]
        // get csmcnumber on behalf of city
        public List<Projct_Details> GetCSMCNumber([FromUri]string id)
        {
            List<Projct_Details> lst = new List<Projct_Details>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.Projct_Details.Where(x => x.CityCode == id).ToList();

            }
            return lst;
        }
        // get projecttitle on behalf of csmcnumber
        public HttpResponseMessage GetProjectHouses([FromUri]string id = null, [FromUri]string dcode = null, [FromUri]string ccode = null, [FromUri]string scheme = null)
        {
            List<Projct_Details> lst = new List<Projct_Details>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                var result = (from p in ent.Projct_Details
                              select new
                              {
                                  p.TotalSanction,
                                  p.StateCode,
                                  p.DistrictCode,
                                  p.CityCode,
                                  p.CSMCNumber,
                                  Houses = p.ProjectTitle + "," + p.TotalSanction,

                              });

                var result1 = result.Where(x => (x.StateCode == id && x.DistrictCode == dcode && x.CityCode == ccode && x.CSMCNumber == scheme)).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, result1);

            }
        }

        // get projectCode on behalf of projecttitle
        public List<Projct_Details> GetProjectCode([FromUri]string id = null, [FromUri]string dcode = null, [FromUri]string ccode = null, [FromUri]string scheme = null, [FromUri]decimal component = 0)
        {
            List<Projct_Details> lst = new List<Projct_Details>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.Projct_Details.Where(x => (x.StateCode == id && x.DistrictCode == dcode && x.CityCode == ccode && x.CSMCNumber == scheme && x.TotalSanction == component)).ToList();

            }
            return lst;
        }


        [HttpPost]
        [Route("SubmitProjectDetails")]
        //post api for project details
        public HttpResponseMessage SubmitProjectDetails(Projct_Details obj)
        {

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                ent.Projct_Details.Add(obj);


                ent.SaveChanges();


                long id = obj.ProjectId;
                string citycode = obj.CityCode;
                string distcode = obj.DistrictCode;
                string statecode = obj.StateCode;
                string componentname = obj.SchemeComponent.Substring(0, 1);

                string scheme = obj.Scheme.Substring(0, 1) + componentname + 'P';
                var message = statecode + distcode + citycode + scheme + id;
                var message1 = id;
                var data = obj;



                return Request.CreateResponse(HttpStatusCode.Created, new ReturnStatus { StatusCode = message.ToString(), Message = message1.ToString() });

            }


        }


        [HttpGet]
        [Route("GetProjectDetailData")]
        //get api for project detail
        public HttpResponseMessage GetProjectDetailData([FromUri]string id = null, [FromUri]string dcode = null, [FromUri]string ccode = null, [FromUri]string scheme = null, [FromUri]string component = null)
        {
            List<Projct_Details> lst = new List<Projct_Details>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                var result = (from p in ent.Projct_Details
                              join o in ent.State_Master on p.StateCode equals o.Codes
                              join m in ent.Distt_Master on p.DistrictCode equals m.Dcode
                              join n in ent.City_Master on p.CityCode equals n.CityCode

                              join q in ent.Physical_Progress_Report on p.ProjectCode equals q.ProjectCode
                              into edept
                              from f in edept.DefaultIfEmpty()

                              select new
                              {
                                  o.States,
                                  p.BeneficiaryShare,
                                  p.CentralAssistance,
                                  m.District,
                                  n.City,
                                  o.Codes,
                                  m.Dcode,
                                  n.CityCode,
                                  p.CSMCDate,
                                  p.CSMCNumber,
                                  p.FirstInstallment,
                                  p.NewSanction,
                                  p.OtherCost,
                                  p.ProjectId,
                                  p.ProjectAgencies,
                                  p.ProjectCode,
                                  p.ProjectCost,
                                  p.ProjectDuration,
                                  p.ProjectStatus,
                                  p.ProjectTitle,
                                  p.Scheme,
                                  p.SchemeComponent,
                                  p.StateGrant,
                                  p.TotalSanction,
                                  p.ULB,
                                  p.UpgradeSanction,

                                  ConstructionCompleted = (f.ConstructionCompleted.ToString() == null) ? "" : f.ConstructionCompleted.ToString(),
                                  DrainageSupply = (f.DrainageSupply == null) ? "" : f.DrainageSupply,
                                  FinishingStage = (f.FinishingStage == null) ? "" : f.FinishingStage,
                                  GroundLevel = (f.GroundLevel == null) ? "" : f.GroundLevel,
                                  LinterLevel = (f.LinterLevel == null) ? "" : f.LinterLevel,
                                  NonStarterHouse = (f.NonStarterHouse == null) ? "" : f.NonStarterHouse,
                                  Pinth = (f.Pinth == null) ? "" : f.Pinth,
                                  PowerSupply = (f.PowerSupply == null) ? "" : f.PowerSupply,
                                  RoofLevel = (f.RoofLevel == null) ? "" : f.RoofLevel,
                                  SuperStructure = (f.SuperStructure == null) ? "" : f.SuperStructure,
                                  TotalHouseOccupiedBeneficiary = (f.TotalHouseOccupiedBeneficiary.ToString() == null) ? "" : f.TotalHouseOccupiedBeneficiary.ToString(),
                                  TotalProgressHouse = (f.TotalProgressHouse.ToString() == null) ? "" : f.TotalProgressHouse.ToString(),
                                  WaterSupply = (f.WaterSupply == null) ? "" : f.WaterSupply,
                                  EntryDate = (f.EntryDate.ToString() == null) ? "" : f.EntryDate.ToString(),
                                  PhysicalProgressId = (f.PhysicalProgressId.ToString() == null) ? "" : f.PhysicalProgressId.ToString(),

                              });
                if (dcode == "null" && ccode == "null" && scheme == "null" && component == "null")
                {
                    var result1 = result.Where(x => (x.Codes == id)).ToList();
                    return Request.CreateResponse(HttpStatusCode.OK, result1);
                }

                else if (ccode == "null" && scheme == "null" && component == "null")
                {
                    var result1 = result.Where(x => (x.Codes == id && x.Dcode == dcode)).ToList();
                    return Request.CreateResponse(HttpStatusCode.OK, result1);
                }
                else if (ccode == "null" && dcode == "null" && component == "null")
                {
                    var result1 = result.Where(x => (x.Codes == id && x.Scheme == scheme)).ToList();
                    return Request.CreateResponse(HttpStatusCode.OK, result1);
                }
                else if (ccode == "null" && dcode == "null")
                {
                    var result1 = result.Where(x => (x.Codes == id && x.Scheme == scheme && x.SchemeComponent == component)).ToList();
                    return Request.CreateResponse(HttpStatusCode.OK, result1);
                }
                else if (scheme == "null" && component == "null")
                {
                    var result1 = result.Where(x => (x.Codes == id && x.Dcode == dcode && x.CityCode == ccode)).ToList();
                    return Request.CreateResponse(HttpStatusCode.OK, result1);
                }
                else if (component == "null")
                {
                    var result1 = result.Where(x => (x.Codes == id && x.Dcode == dcode && x.CityCode == ccode && x.Scheme == scheme)).ToList();
                    return Request.CreateResponse(HttpStatusCode.OK, result1);
                }
                else
                {
                    var result1 = result.Where(x => (x.Codes == id && x.Dcode == dcode && x.CityCode == ccode && x.Scheme == scheme && x.SchemeComponent == component)).ToList();
                    return Request.CreateResponse(HttpStatusCode.OK, result1);
                }


            }


        }



        [HttpGet]
        [Route("DeleteProjectDetailData")]
        //delete api for project detail
        public HttpResponseMessage DeleteProjectDetailData(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Projct_Details record = ent.Projct_Details.Where(x => x.ProjectId == id).FirstOrDefault<Projct_Details>();
                ent.Projct_Details.Remove(record);
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        [HttpPost]
        [Route("UpdateProjectDetailData")]
        //update api for project detail
        public HttpResponseMessage UpdateProjectDetailData(Projct_Details value)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Projct_Details record = ent.Projct_Details.Where(x => x.ProjectId == value.ProjectId).FirstOrDefault<Projct_Details>();
                record.BeneficiaryShare = value.BeneficiaryShare;
                record.CentralAssistance = value.CentralAssistance;
                record.CityCode = value.CityCode;
                record.CSMCDate = value.CSMCDate;
                record.CSMCNumber = value.CSMCNumber;
                record.DistrictCode = value.DistrictCode;
                record.FirstInstallment = value.FirstInstallment;
                record.NewSanction = value.NewSanction;
                record.ProjectCost = value.ProjectCost;
                record.ProjectStatus = value.ProjectStatus;
                record.ProjectTitle = value.ProjectTitle;
                record.Scheme = value.Scheme;
                record.StateCode = value.StateCode;
                record.StateGrant = value.StateGrant;
                record.ULB = value.ULB;
                record.TotalSanction = value.TotalSanction;
                record.UpgradeSanction = value.UpgradeSanction;
                record.OtherCost = value.OtherCost;
                record.ProjectDuration = value.ProjectDuration;
                record.SchemeComponent = value.SchemeComponent;
                record.ProjectAgencies = value.ProjectAgencies;


                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        [HttpPost]
        [Route("UpdateProjectCodeData")]
        //update api for state master
        public HttpResponseMessage UpdateProjectCodeData(Projct_Details value)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Projct_Details record = ent.Projct_Details.Where(x => x.ProjectId == value.ProjectId).FirstOrDefault<Projct_Details>();
                record.ProjectCode = value.ProjectCode;

                ent.SaveChanges();

            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }

        [HttpGet]
        [Route("GetSchemeComponentId")]
        // get component on behalf of scheme
        public List<ComponentMaster> GetSchemeComponentId([FromUri]string id)
        {
            List<ComponentMaster> lst = new List<ComponentMaster>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.ComponentMasters.Where(x => x.SchemeShortName == id).ToList();

            }
            return lst;
        }


        [HttpGet]
        [Route("GetAgencyId")]
        // get agency on behalf of city
        public List<ULB_Agencies_Share> GetAgencyId([FromUri]string id)
        {
            List<ULB_Agencies_Share> lst = new List<ULB_Agencies_Share>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.ULB_Agencies_Share.Where(x => x.CityCode == id).ToList();

            }
            return lst;
        }

        [HttpPost]
        [Route("SubmitAgencyData")]
        //post api for agency master
        public HttpResponseMessage SubmitAgencyData(ULB_Agencies_Share obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {

                ent.ULB_Agencies_Share.Add(obj);
                ent.SaveChanges();
                string agency = obj.ULBAgencyShare;
                var message = agency;
                return Request.CreateResponse(HttpStatusCode.Created, new ReturnStatus { StatusCode = message.ToString() });

            }


        }
        [HttpPost]
        [Route("UpdateAgencyMasterData")]
        //update api for agency master
        public HttpResponseMessage UpdateAgencyMasterData(ULB_Agencies_Share value)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                ULB_Agencies_Share record = ent.ULB_Agencies_Share.Where(x => x.CityCode == value.CityCode).FirstOrDefault<ULB_Agencies_Share>();
                record.ULBAgencyShare = value.ULBAgencyShare;



                ent.SaveChanges();
                string agencyShare = value.ULBAgencyShare;

                var message = agencyShare;
                return Request.CreateResponse(HttpStatusCode.Created, new ReturnStatus { StatusCode = message.ToString() });
            }

        }

        [HttpPost]
        [Route("SubmitPysicalProgressReport")]
        //post api for physical progress report
        public HttpResponseMessage SubmitPysicalProgressReport(List<Physical_Progress_Report> obj)
        {

            using (EmployeeEntities ent = new EmployeeEntities())
            {


                //Loop and insert records.
                foreach (Physical_Progress_Report physicalprogress in obj)
                {
                    if (physicalprogress.PhysicalProgressId == 0)
                    {
                        ent.Physical_Progress_Report.Add(physicalprogress);
                        physicalprogress.EntryDate = DateTime.Now;
                        ent.SaveChanges();
                    }
                    else
                    {
                        Physical_Progress_Report record = ent.Physical_Progress_Report.Where(x => x.PhysicalProgressId == physicalprogress.PhysicalProgressId).FirstOrDefault<Physical_Progress_Report>();
                        record.DrainageSupply = physicalprogress.DrainageSupply;
                        record.FinishingStage = physicalprogress.FinishingStage;
                        record.GroundLevel = physicalprogress.GroundLevel;
                        record.LinterLevel = physicalprogress.LinterLevel;
                        record.NonStarterHouse = physicalprogress.NonStarterHouse;
                        record.Pinth = physicalprogress.Pinth;
                        record.PowerSupply = physicalprogress.PowerSupply;
                        record.RoofLevel = physicalprogress.RoofLevel;
                        record.SuperStructure = physicalprogress.SuperStructure;
                        record.TotalHouseOccupiedBeneficiary = physicalprogress.TotalHouseOccupiedBeneficiary;
                        record.TotalProgressHouse = physicalprogress.TotalProgressHouse;
                        record.WaterSupply = physicalprogress.WaterSupply;
                        record.ConstructionCompleted = physicalprogress.ConstructionCompleted;

                        ent.SaveChanges();



                    }
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }





        [HttpGet]
        [Route("GetStateWiseReport")]
        //get api for state wise
        public HttpResponseMessage GetStateWiseReport()

        {
            List<Projct_Details> lst = new List<Projct_Details>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                var result = (from p in ent.Projct_Details
                              join o in ent.State_Master on p.StateCode equals o.Codes
                              join q in ent.Physical_Progress_Report on p.ProjectCode equals q.ProjectCode
                              into edept
                              from f in edept.DefaultIfEmpty()
                              join t in ent.Project_Fund_Release on p.ProjectCode equals t.ProjectCode
                               into edp
                              from g in edp.DefaultIfEmpty()
                              group new { p, f, o.States, o.Codes, o, p.ProjectCode, p.ProjectCost, g } by o into empg
                              orderby empg.Max(x => x.o.States)

                              select new
                              {



                                  Codes = empg.Key.Codes,
                                  States = empg.Key.States,

                                  NumberofProject = empg.Count(),
                                  ProjectCost = empg.Sum(x => x.p.ProjectCost),
                                  CentralAssistance = empg.Sum(x => x.p.CentralAssistance),
                                  TotalSanction = empg.Sum(x => x.p.TotalSanction),
                                  ConstructionCompleted = empg.Sum(x => x.f.ConstructionCompleted),
                                  TotalHouseOccupiedBeneficiary = empg.Sum(x => x.f.TotalHouseOccupiedBeneficiary),
                                  TotalProgressHouse = empg.Sum(x => x.f.TotalProgressHouse),
                                  Grounding = empg.Sum(x => x.f.ConstructionCompleted + x.f.TotalProgressHouse),

                                  Release = empg.Sum(x => x.g.HFAAmount + x.g.TSPAmount + x.g.SCSPAmount),


                              }).ToList();



                return Request.CreateResponse(HttpStatusCode.OK, result);

            }


        }

        [HttpGet]
        [Route("GetStateDistrictWiseReport")]
        //get api for report district wise
        public List<state_district_report_wise_Result> GetStateDistrictWiseReport(string id)
        {
            EmployeeEntities ent = new EmployeeEntities();
            List<state_district_report_wise_Result> lstBulding = new List<state_district_report_wise_Result>();
            lstBulding = ent.state_district_report_wise(id).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("GetStateDistrictCityWiseReport")]
        //get api for city wise
        public List<city_wise_report_Result> GetStateDistrictCityWiseReport(string id)
        {
            EmployeeEntities ent = new EmployeeEntities();
            List<city_wise_report_Result> lstBulding = new List<city_wise_report_Result>();
            lstBulding = ent.city_wise_report(id).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("GetStateDistrictCityProjectWiseReport")]
        //get api for project code wise
        public List<project_wise_report_Result> GetStateDistrictCityProjectWiseReport(string id)
        {
            EmployeeEntities ent = new EmployeeEntities();
            List<project_wise_report_Result> lstBulding = new List<project_wise_report_Result>();
            lstBulding = ent.project_wise_report(id).ToList();
            return lstBulding;
        }

        [HttpPost]
        [Route("SubmitReleaseFundFlowInstallmentWise")]
        //post api for release fund flow 
        public HttpResponseMessage SubmitReleaseFundFlowInstallmentWise(List<Project_Fund_Release> obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                foreach (Project_Fund_Release ProjectRelease in obj)
                {
                    if (ProjectRelease.ReleaseId == 0)
                    {
                        ent.Project_Fund_Release.Add(ProjectRelease);

                        ent.SaveChanges();
                    }
                    else
                    {
                        Project_Fund_Release record = ent.Project_Fund_Release.Where(x => x.ReleaseId == ProjectRelease.ReleaseId).FirstOrDefault<Project_Fund_Release>();

                        record.Source = ProjectRelease.Source;
                        record.SanctionNumber = ProjectRelease.SanctionNumber;
                        record.HFAAmount = ProjectRelease.HFAAmount;
                        record.TSPAmount = ProjectRelease.TSPAmount;
                        record.SCSPAmount = ProjectRelease.SCSPAmount;
                        record.TxtSCSPDate = ProjectRelease.TxtSCSPDate;
                        ent.SaveChanges();

                    }
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK);

        }

        [HttpGet]
        [Route("GetReleaseFundFlow")]
        //get api for release fund flow 
        public HttpResponseMessage GetReleaseFundFlow([FromUri]string id = null, [FromUri]string dcode = null, [FromUri]string ccode = null, [FromUri]string scheme = null, [FromUri]string component = null)
        {

            List<Projct_Details> lst = new List<Projct_Details>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                var result = (from p in ent.Projct_Details
                              join o in ent.State_Master on p.StateCode equals o.Codes
                              join m in ent.Distt_Master on p.DistrictCode equals m.Dcode
                              join n in ent.City_Master on p.CityCode equals n.CityCode
                              join q in ent.Project_Fund_Release on p.ProjectCode equals q.ProjectCode
                             into edept
                              from g in edept.DefaultIfEmpty()
                              where g.Installment == component

                              select new
                              {

                                  o.States,
                                  m.District,
                                  n.City,
                                  o.Codes,
                                  m.Dcode,
                                  n.CityCode,
                                  p.FirstInstallment,
                                  p.ProjectId,
                                  p.ProjectCode,
                                  ReleaseId = (g.ReleaseId.ToString() == null) ? "" : g.ReleaseId.ToString(),
                                  Source = (g.Source.ToString() == null) ? "" : g.Source.ToString(),
                                  SanctionNumber = (g.SanctionNumber.ToString() == null) ? "" : g.SanctionNumber.ToString(),
                                  HFAAmount = (g.HFAAmount.ToString() == null) ? "" : g.HFAAmount.ToString(),
                                  TSPAmount = (g.TSPAmount.ToString() == null) ? "" : g.TSPAmount.ToString(),
                                  SCSPAmount = (g.SCSPAmount.ToString() == null) ? "" : g.SCSPAmount.ToString(),
                                  TxtSCSPDate = (g.TxtSCSPDate.ToString() == null) ? "" : g.TxtSCSPDate.ToString(),
                                  Installment = (g.Installment.ToString() == null) ? "" : g.Installment.ToString(),
                                  Release = (g.Release.ToString() == null) ? "" : g.Release.ToString(),

                              });

                var result1 = result.Where(x => (x.Codes == id && x.Dcode == dcode && x.CityCode == ccode && x.ProjectCode == scheme && x.Installment == component)).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, result1);


            }

        }

        [HttpPost]
        [Route("SubmitUCSubmission")]
        //post api for release fund flow 
        public HttpResponseMessage SubmitUCSubmission(Project_UC_Submission obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {

                if (obj.UCID == 0)

                {
                    ent.Project_UC_Submission.Add(obj);
                    ent.SaveChanges();
                }

                else
                {
                    Project_UC_Submission record = ent.Project_UC_Submission.Where(x => x.UCID == obj.UCID).FirstOrDefault<Project_UC_Submission>();
                    record.LetterNo = obj.LetterNo;
                    record.UCDate = obj.UCDate;
                    record.UCAmount = obj.UCAmount;
                    ent.SaveChanges();

                }

            }
            return Request.CreateResponse(HttpStatusCode.OK);

        }


        [HttpGet]
        [Route("GetUCSubmission")]
        //get api for uc submission
        public HttpResponseMessage GetUCSubmission([FromUri]string id = null, [FromUri]string dcode = null, [FromUri]string ccode = null, [FromUri]string scheme = null)
        {
            List<Project_Fund_Release> lst = new List<Project_Fund_Release>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                var result = (from p in ent.Project_Fund_Release

                              join q in ent.Project_UC_Submission on p.ReleaseId equals q.ReleaseId
                              into edept
                              from g in edept.DefaultIfEmpty()
                              select new
                              {

                                  p.Codes,
                                  p.Dcode,
                                  p.CityCode,
                                  p.ProjectCode,
                                  p.ReleaseId,
                                  p.Release,
                                  p.Installment,
                                  p.Source,
                                  TotalRelease = p.HFAAmount + p.TSPAmount + p.SCSPAmount,
                                  p.TSPAmount,
                                  p.TxtSCSPDate,
                                  p.SCSPAmount,
                                  p.HFAAmount,
                                  p.SanctionNumber,
                                  LetterNo = (g.LetterNo.ToString() == null) ? "" : g.LetterNo.ToString(),
                                  UCDate = (g.UCDate.ToString() == null) ? "" : g.UCDate.ToString(),
                                  UCAmount = (g.UCAmount.ToString() == null) ? "" : g.UCAmount.ToString(),
                                  UCID = (g.UCID.ToString() == null) ? "" : g.UCID.ToString(),
                                  Cummalative = edept.Sum(x => x.UCAmount),


                              });



                var result1 = result.Where(x => (x.Codes == id && x.Dcode == dcode && x.CityCode == ccode && x.ProjectCode == scheme)).ToList();

                return Request.CreateResponse(HttpStatusCode.OK, result1);


            }

        }

        [HttpGet]
        [Route("TotalUCInstallment1")]
        //get api for total sum of installment 1 uc 
        public HttpResponseMessage TotalUCInstallment1([FromUri]string id = null, [FromUri]string dcode = null)

        {
            List<Project_Fund_Release> lst = new List<Project_Fund_Release>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                var result = (from p in ent.Project_Fund_Release
                              where (p.ProjectCode).ToString() == id.ToString() && (p.Installment == dcode)
                              join q in ent.Project_UC_Submission on p.ProjectCode equals q.ProjectCode
                              into edept
                              from f in edept.DefaultIfEmpty()
                              where (f.ProjectCode).ToString() == id.ToString() && (f.Installment == dcode)
                              group new { p, f } by p into empg
                              select new
                              {

                                  ProjectCode = empg.Key.ProjectCode,
                                  UCAmount = empg.Sum(x => x.f.UCAmount)
                              }).ToList();

                return Request.CreateResponse(HttpStatusCode.OK, result);

            }
        }

        [HttpGet]
        [Route("TotalReleaseInstallment1")]
        //get api for total sum of installment 1 release
        public HttpResponseMessage TotalReleaseInstallment1([FromUri]string id = null, [FromUri]string dcode = null)

        {
            List<Project_Fund_Release> lst = new List<Project_Fund_Release>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {



                var result = (from f in ent.Project_Fund_Release

                              where (f.ProjectCode).ToString() == id.ToString() && (f.Installment == dcode)
                              group new { f } by f into empg
                              select new
                              {

                                  ProjectCode = empg.Key.ProjectCode,
                                  CummalativeRelease = empg.Sum(x => x.f.HFAAmount + x.f.TSPAmount + x.f.SCSPAmount),


                              }).ToList();



                return Request.CreateResponse(HttpStatusCode.OK, result.Sum(x => x.CummalativeRelease));

            }
        }

        [HttpGet]
        [Route("TotalUCInstallment2")]
        //get api for total sum of installment 2 uc 
        public HttpResponseMessage TotalUCInstallment2([FromUri]string id = null, [FromUri]string dcode = null)

        {
            List<Project_Fund_Release> lst = new List<Project_Fund_Release>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                var result = (from p in ent.Project_Fund_Release
                              where (p.ProjectCode).ToString() == id.ToString() && (p.Installment == dcode)
                              join q in ent.Project_UC_Submission on p.ProjectCode equals q.ProjectCode
                              into edept
                              from f in edept.DefaultIfEmpty()
                              where (f.ProjectCode).ToString() == id.ToString() && (f.Installment == dcode)
                              group new { p, f } by p into empg
                              select new
                              {

                                  ProjectCode = empg.Key.ProjectCode,
                                  UCAmount = empg.Sum(x => x.f.UCAmount)
                              }).ToList();

                return Request.CreateResponse(HttpStatusCode.OK, result);

            }
        }

        [HttpGet]
        [Route("TotalReleaseInstallment2")]
        //get api for total sum of installment 2 release
        public HttpResponseMessage TotalReleaseInstallment2([FromUri]string id = null, [FromUri]string dcode = null)

        {
            List<Project_Fund_Release> lst = new List<Project_Fund_Release>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                var result = (from f in ent.Project_Fund_Release

                              where (f.ProjectCode).ToString() == id.ToString() && (f.Installment == dcode)
                              group new { f } by f into empg
                              select new
                              {

                                  ProjectCode = empg.Key.ProjectCode,
                                  CummalativeRelease = empg.Sum(x => x.f.HFAAmount + x.f.TSPAmount + x.f.SCSPAmount),


                              }).ToList();

                return Request.CreateResponse(HttpStatusCode.OK, result.Sum(x => x.CummalativeRelease));

            }
        }

        [HttpGet]
        [Route("TotalUCInstallment3")]
        //get api for total sum of installment 3 uc 
        public HttpResponseMessage TotalUCInstallment3([FromUri]string id = null, [FromUri]string dcode = null)

        {
            List<Project_Fund_Release> lst = new List<Project_Fund_Release>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                var result = (from p in ent.Project_Fund_Release
                              where (p.ProjectCode).ToString() == id.ToString() && (p.Installment == dcode)
                              join q in ent.Project_UC_Submission on p.ProjectCode equals q.ProjectCode
                              into edept
                              from f in edept.DefaultIfEmpty()
                              where (f.ProjectCode).ToString() == id.ToString() && (f.Installment == dcode)
                              group new { p, f } by p into empg
                              select new
                              {

                                  ProjectCode = empg.Key.ProjectCode,
                                  UCAmount = empg.Sum(x => x.f.UCAmount)
                              }).ToList();

                return Request.CreateResponse(HttpStatusCode.OK, result);

            }
        }

        [HttpGet]
        [Route("TotalReleaseInstallment3")]
        //get api for total sum of installment 3 release
        public HttpResponseMessage TotalReleaseInstallment3([FromUri]string id = null, [FromUri]string dcode = null)

        {
            List<Project_Fund_Release> lst = new List<Project_Fund_Release>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                var result = (from f in ent.Project_Fund_Release

                              where (f.ProjectCode).ToString() == id.ToString() && (f.Installment == dcode)
                              group new { f } by f into empg
                              select new
                              {

                                  ProjectCode = empg.Key.ProjectCode,
                                  CummalativeRelease = empg.Sum(x => x.f.HFAAmount + x.f.TSPAmount + x.f.SCSPAmount),


                              }).ToList();

                return Request.CreateResponse(HttpStatusCode.OK, result.Sum(x => x.CummalativeRelease));

            }
        }
        [HttpPost]
        [Route("postReleasedOrder")]
        //post api for release order
        public HttpResponseMessage postReleasedOrder()
        {
            string fileName = null;
            var httpRequest = HttpContext.Current.Request;
            var postedFile = httpRequest.Files["Image"];
            fileName = new string(Path.GetFileNameWithoutExtension(postedFile.FileName).ToArray());
            fileName = fileName + Path.GetExtension(postedFile.FileName);
            var filePath = HttpContext.Current.Server.MapPath("~/File/" + fileName);
            postedFile.SaveAs(filePath);



            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Project_Release_Order release = new Project_Release_Order()
                {

                    Scheme = httpRequest["Scheme"],
                    Component = httpRequest["Component"],
                    SanctionNo = httpRequest["Sanction"],
                    State = httpRequest["state"],
                    AmountReleased = Convert.ToDouble(httpRequest["amount"]),
                    Date = Convert.ToDateTime(httpRequest["date"]),
                    ReleasePDF = fileName,
                };
                ent.Project_Release_Order.Add(release);
                ent.SaveChanges();
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("GetReleasedOrder")]
        //get api for release order
        public HttpResponseMessage GetReleasedOrder([FromUri]string id = null)
        {

            List<Project_Release_Order> lst = new List<Project_Release_Order>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                var result = (from p in ent.Project_Release_Order
                              join o in ent.State_Master on p.State equals o.Codes


                              select new
                              {
                                  o.States,
                                  p.Scheme,
                                  p.State,
                                  p.SanctionNo,
                                  p.ReleasePDF,
                                  p.ReleaseOrderID,
                                  p.AmountReleased,
                                  p.Date,
                                  p.Component



                              });
                //    List<Project_Release_Order> lst = new List<Project_Release_Order>();
                //  using (Entities ent = new Entities())
                //    {

                //    lst = ent.Project_Release_Order.AsEnumerable<Project_Release_Order>().ToList();


                //   }
                //   return lst;
                var result1 = result.Where(x => (x.State == id)).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, result1);
            }

        }
        [HttpGet]
        [Route("GetFile")]
        //download file api
        public HttpResponseMessage GetFile(string id)
        {

            //Create HTTP Response.
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);

            //Set the File Path.
            string filePath = HttpContext.Current.Server.MapPath("~/File/") + id + ".pdf";

            //Check whether File exists.
            if (!File.Exists(filePath))
            {
                //Throw 404 (Not Found) exception if File not found.
                response.StatusCode = HttpStatusCode.NotFound;
                response.ReasonPhrase = string.Format("File not found: {0} .", id);
                throw new HttpResponseException(response);
            }

            //Read the File into a Byte Array.
            byte[] bytes = File.ReadAllBytes(filePath);

            //Set the Response Content.
            response.Content = new ByteArrayContent(bytes);

            //Set the Response Content Length.
            response.Content.Headers.ContentLength = bytes.LongLength;

            //Set the Content Disposition Header Value and FileName.
            response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
            response.Content.Headers.ContentDisposition.FileName = id + ".pdf";

            //Set the File Content Type.
            response.Content.Headers.ContentType = new MediaTypeHeaderValue(MimeMapping.GetMimeMapping(id + ".pdf"));
            return response;
        }

        [HttpGet]
        [Route("GetUCOrder")]
        //get api for release fund flow 
        public HttpResponseMessage GetUCOrder([FromUri]string id = null)
        {

            List<Project_Release_Order> lst = new List<Project_Release_Order>();

            using (EmployeeEntities ent = new EmployeeEntities())
            {

                var result = (from p in ent.Project_Release_Order
                              join o in ent.State_Master on p.State equals o.Codes

                              join q in ent.Project_UC_Order on p.SanctionNo equals q.SanctionNo
                             into edept
                              from g in edept.DefaultIfEmpty()

                              select new
                              {

                                  o.States,
                                  p.State,
                                  p.SanctionNo,
                                  p.Date,
                                  p.AmountReleased,
                                  UtilizationNo = (g.UtilizationNo.ToString() == null) ? "" : g.UtilizationNo.ToString(),
                                  UCPDF = (g.UCPDF.ToString() == null) ? "" : g.UCPDF.ToString(),
                                  UCDate = (g.UCDate.ToString() == null) ? "" : g.UCDate.ToString(),
                                  UCAmount = (g.UCAmount.ToString() == null) ? "" : g.UCAmount.ToString()

                              });

                var result1 = result.Where(x => (x.State == id)).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, result1);


            }

        }

        [HttpPost]
        [Route("postUCOrder")]
        //post api for release order
        public HttpResponseMessage postUCOrder()
        {
            string fileName = null;
            var httpRequest = HttpContext.Current.Request;
            var postedFile = httpRequest.Files["Image"];
            fileName = new string(Path.GetFileNameWithoutExtension(postedFile.FileName).ToArray());
            fileName = fileName + Path.GetExtension(postedFile.FileName);
            var filePath = HttpContext.Current.Server.MapPath("~/File/" + fileName);
            postedFile.SaveAs(filePath);



            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Project_UC_Order release = new Project_UC_Order()
                {


                    UtilizationNo = httpRequest["UtilizationNo"],
                    SanctionNo = httpRequest["Sanction"],
                    State = httpRequest["state"],
                    UCAmount = Convert.ToDouble(httpRequest["UCAmount"]),
                    UCDate = Convert.ToDateTime(httpRequest["UCDate"]),
                    UCPDF = fileName,
                };
                ent.Project_UC_Order.Add(release);
                ent.SaveChanges();
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("GetProjectName")]
        // get projectname on behalf of projecttitle
        public List<Projct_Details> GetProjectName([FromUri]string id = null, [FromUri]string dcode = null, [FromUri]string ccode = null, [FromUri]string scheme = null, [FromUri] string component = null)
        {
            List<Projct_Details> lst = new List<Projct_Details>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.Projct_Details.Where(x => (x.StateCode == id && x.DistrictCode == dcode && x.CityCode == ccode && x.Scheme == scheme && x.SchemeComponent == component)).ToList();
            }
            return lst;
        }

        [HttpPost]
        //[Route("postProjectBriefDetail")]
        ////post api for project brief detail
        //public HttpResponseMessage postProjectBriefDetail()
        //{
        //    string fileName = null;
        //    var httpRequest = HttpContext.Current.Request;
        //    var postedFile = httpRequest.Files["Image"];
        //    fileName = new string(Path.GetFileNameWithoutExtension(postedFile.FileName).ToArray());
        //    fileName = fileName + Path.GetExtension(postedFile.FileName);
        //    var filePath = HttpContext.Current.Server.MapPath("~/File/" + fileName);
        //    postedFile.SaveAs(filePath);
        //    var token = httpRequest.Form.GetValues("Data")[0];
        //    string sParams = JsonConvert.SerializeObject(token);
        //    var jsonResult = JsonConvert.DeserializeObject(sParams).ToString();
        //    var ddd = jsonResult.Replace(@"\", string.Empty);
        //    JavaScriptSerializer objJavascript = new JavaScriptSerializer();
        //    Project_Brief_Detail list = JsonConvert.DeserializeObject<Project_Brief_Detail>(ddd);
        //    var obj = objJavascript.Deserialize<Project_Brief_Detail>(ddd);
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        List<Project_Code_Slum> slum = new List<Project_Code_Slum>();
        //        if (obj.Slum[0].ProjectCode == "")
        //        {

        //        }
        //        else
        //        {
        //            foreach (Project_Code_Slum slums in obj.Slum)
        //            {
        //                ent.Project_Code_Slum.Add(slums);
        //                ent.SaveChanges();
        //            }
        //        }
        //        Project_Brief_Detail detail = new Project_Brief_Detail();
        //        detail.CityCode = obj.CityCode;
        //        detail.Codes = obj.Codes;
        //        detail.Component = obj.Component;
        //        detail.Dcode = obj.Dcode;
        //        detail.Female = obj.Female;
        //        detail.General = obj.General;
        //        detail.HousingCost = obj.HousingCost;
        //        detail.ImplementingAgency = obj.ImplementingAgency;
        //        detail.InfaCost = obj.InfaCost;
        //        detail.Joint = obj.Joint;
        //        detail.Male = obj.Male;
        //        detail.Minority = obj.Minority;
        //        detail.NodalAgency = obj.NodalAgency;
        //        detail.OBC = obj.OBC;
        //        detail.OtherCost = obj.OtherCost;
        //        detail.OtherEWS = obj.OtherEWS;
        //        detail.PDF = obj.PDF;
        //        detail.ProjectCode = obj.ProjectCode;
        //        detail.SC = obj.SC;
        //        detail.Scheme = obj.Scheme;
        //        detail.SLSMCDate = obj.SLSMCDate;
        //        detail.ST = obj.ST;
        //        detail.Transgender = obj.Transgender;
        //        detail.WhetherSlum = obj.WhetherSlum;
        //        detail.TotalHouses = obj.TotalHouses;
        //        ent.Project_Brief_Detail.Add(detail);
        //        ent.SaveChanges();
        //    };
        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}

        [HttpGet]
        [Route("GetProjectBriefDetail")]
        //get api for get project brief detail
        public HttpResponseMessage GetProjectBriefDetail()
        {
            List<Project_Brief_Detail> lst = new List<Project_Brief_Detail>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                var result = (from p in ent.Project_Brief_Detail
                              join o in ent.State_Master on p.Codes equals o.Codes
                              join m in ent.Distt_Master on p.Dcode equals m.Dcode
                              join n in ent.City_Master on p.CityCode equals n.CityCode
                              join q in ent.Project_Code_Slum on p.ProjectCode equals q.ProjectCode
                             into edept
                              from g in edept.DefaultIfEmpty()
                              select new
                              {
                                  o.States,
                                  m.District,
                                  n.City,
                                  o.Codes,
                                  m.Dcode,
                                  n.CityCode,
                                  p.ProjectId,
                                  p.ProjectCode,
                                  p.Component,
                                  p.Female,
                                  p.TotalHouses,
                                  p.General,
                                  p.HousingCost,
                                  p.ImplementingAgency,
                                  p.InfaCost,
                                  p.Joint,
                                  p.Male,
                                  p.Minority,
                                  p.NodalAgency,
                                  p.OBC
                                  ,
                                  p.OtherCost,
                                  p.OtherEWS,
                                  p.PDF,
                                  p.SC,
                                  p.Scheme,
                                  p.SLSMCDate,
                                  p.Transgender,
                                  p.WhetherSlum,
                                  p.ST,
                                  SlumName = g.SlumName,
                                  SlumCOvered = g.SlumCovered
                              });

                return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
            }

        }
        // Bulk Insert Project Details
        public HttpResponseMessage ExcelUploadProjectDetailData()
        {
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities ent = new EmployeeEntities();
                HttpPostedFile file = httpRequest.Files[0];
                Stream strem = file.InputStream;
                IExcelDataReader reader = null;
                if (file.FileName.EndsWith(".xls"))
                {
                    reader = ExcelReaderFactory.CreateBinaryReader(strem);
                }
                else if (file.FileName.EndsWith(".xlsx"))
                {
                    reader = ExcelReaderFactory.CreateOpenXmlReader(strem);
                }
                else
                {
                }
                DataSet result = reader.AsDataSet();
                reader.Close();

                var value = result.Tables[0];
                List<Projct_Details> lst = new List<Projct_Details>();
                for (int i = 1; i < value.Rows.Count; i++)
                {
                    Projct_Details obj = new Projct_Details();
                    if (value.Rows[i][0].ToString() == "" || value.Rows[i][4].ToString() == "-")
                    {
                        obj.StateCode = value.Rows[i][1].ToString();
                        obj.DistrictCode = value.Rows[i][2].ToString();
                        obj.CityCode = value.Rows[i][3].ToString();
                        obj.Scheme = value.Rows[i][6].ToString();
                        obj.SchemeComponent = value.Rows[i][7].ToString();
                        obj.ProjectCode = obj.StateCode + obj.DistrictCode + obj.CityCode + obj.Scheme.Substring(0, 1) + obj.SchemeComponent.Substring(0, 1) + 'P';

                    }
                    else
                    {
                        obj.ProjectCode = value.Rows[i][0].ToString();
                    }
                    obj.StateCode = value.Rows[i][1].ToString();
                    obj.DistrictCode = value.Rows[i][2].ToString();
                    obj.CityCode = value.Rows[i][3].ToString();
                    if (value.Rows[i][4].ToString() == "" || value.Rows[i][4].ToString() == "-")
                    {
                        obj.CSMCDate = null;
                    }
                    else
                    {
                        obj.CSMCDate = Convert.ToDateTime(value.Rows[i][4].ToString());
                    }

                    if (value.Rows[i][5].ToString() == "" || value.Rows[i][5].ToString() == "-")
                    {
                        obj.CSMCNumber = null;
                    }
                    else
                    {
                        obj.CSMCNumber = value.Rows[i][5].ToString();
                    }
                    if (value.Rows[i][6].ToString() == "" || value.Rows[i][6].ToString() == "-")
                    {
                        obj.Scheme = null;
                    }
                    else
                    {
                        obj.Scheme = value.Rows[i][6].ToString();
                    }
                    if (value.Rows[i][7].ToString() == "" || value.Rows[i][7].ToString() == "-")
                    {
                        obj.SchemeComponent = null;
                    }
                    else
                    {
                        obj.SchemeComponent = value.Rows[i][7].ToString();
                    }

                    if (value.Rows[i][8].ToString() == "" || value.Rows[i][8].ToString() == "-")
                    {
                        obj.ProjectAgencies = null;
                    }
                    else
                    {
                        obj.ProjectAgencies = value.Rows[i][8].ToString();
                    }
                    if (value.Rows[i][9].ToString() == "" || value.Rows[i][9].ToString() == "-")
                    {
                        obj.ProjectStatus = null;
                    }
                    else
                    {
                        obj.ProjectStatus = value.Rows[i][9].ToString();
                    }

                    if (value.Rows[i][10].ToString() == "" || value.Rows[i][10].ToString() == "-")
                    {
                        obj.ProjectDuration = null;
                    }
                    else
                    {
                        obj.ProjectDuration = value.Rows[i][10].ToString();
                    }
                    if (value.Rows[i][11].ToString() == "" || value.Rows[i][11].ToString() == "-")
                    {
                        obj.ProjectTitle = null;
                    }
                    else
                    {
                        obj.ProjectTitle = value.Rows[i][11].ToString();
                    }

                    if (value.Rows[i][12].ToString() == "" || value.Rows[i][12].ToString() == "-")
                    {
                        obj.ProjectCost = 0;
                    }
                    else
                    {
                        obj.ProjectCost = Convert.ToDecimal(value.Rows[i][12].ToString());
                    }

                    if (value.Rows[i][13].ToString() == "" || value.Rows[i][13].ToString() == "-")
                    {
                        obj.CentralAssistance = 0;
                    }
                    else
                    {
                        obj.CentralAssistance = Convert.ToDecimal(value.Rows[i][13].ToString());
                    }
                    if (value.Rows[i][14].ToString() == "" || value.Rows[i][14].ToString() == "-")
                    {
                        obj.StateGrant = null;
                    }
                    else
                    {
                        obj.StateGrant = value.Rows[i][14].ToString();
                    }
                    if (value.Rows[i][15].ToString() == "" || value.Rows[i][15].ToString() == "-")
                    {
                        obj.ULB = null;
                    }
                    else
                    {
                        obj.ULB = value.Rows[i][15].ToString();
                    }
                    if (value.Rows[i][16].ToString() == "" || value.Rows[i][16].ToString() == "-")
                    {
                        obj.BeneficiaryShare = null;
                    }
                    else
                    {
                        obj.BeneficiaryShare = value.Rows[i][16].ToString();
                    }
                    if (value.Rows[i][17].ToString() == "" || value.Rows[i][17].ToString() == "-")
                    {
                        obj.OtherCost = null;
                    }
                    else
                    {
                        obj.OtherCost = value.Rows[i][17].ToString();
                    }
                    if (value.Rows[i][18].ToString() == "" || value.Rows[i][18].ToString() == "-")
                    {
                        obj.NewSanction = null;
                    }
                    else
                    {
                        obj.NewSanction = value.Rows[i][18].ToString();
                    }
                    if (value.Rows[i][19].ToString() == "" || value.Rows[i][19].ToString() == "-")
                    {
                        obj.UpgradeSanction = null;
                    }
                    else
                    {
                        obj.UpgradeSanction = value.Rows[i][19].ToString();
                    }
                    if (value.Rows[i][20].ToString() == "" || value.Rows[i][20].ToString() == "-")
                    {
                        obj.TotalSanction = 0;
                    }
                    else
                    {
                        obj.TotalSanction = Convert.ToDecimal(value.Rows[i][20].ToString());
                    }
                    if (value.Rows[i][21].ToString() == "" || value.Rows[i][21].ToString() == "-")
                    {
                        obj.FirstInstallment = null;
                    }
                    else
                    {
                        obj.FirstInstallment = value.Rows[i][21].ToString();
                    }
                    if (value.Rows[i][22].ToString() == "" || value.Rows[i][22].ToString() == "-")
                    {
                        obj.ActiveFlag = null;
                    }
                    else
                    {
                        obj.ActiveFlag = value.Rows[i][22].ToString();
                    }
                    if (value.Rows[i][23].ToString() == "" || value.Rows[i][23].ToString() == "-")
                    {
                        obj.CreatedBy = null;
                    }
                    else
                    {
                        obj.CreatedBy = value.Rows[i][23].ToString();
                    }
                    if (value.Rows[i][24].ToString() == "" || value.Rows[i][24].ToString() == "-")
                    {
                        obj.CreatedOn = null;
                    }
                    else
                    {
                        obj.CreatedOn = Convert.ToDateTime(value.Rows[i][24].ToString());
                    }
                    lst.Add(obj);
                    ent.Projct_Details.Add(obj);
                }
                ent.SaveChanges();
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("SubmitClassificationMaster")]
        //post api for classification master
        public HttpResponseMessage SubmitClassificationMaster(Classification_Master obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                if (ent.Classification_Master.Any(ac => ac.Description.Equals(obj.Description)))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                else
                {
                    ent.Classification_Master.Add(obj);
                    ent.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
        }
        [HttpGet]
        [Route("GetClassificationMaster")]
        //get api for classification master
        public List<Classification_Master> GetClassificationMaster()
        {
            List<Classification_Master> lst = new List<Classification_Master>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.Classification_Master.AsEnumerable<Classification_Master>().OrderBy(x => x.Description).ToList();

            }
            return lst;
        }

        //[HttpGet]
        //[Route("DeleteClassificationMaster")]
        ////delete api for classification master
        //public HttpResponseMessage DeleteClassificationMaster(int id)
        //{
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        Classification_Master record = ent.Classification_Master.Where(x => x.ClassificationId == id).FirstOrDefault<Classification_Master>();
        //        ent.Classification_Master.Remove(record);
        //        ent.SaveChanges();
        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }
        //}

        [HttpGet]
        [Route("DeleteClassificationMaster/{id}")]
        //delete api for classification master
        public HttpResponseMessage DeleteClassificationMaster(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Classification_Master record = ent.Classification_Master.Where(x => x.ClassificationId == id).FirstOrDefault<Classification_Master>();
                ent.Classification_Master.Remove(record);
                ent.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }
        [HttpPost]
        [Route("UpdateClassificationMaster")]
        //update api for classification master
        public HttpResponseMessage UpdateClassificationMaster(Classification_Master value)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Classification_Master record = ent.Classification_Master.Where(x => x.ClassificationId == value.ClassificationId).FirstOrDefault<Classification_Master>();
                record.Description = value.Description;
                record.DescriptionCode = value.DescriptionCode;
                record.Applicable = value.Applicable;
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }
        //[HttpGet]
        //[Route("getProject")]
        //// get projectname on behalf of state district city
        //public List<Projct_Details> getProject([FromUri]string id = null, [FromUri]string dcode = null, [FromUri]string ccode = null)
        //{
        //    List<Projct_Details> lst = new List<Projct_Details>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        lst = ent.Projct_Details.Where(x => (x.StateCode == id && x.DistrictCode == dcode && x.CityCode == ccode)).ToList();
        //    }
        //    return lst;
        //}

        [HttpGet]
        [Route("getProject/{id}/{dcode}/{ccode}")]
        // get projectname on behalf of state district city
        public List<Projct_Details> getProject([FromUri]string id = null, [FromUri]string dcode = null, [FromUri]string ccode = null)
        {
            List<Projct_Details> lst = new List<Projct_Details>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.Projct_Details.Where(x => (x.StateCode == id && x.DistrictCode == dcode && x.CityCode == ccode)).ToList();
            }
            return lst;
        }

        //[HttpGet]
        //[Route("getStateClassification")]
        //// get classification on behalf of state
        //public List<Classification_Master> getStateClassification([FromUri]string id = null)
        //{
        //    List<Classification_Master> lst = new List<Classification_Master>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        lst = ent.Classification_Master.Where(x => (x.Applicable == id)).ToList();


        //    }
        //    return lst;
        //}

        [HttpGet]
        [Route("getStateClassification/{id}")]
        // get classification on behalf of state
        public List<Classification_Master> getStateClassification([FromUri]string id = null)
        {
            List<Classification_Master> lst = new List<Classification_Master>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                lst = ent.Classification_Master.Where(x => (x.Applicable == id)).ToList();


            }
            return lst;
        }
        [HttpPost]

        [Route("SubmitStateClassificationMapping")]
        //post api for state mapping classification master
        public HttpResponseMessage SubmitStateClassificationMapping(Classification_State_Mapping obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {

                {
                    ent.Classification_State_Mapping.Add(obj);
                    ent.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
        }
        [HttpGet]
        [Route("GetStateClassificationMapping")]
        //get api for state classification mapping
        public HttpResponseMessage GetStateClassificationMapping()
        {
            List<Classification_State_Mapping> lst = new List<Classification_State_Mapping>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                var result = (from p in ent.Classification_State_Mapping
                              join o in ent.State_Master on p.StateCode equals o.Codes

                              join e in ent.Classification_Master on p.DescriptionCode equals e.DescriptionCode
                              group new { p, o, e } by o into empg

                              orderby empg.Max(x => x.o.States)
                              select new
                              {
                                  Codes = empg.Key.Codes,
                                  States = empg.Key.States,

                                  Mapping = empg.Select(x => new { x.e, x.p.StateMappingId, x.p.selected })


                              }).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, result.Distinct());

            }

        }
        [HttpGet]
        [Route("DeleteStateClassificationMapping")]
        //delete api for state classification mapping
        public HttpResponseMessage DeleteStateClassificationMapping(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Classification_State_Mapping record = ent.Classification_State_Mapping.Where(x => x.StateMappingId == id).FirstOrDefault<Classification_State_Mapping>();
                ent.Classification_State_Mapping.Remove(record);
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }
        [HttpPost]
        [Route("SubmitDistrictClassificationMapping")]
        //post api for district mapping classification master
        public HttpResponseMessage SubmitDistrictClassificationMapping(Classification_District_Mapping obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {

                {
                    ent.Classification_District_Mapping.Add(obj);
                    ent.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
        }
        //[HttpGet]
        //[Route("GetDistrictClassificationMapping")]
        ////get api for district classification mapping
        //public HttpResponseMessage GetDistrictClassificationMapping([FromUri]string id = null)
        //{
        //    List<Classification_District_Mapping> lst = new List<Classification_District_Mapping>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        var result = (from p in ent.Classification_District_Mapping
        //                      where p.StateCode == id
        //                      join o in ent.State_Master on p.StateCode equals o.Codes
        //                      join r in ent.Distt_Master on p.DistrictCode equals r.Dcode
        //                      join e in ent.Classification_Master on p.DescriptionCode equals e.DescriptionCode
        //                      group new { p, o, e, r } by r
        //                        into empg
        //                      orderby empg.Max(x => x.r.District)
        //                      select new
        //                      {
        //                          DCodes = empg.Key.Dcode,
        //                          District = empg.Key.District,
        //                          State = empg.Select(x => x.o.States),
        //                          StateCode = empg.Select(x => x.o.Codes),
        //                          Mapping = empg.Select(x => new { x.e, x.p.Selected, x.p.DistrictClassId })

        //                      }).ToList();
        //        return Request.CreateResponse(HttpStatusCode.OK, result.Distinct());

        //    }

        //}

        [HttpGet]
        [Route("GetDistrictClassificationMapping/{id}")]
        //get api for district classification mapping
        public HttpResponseMessage GetDistrictClassificationMapping([FromUri]string id = null)
        {
            List<Classification_District_Mapping> lst = new List<Classification_District_Mapping>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                var result = (from p in ent.Classification_District_Mapping
                              where p.StateCode == id
                              join o in ent.State_Master on p.StateCode equals o.Codes
                              join r in ent.Distt_Master on p.DistrictCode equals r.Dcode
                              join e in ent.Classification_Master on p.DescriptionCode equals e.DescriptionCode
                              group new { p, o, e, r } by r
                                into empg
                              orderby empg.Max(x => x.r.District)
                              select new
                              {
                                  DCodes = empg.Key.Dcode,
                                  District = empg.Key.District,
                                  States_UT = empg.Select(x => x.o.States_UT),
                                  StateCode = empg.Select(x => x.o.Codes),
                                  Mapping = empg.Select(x => new { x.e, x.p.Selected, x.p.DistrictClassId })

                              }).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, result.Distinct());

            }

        }
        [HttpGet]
        [Route("DeleteDistrictClassificationMapping")]
        //delete api for district classification mapping
        public HttpResponseMessage DeleteDistrictClassificationMapping(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Classification_District_Mapping record = ent.Classification_District_Mapping.Where(x => x.DistrictClassId == id).FirstOrDefault<Classification_District_Mapping>();
                ent.Classification_District_Mapping.Remove(record);
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }
        [HttpPost]
        [Route("SubmitCityClassificationMapping")]
        //post api for city mapping classification master
        public HttpResponseMessage SubmitCityClassificationMapping(Classification_City_Mapping obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {

                {
                    ent.Classification_City_Mapping.Add(obj);
                    ent.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
        }
        //[HttpGet]
        //[Route("GetCityClassificationMapping")]
        ////get api for city classification mapping
        //public HttpResponseMessage GetCityClassificationMapping([FromUri]string id = null, [FromUri]string dcode = null)
        //{
        //    List<Classification_City_Mapping> lst = new List<Classification_City_Mapping>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        var result = (from p in ent.Classification_City_Mapping
        //                      where p.StateCode == id && p.DistrictCode == dcode
        //                      join s in ent.City_Master on p.CityCode equals s.CityCode
        //                      join e in ent.Classification_Master on p.DescriptionCode equals e.DescriptionCode
        //                      group new { p, e, s } by s
        //                        into empg
        //                      orderby empg.Max(x => x.s.City)
        //                      select new
        //                      {
        //                          CCodes = empg.Key.CityCode,
        //                          City = empg.Key.City,
        //                          Mapping = empg.Select(x => new { x.e, x.p.Selected, x.p.CityClassId })
        //                      }).ToList();
        //        return Request.CreateResponse(HttpStatusCode.OK, result.Distinct());

        //    }

        //}
        [HttpGet]
        [Route("GetCityClassificationMapping/{id}/{dcode}")]
        //get api for city classification mapping
        public HttpResponseMessage GetCityClassificationMapping([FromUri]string id = null, [FromUri]string dcode = null)
        {
            List<Classification_City_Mapping> lst = new List<Classification_City_Mapping>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                var result = (from p in ent.Classification_City_Mapping
                              where p.StateCode == id && p.DistrictCode == dcode
                              join s in ent.City_Master on p.CityCode equals s.CityCode
                              join e in ent.Classification_Master on p.DescriptionCode equals e.DescriptionCode
                              group new { p, e, s } by s
                                into empg
                              orderby empg.Max(x => x.s.City)
                              select new
                              {
                                  CCodes = empg.Key.CityCode,
                                  City = empg.Key.City,
                                  Mapping = empg.Select(x => new { x.e, x.p.Selected, x.p.CityClassId })
                              }).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, result.Distinct());
            }
        }

        [HttpGet]
        [Route("DeleteCityClassificationMapping")]
        //delete api for city classification mapping
        public HttpResponseMessage DeleteCityClassificationMapping(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Classification_City_Mapping record = ent.Classification_City_Mapping.Where(x => x.CityClassId == id).FirstOrDefault<Classification_City_Mapping>();
                ent.Classification_City_Mapping.Remove(record);
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }
        [HttpPost]
        [Route("SubmitProjectClassificationMapping")]
        //post api for project mapping classification master
        public HttpResponseMessage SubmitProjectClassificationMapping(Classification_Project_Mapping obj)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {

                {
                    ent.Classification_Project_Mapping.Add(obj);
                    ent.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
        }
        //[HttpGet]
        //[Route("GetProjectClassificationMapping")]
        ////get api for project classification mapping
        //public HttpResponseMessage GetProjectClassificationMapping([FromUri]string id = null, [FromUri]string dcode = null, [FromUri]string ccode = null)
        //{
        //    List<Classification_Project_Mapping> lst = new List<Classification_Project_Mapping>();
        //    using (EmployeeEntities ent = new EmployeeEntities())
        //    {
        //        var result = (from p in ent.Classification_Project_Mapping
        //                      where p.StateCode == id && p.DistrictCode == dcode && p.CityCode == ccode
        //                      join s in ent.City_Master on p.CityCode equals s.CityCode
        //                      join e in ent.Classification_Master on p.DescriptionCode equals e.DescriptionCode
        //                      join f in ent.Projct_Details on p.ProjectCode equals f.ProjectCode
        //                      group new { p, e, s, f } by f
        //                        into empg
        //                      orderby empg.Max(x => x.s.City)
        //                      select new
        //                      {
        //                          ProjectCode = empg.Key.ProjectCode,
        //                          ProjectTitle = empg.Key.ProjectTitle,
        //                          Mapping = empg.Select(x => new { x.e, x.p.Selected, x.p.ProjectClassId })
        //                      }).ToList();
        //        return Request.CreateResponse(HttpStatusCode.OK, result.Distinct());

        //    }

        //}
        [HttpGet]
        [Route("GetProjectClassificationMapping/{id}/{dcode}/{ccode}")]
        //get api for project classification mapping
        public HttpResponseMessage GetProjectClassificationMapping([FromUri]string id = null, [FromUri]string dcode = null, [FromUri]string ccode = null)
        {
            List<Classification_Project_Mapping> lst = new List<Classification_Project_Mapping>();
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                var result = (from p in ent.Classification_Project_Mapping
                              where p.StateCode == id && p.DistrictCode == dcode && p.CityCode == ccode
                              join s in ent.City_Master on p.CityCode equals s.CityCode
                              join e in ent.Classification_Master on p.DescriptionCode equals e.DescriptionCode
                              join f in ent.Projct_Details on p.ProjectCode equals f.ProjectCode
                              group new { p, e, s, f } by f
                                into empg
                              orderby empg.Max(x => x.s.City)
                              select new
                              {
                                  ProjectCode = empg.Key.ProjectCode,
                                  ProjectTitle = empg.Key.ProjectTitle,
                                  Mapping = empg.Select(x => new { x.e, x.p.Selected, x.p.ProjectClassId })
                              }).ToList();
                return Request.CreateResponse(HttpStatusCode.OK, result.Distinct());

            }

        }
        [HttpGet]
        [Route("DeleteProjectClassificationMapping")]
        //delete api for project classification mapping
        public HttpResponseMessage DeleteProjectClassificationMapping(int id)
        {
            using (EmployeeEntities ent = new EmployeeEntities())
            {
                Classification_Project_Mapping record = ent.Classification_Project_Mapping.Where(x => x.ProjectClassId == id).FirstOrDefault<Classification_Project_Mapping>();
                ent.Classification_Project_Mapping.Remove(record);
                ent.SaveChanges();
            }
            var message = Request.CreateResponse(HttpStatusCode.OK);
            return message;
        }


    }
}

