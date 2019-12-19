using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WeeklyReportAPI.Models;
using WeeklyReportAPI.ViewModel;

namespace WeeklyReportAPI.Controllers
{
    [RoutePrefix("Api/Buldings")]
    public class WeeklyReportController : ApiController
    {
        //[Route("WeeklyReport")]
        //public List<Building> BindBuilding()
        //{
        //    List<Building> lstBulding = new List<Building>();
        //    EmployeeEntities objEntity = new EmployeeEntities();

        //    lstBulding = objEntity.Buildings.ToList();
        //    return lstBulding;

        //}

        [HttpGet]
        [Route("WeeklyReports")]
        public sp_Cons_Values_Result BindBuilding()
        {
            //PMAY_PROJECTS Copy$
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            sp_Cons_Values_Result lstBulding = objEntity.sp_Cons_Values().FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("WeeklyReportsParray")]
        public sp_Cons_Values_Param_Result BindBuilding1(string stateCode)
        {
            //PMAY_PROJECTS Copy$
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            sp_Cons_Values_Param_Result lstBulding = objEntity.sp_Cons_Values_Param(stateCode).FirstOrDefault();

            //List<Pychart> lstPychart = new List<Pychart>();
            //lstPychart.Add(new Pychart { y = lstBulding.Sanctioned, label = "Sanctioned" });
            //lstPychart.Add(new Pychart { y = lstBulding.Houses_Grounded, label = "Grounded" });
            //lstPychart.Add(new Pychart { y = lstBulding.Houses_Completed, label = "Completed" });
            //lstPychart.Add(new Pychart { y = lstBulding.Houses_Occupied, label = "Occupied" });

            return lstBulding;
        }



        //[HttpGet]
        //[Route("WeeklyReportsPara")]
        //public sp_Cons_Values_Result BindBuildingPara(string id)
        //{
        //    //PMAY_PROJECTS Copy$
        //    List<ConsReportView> lst = new List<ConsReportView>();
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    sp_Cons_Values_Result lstBulding = objEntity.sp_Cons_Values(id).FirstOrDefault();
        //    return lstBulding;
        //}


        [HttpGet]
        [Route("JNNURM_Reports")]
        public sp_Cons_JNNURM_Values_Result BindBuildingJNNURM()
        {
            sp_Cons_JNNURM_Values_Result lstBulding = new sp_Cons_JNNURM_Values_Result();
            List<ConsReportView> lst = new List<ConsReportView>();
            using (EmployeeEntities objEntity = new EmployeeEntities())
            {
                lstBulding = objEntity.sp_Cons_JNNURM_Values().FirstOrDefault();
            }

            return lstBulding;
        }

        [HttpGet]
        [Route("JNNURM_ReportsParray")]
        public sp_Cons_JNNURM_Values_Param_Result BindBuildingJNNURMParray(string stateCode)
        {
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            sp_Cons_JNNURM_Values_Param_Result lstBulding = objEntity.sp_Cons_JNNURM_Values_Param(stateCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("JNNURM_Reports_SDC")]
        public sp_Cons_JNNURM_SDC_Result BindBuildingJNNURM_SDC(string stateCode, string dcode, string cityCode)
        {
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            sp_Cons_JNNURM_SDC_Result lstBulding = objEntity.sp_Cons_JNNURM_SDC(stateCode, dcode, cityCode).FirstOrDefault();
            return lstBulding;
        }

        //[HttpGet]
        //[Route("JNNURM_Reports")]
        //public sp_Cons_JNNURM_Values_Result BindBuildingJNNURM(/*string*/  id)
        //{
        //    List<ConsReportView> lst = new List<ConsReportView>();
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    sp_Cons_JNNURM_Values_Result lstBulding = objEntity.sp_Cons_JNNURM_Values(id).FirstOrDefault();
        //    return lstBulding;
        //}


        //ALTER proc sp_Cons_JNNURM_Values
        //as
        //select sum(Grounded) Grounded,sum(Completed1) Completed1,sum(Occupied1) Occupied1 from dbo.JnNURM_Copy$ 


        [HttpGet]
        [Route("ComponentData")]
        public List<proc_Component_Result> BindComponent()
        {
            List<proc_Component_Result> lst = new List<proc_Component_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lst = objEntity.proc_Component().ToList();
            return lst;
        }






        //[Route("WeeklyReport")]
        //public List<Building> BindBuilding()
        //{
        //    List<Building> lstBulding = new List<Building>();
        //    EmployeeEntities objEntity = new EmployeeEntities();

        //    lstBulding = objEntity.Buildings.ToList();
        //    return lstBulding;

        //}

        [HttpGet]
        [Route("ComponentDataPMay")]
        public proc_Component_Pmay_Result BindComponentPMay()
        {
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            proc_Component_Pmay_Result lstBulding = objEntity.proc_Component_Pmay().FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("ComponentDataPMayParray")]
        public proc_Component_PmayParam_Result BindComponentPMayParray(string stateCode)
        {
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            proc_Component_PmayParam_Result lstBulding = objEntity.proc_Component_PmayParam(stateCode).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("ComponentData_SDC")]
        public proc_Component_SDC_Result BindComponentPMayParray(string stateCode, string dcode, string cityCode)
        {
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            proc_Component_SDC_Result lstBulding = objEntity.proc_Component_SDC(stateCode, dcode, cityCode).FirstOrDefault();
            return lstBulding;
        }


        //alter Proc proc_Component
        //    as
        //    select[Component\] as [Component\] ,Round(SUM([Houses involved]),2)  AS Sanctioned  from[PMAY_PROJECTS Copy$]
        //    where[Component\] is not null  GROUP BY[Component\]

        [Route("StateDetails")]
        [HttpGet]
        public List<State_Master> BindState()
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<State_Master> objState = new List<State_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objState = objEntity.State_Master.OrderBy(a => a.States_UT).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objState.ToList();
        }

        [Route("GetStateName")]
        [HttpGet]
        public List<State_Master> GetStateName(string StateCode)
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<State_Master> objStateName = new List<State_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objStateName = objEntity.State_Master.OrderBy(a => StateCode).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objStateName.ToList();
        }


        [HttpGet]
        [Route("GetStateNameById")]
        public sp_GetStateName_Result GetStateNameById(string stateCodes)
        {
            List<sp_GetStateName_Result> lst = new List<sp_GetStateName_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            sp_GetStateName_Result lstBulding = objEntity.sp_GetStateName(stateCodes).FirstOrDefault();
            return lstBulding;
        }


        [HttpGet]
        [Route("GetDisttNameById")]
        public sp_GetDisttName_Result GetDisttNameById(string disttCode)
        {
            List<sp_GetDisttName_Result> lst = new List<sp_GetDisttName_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            sp_GetDisttName_Result lstBulding = objEntity.sp_GetDisttName(disttCode).FirstOrDefault();
            return lstBulding;
        }


        [HttpGet]
        [Route("GetCityNameById")]
        public sp_GetCityName_Result GetCityNameById(string cityCode)
        {
            List<sp_GetCityName_Result> lst = new List<sp_GetCityName_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            sp_GetCityName_Result lstBulding = objEntity.sp_GetCityName(cityCode).FirstOrDefault();
            return lstBulding;
        }
        //[HttpGet]
        //[Route("sp_GetStateName")]
        //public sp_GetStateName(string StateCode)
        //{
        //    IEnumerable<sp_GetStateName> objState = new List<sp_GetStateName>();

        //    EmployeeEntities objEntity = new EmployeeEntities();
        //      lstBulding = objEntity.sp_GetStateName(StateCode).FirstOrDefault();
        //    return lstBulding;
        //}

        //[Route("StateDetails")]
        //[HttpGet]
        //public List<State_Master> BindState()
        //{    //http://localhost:57855/Api/Builder/StateDetails
        //    IEnumerable<State_Master> objState = new List<State_Master>();
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    try
        //    {
        //        objState = objEntity.State_Master.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    return objState.ToList();
        //}
        [Route("DisttDetails")]
        [HttpGet]
        public List<Distt_Master> BindDistt(string DistCode)
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<Distt_Master> objDistt = new List<Distt_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objDistt = objEntity.Distt_Master.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objDistt.ToList();
        }
        [HttpGet]
        [Route("CLSS_Details")]
        public Proc_CLSS_Result BindCLSSDetail()
        {
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            Proc_CLSS_Result lstBulding = objEntity.Proc_CLSS().FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("CLSS_DetailsParam")]
        public Proc_CLSS_Param_Result BindCLSSDetailParam(string stateCode)
        {
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            Proc_CLSS_Param_Result lstBulding = objEntity.Proc_CLSS_Param(stateCode).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("CLSS_DetailsParamNew")]
        public PhysicalDetails CLSS_DetailsParamNew(string stateCode, string division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            PhysicalDetails lstBulding = objEntity.HFA_GetPD_ByStateDivision_e(stateCode, division).FirstOrDefault();
            return lstBulding;  //
        }

        //Create Proc Proc_CLSS
        // as
        // select Round(sum(No_Bene_EWS_LIG),2) No_Bene_EWS_LIG,
        // Round(sum(No_Beneficiary_MIG),2) No_Beneficiary_MIG, Round(SUM(NoBeneficiary_Total),2) NoBeneficiary_Total ,
        // Round(sum(Subsidy_EWS_LIG),2) Subsidy_EWS_LIG,
        // Round(sum(Subsidy_MIG),2) Subsidy_MIG ,Round(sum(Subsidy_Total),2) Subsidy_Total from dbo.CLSS_MASTER

        [HttpGet]
        [Route("Distt_Details_BasedonState")]
        public List<GetDisttDetails_Result> GetDisttDetailBasedonState(string stateCode)
        {
            List<GetDisttDetails_Result> lst = new List<GetDisttDetails_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lst = objEntity.GetDisttDetails(stateCode).ToList();
            return lst;
        }
        [HttpGet]
        [Route("Investment_Details")]
        public Investment_Details BindCInvestment_Detail()
        {
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            Investment_Details lstBulding = objEntity.Investment_Details.FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("Investments")]
        public List<Investment> BindCInvestment_Det()
        {
            List<Investment> lst = new List<Investment>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lst = objEntity.Investments.ToList();
            return lst;
        }

        [HttpGet]
        [Route("Investment_ConsDetails")]
        public Proc_Investment_Cons_Result BindCInvestmentCons_Detail()
        {
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            Proc_Investment_Cons_Result lstBulding = objEntity.Proc_Investment_Cons().FirstOrDefault();
            return lstBulding;
        }


        [HttpGet]
        [Route("Inv_Det_BasedOnState")]
        public Proc_Inv_Cons_StateWise_Result Inv_Det_BasedOnState(string stateCode)
        { // 1-3  TotalCost
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            Proc_Inv_Cons_StateWise_Result lstBulding = objEntity.Proc_Inv_Cons_StateWise(stateCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("GetStateWiseFinYrData")]
        public GetStateWiseFinYrData_Result GetStateWiseFinYrData(string stateCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            GetStateWiseFinYrData_Result lstBulding = objEntity.GetStateWiseFinYrData(stateCode).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("GetStateWiseFinYrDataNew")]
        public ConsStatesDet GetStateDivWiseResult(string stateCode, string division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            ConsStatesDet lstBulding = objEntity.HFA_GetByStateDivision_e(stateCode, division).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("GetStateWiseFinYrDataNew1")]
        public ConsStatesDet GetStateDivWiseResult1(string stateCode, string division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            ConsStatesDet lstBulding = objEntity.HFA_GetByStateDivision_e1(stateCode, division).FirstOrDefault();
            return lstBulding;
        }
        //--------------------------------------------------------
        [Route("HFA_StateDetails")]
        [HttpGet]
        public IEnumerable<HFA_GetStates_Result> BindStates()
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetStates_Result> objState = new List<HFA_GetStates_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objState = objEntity.HFA_GetStates().ToList();
            }
            catch (Exception )
            {
                throw;
            }
            return objState;
        }
        [Route("HFA_State_Details")]
        [HttpGet]
        public IEnumerable<HFA_GetStates_Result> Bind_States()
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetStates_Result> objState = new List<HFA_GetStates_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objState = objEntity.HFA_GetStates().Where(a => a.Division.Equals("HFA-1"));
            }
            catch (Exception ex)
            {
                throw;
            }
            return objState;
        }
        [Route("HFA_State_Details3")]
        [HttpGet]
        public IEnumerable<HFA_GetStates_Result> Bind_States3()
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetStates_Result> objState = new List<HFA_GetStates_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objState = objEntity.HFA_GetStates().Where(a => a.Division.Equals("HFA-3"));
            }
            catch (Exception ex)
            {
                throw;
            }
            return objState;
        }
        [Route("HFA_State_Details4")]
        [HttpGet]
        public IEnumerable<HFA_GetStates_Result> Bind_States4()
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetStates_Result> objState = new List<HFA_GetStates_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objState = objEntity.HFA_GetStates().Where(a => a.Division.Equals("HFA-4"));
            }
            catch (Exception ex)
            {
                throw;
            }
            return objState;
        }
        [Route("HFA_State_Details5")]
        [HttpGet]
        public IEnumerable<HFA_GetStates_Result> Bind_States5()
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetStates_Result> objState = new List<HFA_GetStates_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objState = objEntity.HFA_GetStates().Where(a => a.Division.Equals("HFA-5"));
            }
            catch (Exception ex)
            {
                throw;
            }
            return objState;
        }
        [Route("HFA_State_Details51")]
        [HttpGet]
        public IEnumerable<HFA_GetStates_Result> Bind_States51()
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetStates_Result> objState = new List<HFA_GetStates_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objState = objEntity.HFA_GetStates().Where(a => a.Division.Equals("HFA-5"));
            }
            catch (Exception ex)
            {
                throw;
            }
            return objState;
        }
        [Route("HFA_State_Details5/{hfa}")]
        [HttpGet]
        public IEnumerable<HFA_GetStates_Result> Bind_States5(string hfa)
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetStates_Result> objState = new List<HFA_GetStates_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objState = objEntity.HFA_GetStates().Where(a => a.Division.Equals(hfa));
            }
            catch (Exception ex)
            {
                throw;
            }
            return objState;
        }
        [Route("HFA_DesignationDetails")]
        [HttpGet]
        public IEnumerable<Designation_Master> Designation()
        {
            IEnumerable<Designation_Master> objDesignetion = new List<Designation_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objDesignetion = objEntity.Designation_Master.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objDesignetion.ToList();
        }
        [Route("HFA_DisttDetails")]
        [HttpGet]
        public IEnumerable<HFA_GetDistt_Result> BindDistricts(string stateCode)
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetDistt_Result> objDistt = new List<HFA_GetDistt_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objDistt = objEntity.HFA_GetDistt(stateCode);
            }
            catch (Exception ex)
            {
                throw;
            }
            return objDistt.ToList();
        }

        [Route("HFA_CityDetails")]
        [HttpGet]
        public IEnumerable<HFA_GetCity_Result> BindCity(string dCode)
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetCity_Result> objCity = new List<HFA_GetCity_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objCity = objEntity.HFA_GetCity(dCode).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objCity.ToList();
        }

        [Route("HFA_AllCityDetails")]
        [HttpGet]  
        public IEnumerable<HFA_GetAllCity_Result> BindAllCity(string dCode)
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetAllCity_Result> objCity = new List<HFA_GetAllCity_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objCity = objEntity.HFA_GetAllCity(dCode).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objCity.ToList();
        }



        [Route("HFA_City_Details")]
        [HttpGet]
        public IEnumerable<HFA_GetCities_Result> HFA_City_Details()
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<HFA_GetCities_Result> objState = new List<HFA_GetCities_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objState = objEntity.HFA_GetCities();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objState.ToList();
        }


        [HttpGet]
        [Route("HFA_WeeklyReportsSDC")]
        public sp_Cons_Values_SDC_Result BindBuilding_SDC(string stateCode, string Dcode, string CityCode)
        {
            //[PMAY_PROJECTS Copy$]   Table
            List<ConsReportView> lst = new List<ConsReportView>();
            EmployeeEntities objEntity = new EmployeeEntities();
            sp_Cons_Values_SDC_Result lstBulding = objEntity.sp_Cons_Values_SDC(stateCode, Dcode, CityCode).FirstOrDefault();
            return lstBulding;
        }

        [Route("HFA_HousingDetails")]
        [HttpGet]  //> GetStateWiseHouses(string stateCode)
        public GetStateWiseHouses_Result HFA_HousingDetails(string stateCode)
        {    //http://localhost:57855/Api/Builder/StateDetails
            GetStateWiseHouses_Result objCity = new GetStateWiseHouses_Result();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objCity = objEntity.GetStateWiseHouses(stateCode).FirstOrDefault();
            }
            catch (Exception ex)
            {
                //throw;
            }
            return objCity;
        }
        [HttpGet]
        [Route("HFACityWiseReportPMay")]
        public HFA_sp_PMayData_Result HFACityWiseReportPMay(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_PMayData_Result lstBulding = objEntity.HFA_sp_PMayData(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("Test")]
        public List<HFA_sp_FinYear_Datanew_Result> Test(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<HFA_sp_FinYear_Datanew_Result> lstBulding = objEntity.HFA_sp_FinYear_Datanew(stateCode, distrcitCode, cityCode).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("HFA_Proc_CLSS_CityWise")]
        public HFA_Proc_CLSS_CityWise_Result HFA_Proc_CLSS_CityWise(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_Proc_CLSS_CityWise_Result lstBulding = objEntity.HFA_Proc_CLSS_CityWise(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_Proc_CLSS_StateWise_New")]
        public HFA_Proc_CLSS_StateWise_New_Result HFA_Proc_CLSS_StateWise_New(string stateCode, string division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_Proc_CLSS_StateWise_New_Result lstBulding = objEntity.HFA_Proc_CLSS_StateWise_New(stateCode, division).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("HFA_Proc_CLSS_CityWise_New")]
        public HFA_Proc_CLSS_CityWise_New_Result HFA_Proc_CLSS_CityWise_New(string stateCode, string distrcitCode, string cityCode, string Division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_Proc_CLSS_CityWise_New_Result lstBulding = objEntity.HFA_Proc_CLSS_CityWise_New(stateCode, distrcitCode, cityCode, Division).FirstOrDefault();

            return lstBulding;
        }

        [HttpGet]
        [Route("HFA_JNNURMCityWise")]
        public HFA_JNNURMCityWise_Result HFA_JNNURMCityWise(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_JNNURMCityWise_Result lstBulding = objEntity.HFA_JNNURMCityWise(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_DemandCityWise")]
        public HFA_DemandCityWise_Result HFA_DemandCityWise(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_DemandCityWise_Result lstBulding = objEntity.HFA_DemandCityWise(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [Route("HousesDetails")]
        [HttpGet]
        public List<hfa_Houses_Result> HousesDetails()
        {    //http://localhost:57855/Api/Builder/StateDetails
            IEnumerable<hfa_Houses_Result> objHiuses = new List<hfa_Houses_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objHiuses = objEntity.hfa_Houses().ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objHiuses.ToList();
        }
        [HttpGet]
        [Route("HFA_JNNURM_AtaGlance")]
        public HFA_JNNURN_AtAGlance_Result HFA_JNNURM_AtaGlance(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_JNNURN_AtAGlance_Result lstBulding = objEntity.HFA_JNNURN_AtAGlance(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_JNNURN_AtAGlanceNew")]
        public HFA_JNNURN_AtAGlanceNew_Result HFA_JNNURN_AtAGlanceNew(string stateCode, string distrcitCode, string cityCode, string Division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_JNNURN_AtAGlanceNew_Result lstBulding = objEntity.HFA_JNNURN_AtAGlanceNew(stateCode, distrcitCode, cityCode, Division).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("HFA_Component_AtaGlance")]
        public HFA_ComponentsData_AtAGlance_Result HFA_Component_AtaGlance(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_ComponentsData_AtAGlance_Result lstBulding = objEntity.HFA_ComponentsData_AtAGlance(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_RAY_AtaGlance")]
        public HFA_RAY_AtAGlance_Result HFA_RAY_AtaGlance(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_RAY_AtAGlance_Result lstBulding = objEntity.HFA_RAY_AtAGlance(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("HFA_RAY_AtAGlance_New")]
        public HFA_RAY_AtAGlance_New_Result HFA_RAY_AtAGlance_New(string stateCode, string distrcitCode, string cityCode, string Division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_RAY_AtAGlance_New_Result lstBulding = objEntity.HFA_RAY_AtAGlance_New(stateCode, distrcitCode, cityCode, Division).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("HFA_ISSR_AtaGlance")]
        public HFA_ISSR_AtAGlance_Result HFA_ISSR_AtaGlance(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_ISSR_AtAGlance_Result lstBulding = objEntity.HFA_ISSR_AtAGlance(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_ISSR_AtAGlance_New")]
        public HFA_ISSR_AtAGlance_New_Result HFA_ISSR_AtAGlance_New(string stateCode, string distrcitCode, string cityCode, string Division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_ISSR_AtAGlance_New_Result lstBulding = objEntity.HFA_ISSR_AtAGlance_New(stateCode, distrcitCode, cityCode, Division).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("HFA_AHP_AtaGlance")]
        public HFA_AHP_AtAGlance_Result HFA_AHP_AtaGlance(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_AHP_AtAGlance_Result lstBulding = objEntity.HFA_AHP_AtAGlance(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("HFA_AHP_AtAGlance_New")]
        public HFA_AHP_AtAGlance_New_Result HFA_AHP_AtAGlance_New(string stateCode, string distrcitCode, string cityCode, string Division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_AHP_AtAGlance_New_Result lstBulding = objEntity.HFA_AHP_AtAGlance_New(stateCode, distrcitCode, cityCode, Division).FirstOrDefault();
            return lstBulding;
        }


        [HttpGet]
        [Route("HFA_BLCS_AtaGlance")]
        public HFA_BLCS_AtAGlance_Result HFA_BLCS_AtaGlance(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_BLCS_AtAGlance_Result lstBulding = objEntity.HFA_BLCS_AtAGlance(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_BLCS_AtAGlance_New")]
        public HFA_BLCS_AtAGlance_New_Result HFA_BLCS_AtAGlance_New(string stateCode, string distrcitCode, string cityCode, string Division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_BLCS_AtAGlance_New_Result lstBulding = objEntity.HFA_BLCS_AtAGlance_New(stateCode, distrcitCode, cityCode, Division).FirstOrDefault();
            return lstBulding;
        }
        [Route("HFA_FinYrWiseHouseDetails")]
        [HttpGet]
        public HFA_sp_PMayFinYrData_Result HFA_FinYrWiseHouseDetails(string stateCode, string distrcitCode, string cityCode)
        {
            HFA_sp_PMayFinYrData_Result objCity = new HFA_sp_PMayFinYrData_Result();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objCity = objEntity.HFA_sp_PMayFinYrData(stateCode, distrcitCode, cityCode).FirstOrDefault();
            }
            catch (Exception ex)
            {
                //throw;
            }
            return objCity;
        }
        //------------------------------
        [HttpGet]
        [Route("HFA_sp_FinYr_1415")]
        public HFA_sp_FinYr_1415_Result HFA_sp_FinYr_1415(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_FinYr_1415_Result lstBulding = objEntity.HFA_sp_FinYr_1415(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }



        [HttpGet]
        [Route("HFA_sp_FinYr_1516")]
        public HFA_sp_FinYr_1516_Result HFA_sp_FinYr_1516(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_FinYr_1516_Result lstBulding = objEntity.HFA_sp_FinYr_1516(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_sp_FinYr_1617")]
        public HFA_sp_FinYr_1617_Result HFA_sp_FinYr_1617(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_FinYr_1617_Result lstBulding = objEntity.HFA_sp_FinYr_1617(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_sp_FinYr_1718")]
        public HFA_sp_FinYr_1718_Result HFA_sp_FinYr_1718(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_FinYr_1718_Result lstBulding = objEntity.HFA_sp_FinYr_1718(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_sp_FinYr_1819")]
        public HFA_sp_FinYr_1819_Result HFA_sp_FinYr_1819(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_FinYr_1819_Result lstBulding = objEntity.HFA_sp_FinYr_1819(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }

        //> 
        [HttpGet]
        [Route("HFA_sp_PhyFin14_15Data")]
        public HFA_sp_PhyFin14_15Data_Result HFA_sp_PhyFin14_15Data(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_PhyFin14_15Data_Result lstBulding = objEntity.HFA_sp_PhyFin14_15Data(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_sp_PhyFin15_16Data")]
        public HFA_sp_PhyFin15_16Data_Result HFA_sp_PhyFin15_16Data(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_PhyFin15_16Data_Result lstBulding = objEntity.HFA_sp_PhyFin15_16Data(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("HFA_sp_PhyFin16_17Data")]
        public HFA_sp_PhyFin16_17Data_Result HFA_sp_PhyFin16_17Data(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_PhyFin16_17Data_Result lstBulding = objEntity.HFA_sp_PhyFin16_17Data(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_sp_PhyFin17_18Data")]
        public HFA_sp_PhyFin17_18Data_Result HFA_sp_PhyFin17_18Data(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_PhyFin17_18Data_Result lstBulding = objEntity.HFA_sp_PhyFin17_18Data(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_sp_PhyFin18_19Data")]
        public HFA_sp_PhyFin18_19Data_Result HFA_sp_PhyFin18_19Data(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_PhyFin18_19Data_Result lstBulding = objEntity.HFA_sp_PhyFin18_19Data(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        //------------------------ comp wise
        [HttpGet]
        [Route("GETComponent")]
        public List<ComponentMaster> GETComponent()
        {
            List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstCompMaster = objEntity.ComponentMasters.Take(5).Where(b => b.sFlag == true).OrderBy(a => a.Cid).ToList();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("GET_HFACodes")]
        public List<HFA_Master> GET_HFACodes()
        {
            List<HFA_Master> lstCompMaster = new List<HFA_Master>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstCompMaster = objEntity.HFA_Master.ToList();
            return lstCompMaster;
        }

        [HttpGet]
        [Route("HFA_sp_PMay_CompWise")]
        public HFA_sp_PMay_CompWise_Result HFA_sp_PMay_CompWise(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_PMay_CompWise_Result lstBulding = objEntity.HFA_sp_PMay_CompWise(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_sp_CLSS_CompWise")]
        public HFA_sp_CLSS_CompWise_Result HFA_sp_PMay_CompWise(string stateCode, string distrcitCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_sp_CLSS_CompWise_Result lstBulding = objEntity.HFA_sp_CLSS_CompWise(stateCode, distrcitCode, cityCode).FirstOrDefault();
            return lstBulding;
        }
        //----------------------Component Wise ------------------------------------------------------------------------------
        [HttpGet]
        [Route("SendCompPMAY")]
        public PMAY_Data SendComp(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.HFA_sp_PMay_CompWise_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        //----------------------Component Wise ------------------------------------------------------------------------------
        [HttpGet]
        [Route("DemandDynamic")]
        public DemandNew DemandDynamic(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            DemandNew lstCompMaster = new DemandNew();
            try
            {
                if (stateCode != null && distrcitCode != null && cityCode != null && cid != null)
                {
                    //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
                    EmployeeEntities objEntity = new EmployeeEntities();
                    lstCompMaster = objEntity.HFA_GetDemandCompWiseN_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                //   throw;
            }
            finally { }
            return lstCompMaster;

        }

        [HttpGet]
        [Route("Demand_Dynamic")]
        public DemandNew Demand_Dynamic(string stateCode, string distrcitCode, string cityCode, string DIV, string DemandT)
        {
            DemandNew lstCompMaster = new DemandNew();
            try
            {
                if (stateCode != null && distrcitCode != null && cityCode != null && DIV != null)
                {
                    //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
                    EmployeeEntities objEntity = new EmployeeEntities();
                    lstCompMaster = objEntity.HFA_GetDemand_COMP_DIV_CITYWise_e(stateCode, distrcitCode, cityCode, DIV, DemandT).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                //   throw;
            }
            finally { }
            return lstCompMaster;

        }

        [HttpGet]
        [Route("Demand_CITY_DIVDynamic")]
        public DemandNew Demand_CITY_DIVDynamic(string stateCode, string distrcitCode, string cityCode, string Div)
        {
            DemandNew lstCompMaster = new DemandNew();
            try
            {
                if (stateCode != null && distrcitCode != null && cityCode != null && Div != null)
                {
                    //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
                    EmployeeEntities objEntity = new EmployeeEntities();
                    lstCompMaster = objEntity.HFA_GetDemandCompDiv_Wise_e(stateCode, distrcitCode, cityCode, Div).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                //   throw;
            }
            finally { }
            return lstCompMaster;
        }
        [HttpGet]
        [Route("Sanctioned_Dynamic")]
        public ComponentWiseSanctioned Demand_Dynamic(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.HFA_sp_PMayCompAll_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }

        //[HttpGet]
        //[Route("ComponentWiseSanct")]
        //public ComponentWiseSanctioned ComponentWiseSanction(string stateCode, string distrcitCode, string cityCode, string cid)
        //{
        //    //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    var lstCompMaster = objEntity.HFA_spPMayCompWiseData_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
        //    return lstCompMaster;
        //}

        [HttpGet]
        [Route("ComponentWiseSanct")]
        public List<HFA_spPMayCompWiseData_Result> HFA_spPMayCompWiseData(string stateCode, string distrcitCode, string cityCode, string cid)
        {  // personal Use
            EmployeeEntities objEntity = new EmployeeEntities();
            List<HFA_spPMayCompWiseData_Result> lstBulding = new List<HFA_spPMayCompWiseData_Result>();
            lstBulding = objEntity.HFA_spPMayCompWiseData(stateCode, distrcitCode, cityCode, cid).ToList();
            return lstBulding;
        }
        [Route("ComponentWiseSanct1")]
        [HttpGet]
        public HFA_spPMayCompWiseData_Result HFA_FinYrWiseHouseDetails(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            HFA_spPMayCompWiseData_Result objCity = new HFA_spPMayCompWiseData_Result();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objCity = objEntity.HFA_spPMayCompWiseData(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            }
            catch (Exception ex)
            {
                //throw;
            }
            return objCity;
        }
        [HttpGet]
        [Route("ComponentWise_Sanct")]
        public List<HFA_spPMayCompWiseData_Result> ComponentWiseSanct2(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            List<HFA_spPMayCompWiseData_Result> lstCompMaster = new List<HFA_spPMayCompWiseData_Result>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstCompMaster = objEntity.HFA_spPMayCompWiseData(stateCode, distrcitCode, cityCode, cid).ToList();
            return lstCompMaster;
        }

        [HttpGet]
        [Route("ComponentWiseSanctNew")]
        public HFA_spPMayCompWiseDataN_Result HFA_spPMayCompWiseDataN(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            HFA_spPMayCompWiseDataN_Result lstBulding = objEntity.HFA_spPMayCompWiseDataN(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstBulding;
        }

        //[HttpGet]
        //[Route("ComponentWise_Sanct")]
        //public HFA_spPMayCompWiseData_Result ComponentWiseSanct3(string stateCode, string distrcitCode, string cityCode, string cid)
        //{
        //    List<HFA_spPMayCompWiseData_Result> lstCompMaster = new List<HFA_spPMayCompWiseData_Result>();
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    lstCompMaster = objEntity.HFA_spPMayCompWiseDataN(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
        //    return lstCompMaster;
        //}

        [HttpGet]
        [Route("SendFinance_Data14_15")]
        public PMAY_FinancialData SendFinance_Data14_15(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.HFA_GetFinData_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("SendFinance_Data15_16")]
        public PMAY_FinancialData SendFinance_Data15_16(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.HFA_GetFinData15_16_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("SendFinance_Data16_17")]
        public PMAY_FinancialData SendFinance_Data16_17(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.HFA_GetFinData16_17_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("SendFinance_Data17_18")]
        public PMAY_FinancialData SendFinance_Data17_18(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.HFA_GetFinData17_18_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("SendFinance_Data18_19")]
        public PMAY_FinancialData SendFinance_Data18_19(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.HFA_GetFinData18_19_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }

        [HttpGet]
        [Route("SendFinance_Data19_20")]
        public PMAY_FinancialData SendFinance_Data19_20(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.HFA_GetFinData19_20_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }


        [HttpGet]
        [Route("HFA_StateWiseScore")]
        public GetStateWiseScore_Result HFA_StateWiseScore(string stateCode)
        {
            string stateCode1 = Int32.Parse(stateCode).ToString();
            GetStateWiseScore_Result lstBulding = new GetStateWiseScore_Result();
            if (stateCode1 != "0")
            {
                EmployeeEntities objEntity = new EmployeeEntities();
                lstBulding = objEntity.GetStateWiseScore(stateCode1).FirstOrDefault();
            }
            return lstBulding;
        }
        [HttpGet]
        [Route("HFA_StateWiseScoreNew")]
        public GetStateWiseScoreNew_Result HFA_StateWiseScoreNew(string stateCode, string division)
        {
            string stateCode1 = Int32.Parse(stateCode).ToString();
            GetStateWiseScoreNew_Result lstBulding = new GetStateWiseScoreNew_Result();
            if (stateCode1 != "0")
            {
                EmployeeEntities objEntity = new EmployeeEntities();
                lstBulding = objEntity.GetStateWiseScoreNew(stateCode1, division).FirstOrDefault();
            }
            return lstBulding;
        }
        //00000000000000000000000
        [HttpGet]
        [Route("HFA_Finance_Progress14_15")]
        public FinancialProgress Finance_Progress14_15(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress14_15_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("HFA_Finance_Progress15_16")]
        public FinancialProgress Finance_Progress15_16(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress15_16_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("HFA_Finance_Progress16_17")]
        public FinancialProgress Finance_Progress16_17(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress16_17_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("HFA_Finance_Progress17_18")]
        public FinancialProgress Finance_Progress17_18(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress17_18_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("HFA_Finance_Progress18_19")]
        public FinancialProgress Finance_Progress18_19(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress18_19_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("HFA_Finance_Progress19_20")]
        public FinancialProgress Finance_Progress19_20(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress19_20_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("SectorWiseReport")]
        public PMAY_Data SectorWiseReport(string stateCode, string distrcitCode, string cityCode, string cid)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.SectorWiseReport_e(stateCode, distrcitCode, cityCode, cid).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("CSMC_StateWiseReport")]
        public List<sp_CSMC_StateWise_Result> sp_CSMC_StateWise(string stateCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_CSMC_StateWise_Result> lstBulding = new List<sp_CSMC_StateWise_Result>();
            lstBulding = objEntity.sp_CSMC_StateWise(stateCode).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("CSMC_StateWiseReportNew")]
        public List<sp_CSMC_StateWiseNew_Result> CSMC_StateWiseReportNew(string stateCode, string division)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_CSMC_StateWiseNew_Result> lstBulding = new List<sp_CSMC_StateWiseNew_Result>();
            lstBulding = objEntity.sp_CSMC_StateWiseNew(stateCode, division).ToList();
            return lstBulding;
        }




        //[Route("HFA_StateDetailsNew")]
        //[HttpGet]
        //public PMAY_Data HFA_StateDetails(string division)
        //{
        //    IEnumerable<HFA_GetStatesByDivision_Result> objState = new List<HFA_GetStatesByDivision_Result>();
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    try
        //    {
        //        objState = objEntity.HFA_GetStatesByDivision(division).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    return objState.ToList();
        //}




        //[Route("HFA_StateDetailsNew")]
        //[HttpGet]
        //public PMAY_Data HFA_StateDetails(string division)
        //{
        //    IEnumerable<HFA_GetStatesByDivision_Result> objState = new List<HFA_GetStatesByDivision_Result>();
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    try
        //    {
        //        objState = objEntity.HFA_GetStatesByDivision(division).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    return objState.ToList();
        //}

        [HttpGet]
        [Route("HFA_StateDetailsNew")]
        public List<DivisionDet> HFA_DivDetails(string division)
        {
            if (division == null)
                division = "0";
            List<DivisionDet> lstDivMaster = new List<DivisionDet>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.HFA_GetByDivision_e(division).ToList();
            return lstDivMaster;
        }

        [HttpGet]
        [Route("getChartByDivision")]
        public List<DivisionDet> getChartByDivision(string division)
        {
            string stateId = "";
            List<DivisionDet> lstDivMaster = new List<DivisionDet>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstState = objEntity.HFA_GetByDivision_e(division).ToList();

            foreach (var item in lstState)
            {
                stateId += item.Codes + ",";


            }
            stateId = stateId.TrimEnd(',');
            var chartDetails = objEntity.HFA_GetByStateId_e(stateId).ToList();
            return chartDetails;
        }

        [HttpGet]
        [Route("SendCompPMAY_new")]
        public PMAY_Data SendCompNew11(string StateCode, string dcode, string cityCode, string Cid, string Division)
        {
            List<PMAY_Data> lstDivMaster = new List<PMAY_Data>();
            //if (Division == "HFA-1")
            //{
            //    StateCode = "'1,2,3,5,6,8,9,22,23'";
            //}
            //if (Division == "HFA-3")
            //{
            //     StateCode = "'19,21,28,29,32,33,36'";
            //   // StateCode = "'28'";
            //}
            //if (Division == "HFA-4")
            //{
            //    StateCode = "'24,27,30'";
            //}
            //if (Division == "HFA-5")
            //{
            //    StateCode = "'4,7,10,11,12,13,14,15,16,17,18,20,25,26,31,34,35'";
            //}
            //if (Division == "HFA-1,HFA-5")
            //{
            //    StateCode = "'1,2,3,5,6,8,9,22,23,4,7,10,11,12,13,14,15,16,17,18,20,25,26,31,34,35'";
            //}
            //if (Division == "HFA-1,HFA-3" || Division == "HFA-3,HFA-1")
            //{
            //    StateCode = "'1,2,3,5,6,8,9,22,23,19,21,28,29,32,33,36'";
            //}
            //if ((Division == "HFA-1,HFA-4") || (Division == "HFA-4,HFA-1"))
            //{
            //    StateCode = "'1,2,3,5,6,8,9,22,23,24,27,30'";
            //}
            //if (Division == "HFA-1,HFA-3,HFA-4" || Division == "HFA-3,HFA-1,HFA-4" || Division == "HFA-4,HFA-1,HFA-3" || Division == "HFA-3,HFA-4,HFA-1" || Division == "HFA-4,HFA-3,HFA-1")
            //{
            //    StateCode = "'1,2,3,5,6,8,9,22,23,19,21,28,29,32,33,36,24,27,30'";
            //}
            //if (Division == "HFA-1,HFA-3,HFA-4,HFA-5" || Division == "HFA-3,HFA-1,HFA-4,HFA-5" || Division == "HFA-3,HFA-1,HFA-5,HFA-4" || Division == "HFA-3,HFA-1,HFA-4,HFA-5" || Division == "HFA-4,HFA-1,HFA-3,HFA-5")
            //{
            //    StateCode = "'1,2,3,5,6,8,9,22,23,19,21,28,29,32,33,36,24,27,30,4,7,10,11,12,13,14,15,16,17,18,20,25,26,31,34,35'";
            //}
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.HFA_sp_PMay_CompWiseNew_e(StateCode, dcode, cityCode, Cid, Division).FirstOrDefault();
            return lstCompMaster;
        }


        [HttpPost]
        [Route("UserRegister")]
        public string InsertUser(UserVM data)
        {
            string message = "";
            if (data != null)
            {
                user_Master obj = new user_Master();
                obj.UserName = data.UserName;
                //   obj.LastName = data.LastName;
                //  obj.Address = data.Address;


                obj.Password = data.Password;
                obj.EmailId = data.EmailId;
                obj.StateId = Convert.ToInt32(data.StateId);
                obj.DesignationId = data.DesigId;
                obj.CityId = Convert.ToInt32(data.CityId);
                obj.LastLoginDate = Convert.ToDateTime(data.LastLoginDate);
                obj.TaskId = Convert.ToInt32(data.TaskId);

                EmployeeEntities objEntity = new EmployeeEntities();
                objEntity.user_Master.Add(obj);
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


        [HttpGet]
        [Route("GetAllUsers")]
        public List<GetAllUsers_Result> GetAllUsers()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<GetAllUsers_Result> lstBulding = objEntity.GetAllUsers().ToList();
            return lstBulding;
        }


        [HttpGet]
        [Route("GetScore1Details")]
        public List<Score1_Result> GetScore1(string stateCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<Score1_Result> lstScor = objEntity.Score1(stateCode).ToList();
            return lstScor;
        }

        [HttpGet]
        [Route("GetScore2Details")]
        public Score2_Result GetScore2(string stateCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            Score2_Result lstScor = objEntity.Score2(stateCode).FirstOrDefault();
            return lstScor;
        }
        [HttpGet]
        [Route("sp_CSMC_State_Comp_DtWise")]
        public sp_CSMC_State_Comp_DtWise_Result sp_CSMC_State_Comp_DtWise(string stateCode, string component, string cSMCDate)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            sp_CSMC_State_Comp_DtWise_Result lstScor = objEntity.sp_CSMC_State_Comp_DtWise(stateCode, component, cSMCDate).FirstOrDefault();
            return lstScor;
        }
        [HttpGet]
        [Route("sp_CSMC_State_Comp_DtWise11")]
        public List<sp_CSMC_State_Comp_DtWise12_Result> sp_CSMC_State_Comp_DtWise11(string stateCode, string component, string cSMCDate, string CSMCNo)
        {
            DateTime dateTime = Convert.ToDateTime(cSMCDate);
            string str = dateTime.ToString();
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_CSMC_State_Comp_DtWise12_Result> lstScor = objEntity.sp_CSMC_State_Comp_DtWise12(stateCode, component, cSMCDate, CSMCNo).ToList();
            return lstScor;
        }
        //------------------------------------------
        [HttpGet]
        [Route("HFA_Finance_Progress14_15New")]
        public FinancialProgress Finance_Progress14_15_NEW(string stateCode, string distrcitCode, string cityCode, string cid, string Division)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress14_15_NEWe(stateCode, distrcitCode, cityCode, cid, Division).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("HFA_Finance_Progress15_16New")]
        public FinancialProgress Finance_Progress15_16_NEW(string stateCode, string distrcitCode, string cityCode, string cid, string Division)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress15_16_NEWe(stateCode, distrcitCode, cityCode, cid, Division).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("HFA_Finance_Progress16_17New")]
        public FinancialProgress Finance_Progress16_17_NEW(string stateCode, string distrcitCode, string cityCode, string cid, string Division)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress16_17_NEWe(stateCode, distrcitCode, cityCode, cid, Division).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("HFA_Finance_Progress17_18New")]
        public FinancialProgress Finance_Progress17_18_NEW(string stateCode, string distrcitCode, string cityCode, string cid, string Division)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress17_18_NEWe(stateCode, distrcitCode, cityCode, cid, Division).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("HFA_Finance_Progress18_19New")]
        public FinancialProgress Finance_Progress18_19_NEW(string stateCode, string distrcitCode, string cityCode, string cid, string Division)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.Finance_Progress18_19_NEWe(stateCode, distrcitCode, cityCode, cid, Division).FirstOrDefault();
            return lstCompMaster;
        }

        [Route("ReadExcelSheet")]
        [HttpGet]
        public List<ExcelSheet> ReadExcelSheet()
        {
            var path = HttpContext.Current.Request.MapPath("~/upload_excel/CLSS-11-4-19.xlsx");
            FileStream fileStream = File.OpenRead(path);
            IExcelDataReader reader = null;
            if (fileStream.Name.EndsWith(".xls"))
            {
                reader = ExcelReaderFactory.CreateBinaryReader(fileStream);
            }
            else if (fileStream.Name.EndsWith(".xlsx"))
            {
                reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
            }
            DataSet excelRecords = reader.AsDataSet();
            reader.Close();
            List<ExcelSheet> lstExcel = new List<ExcelSheet>();
            var finalRecords = excelRecords.Tables[0];
            for (int i = 0; i < excelRecords.Tables.Count; i++)
            {
                ExcelSheet objExcel = new ExcelSheet();
                objExcel.SheetName = excelRecords.Tables[i].TableName;

                lstExcel.Add(objExcel);
            }
            return lstExcel;
        }
        [HttpGet]
        [Route("ReadExcelSheet1")]
        public string ReadExcel1()
        {
            string dire = "~/upload_excel";
            var path = System.Web.HttpContext.Current.Request.MapPath("~/upload_excel/CLSS-11-4-19.xlsx");
            var httpRequest = HttpContext.Current.Request.Files["file"];
            EmployeeEntities objEntity = new EmployeeEntities();
            HttpPostedFile file = httpRequest;
            file.SaveAs(Path.Combine(dire, "CLSS-11-4-19.xlsx"));
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
            int count = result.Tables.Count;

            var value = result.Tables[0];
            List<Testtable> lst = new List<Testtable>();
            for (int i = 1; i < value.Rows.Count; i++)
            {
                Testtable obj = new Testtable();
                obj.A = value.Rows[i][0].ToString();
                obj.B = value.Rows[i][1].ToString();
                obj.C = value.Rows[i][2].ToString(); ;

                obj.D = value.Rows[i][3].ToString(); ;
                obj.E = value.Rows[i][4].ToString(); ;
                lst.Add(obj);
                objEntity.Testtables.Add(obj);
            }
            objEntity.SaveChanges();

            //kal karte hai nulll ja raha ha
            return "sussess";
        }


        //-----------------  1  TEST DEMO
        [HttpPost]
        [Route("UploadExcel")] // bulk inset testtable *****
        public string ExcelUpload()
        {  //// testTable bulk insert
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<Testtable> lst = new List<Testtable>();
                for (int i = 1; i < value.Rows.Count; i++)
                {
                    Testtable obj = new Testtable();
                    obj.A = value.Rows[i][0].ToString();
                    obj.B = value.Rows[i][1].ToString();
                    obj.C = value.Rows[i][2].ToString(); ;

                    obj.D = value.Rows[i][3].ToString(); ;
                    obj.E = value.Rows[i][4].ToString(); ;
                    lst.Add(obj);
                    objEntity.Testtables.Add(obj);
                }
                objEntity.SaveChanges();
            }
            return "sussess";
        }
        [HttpGet]
        [Route("DeleteExcelDetails")]
        public string DeleteExcel(string excelId)
        {
            string message = "";
            if (excelId != "")
            {
                int id = Convert.ToInt32(excelId);
                EmployeeEntities objEntity = new EmployeeEntities();
                var data = objEntity.Testtables.Find(id);
                objEntity.Testtables.Remove(data);
                int i = objEntity.SaveChanges();

                if (i > 0)
                {
                    message = "Records has been successfully deleted";
                }
                else
                {
                    message = "Records deletion has been faild";
                }
            }

            return message;
        }

        [Route("GetExcelDetails")]
        [HttpGet]
        public IEnumerable<Testtable> GetExcel()
        {
            IEnumerable<Testtable> objExcel = new List<Testtable>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.Testtables.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return objExcel;
        }

        //----------------- 2   ClssCityWise   start
        [Route("GetExcelCLSSDetails")]
        [HttpGet]
        public IEnumerable<CLSS_MainMasterVM> GetExcelCLSSDetails()
        {
            IEnumerable<CLSS_MainMasterVM> objExcel = new List<CLSS_MainMasterVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.CLSS_MainMaster.Select(a => new CLSS_MainMasterVM
                {
                    SrNo = a.SrNo.ToString(),
                    state_Name = a.state_Name,
                    State_Code = a.State_Code.ToString(),
                    District_Name = a.District_Name,
                    Dcode = a.Dcode.ToString(),
                    City_Name = a.City_Name,
                    CityCode = a.CityCode.ToString(),

                    EWS_Bene = a.EWS_Bene.ToString(),
                    EWS_Loan_Amt = a.EWS_Loan_Amt.ToString(),
                    EWS_Subsidy = a.EWS_Subsidy.ToString(),
                    LIG_Bene = a.LIG_Bene.ToString(),

                    LIG_Loan_Amt = a.LIG_Loan_Amt.ToString(),
                    LIG_Subsidy = a.LIG_Subsidy.ToString(),
                    MIG1_Bene = a.MIG1_Bene.ToString(),
                    MIG1_Loan_Amt = a.MIG1_Loan_Amt.ToString(),

                    MIG1_SubsidyAmt = a.MIG1_SubsidyAmt.ToString(),
                    MIG2_Bene = a.MIG2_Bene.ToString(),
                    MIG2_Loan_Am = a.MIG2_Loan_Am.ToString(),
                    MIG2_SubsidyAmt = a.MIG2_SubsidyAmt.ToString(),

                    Total_LoanAmt = a.Total_LoanAmt.ToString(),
                    Total_SubsidyAmt = a.Total_SubsidyAmt.ToString(),
                    Total_Beneficiaries = a.Total_Beneficiaries.ToString(),
                    Cid = a.Cid.ToString(),


                }).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objExcel;
        }

        [HttpPost]
        [Route("UploadExcel_CLSS")]
        public string ExcelUpload_CLSS()
        {
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<CLSS_MainMaster> lst = new List<CLSS_MainMaster>();
                for (int i = 1; i < value.Rows.Count; i++)
                {
                    CLSS_MainMaster obj = new CLSS_MainMaster();
                    obj.state_Name = value.Rows[i][1].ToString();

                    string statecde = value.Rows[i][2].ToString();
                    obj.State_Code = Convert.ToDouble(statecde);

                    obj.District_Name = value.Rows[i][3].ToString();

                    string Districtcde = value.Rows[i][4].ToString();
                    obj.Dcode = Convert.ToDouble(Districtcde);

                    obj.City_Name = value.Rows[i][5].ToString();

                    string Citycde = value.Rows[i][6].ToString();
                    obj.CityCode = Convert.ToDouble(Citycde);
                    //-----------
                    string EWS_Ben = value.Rows[i][7].ToString();
                    obj.EWS_Bene = Convert.ToDouble(EWS_Ben);

                    string EWS_Loan_Am = value.Rows[i][8].ToString();
                    obj.EWS_Loan_Amt = Convert.ToDouble(EWS_Loan_Am);

                    string EWS_Subsidy = value.Rows[i][9].ToString();
                    obj.EWS_Subsidy = Convert.ToDouble(EWS_Subsidy);

                    string LIG_Ben = value.Rows[i][10].ToString();
                    obj.LIG_Bene = Convert.ToDouble(LIG_Ben);

                    string LIG_Loan_Am = value.Rows[i][11].ToString();
                    obj.LIG_Loan_Amt = Convert.ToDouble(LIG_Loan_Am);

                    string LIG_Subsid = value.Rows[i][12].ToString();
                    obj.LIG_Subsidy = Convert.ToDouble(LIG_Subsid);

                    string MIG1_Ben = value.Rows[i][13].ToString();
                    obj.MIG1_Bene = Convert.ToDouble(MIG1_Ben);

                    string MIG1_Loan_Am = value.Rows[i][14].ToString();
                    obj.MIG1_Loan_Amt = Convert.ToDouble(MIG1_Loan_Am);

                    string MIG1_SubsidyAm = value.Rows[i][15].ToString();
                    obj.MIG1_SubsidyAmt = Convert.ToDouble(MIG1_SubsidyAm);

                    string MIG2_Ben = value.Rows[i][16].ToString();
                    obj.MIG2_Bene = Convert.ToDouble(MIG2_Ben);

                    string MIG2_Loan_A = value.Rows[i][17].ToString();
                    obj.MIG2_Loan_Am = Convert.ToDouble(MIG2_Loan_A);

                    string MIG2_SubsidyAm = value.Rows[i][18].ToString();
                    obj.MIG2_SubsidyAmt = Convert.ToDouble(MIG2_SubsidyAm);

                    string Total_LoanAm = value.Rows[i][19].ToString();
                    obj.Total_LoanAmt = Convert.ToDouble(Total_LoanAm);

                    string Total_SubsidyAm = value.Rows[i][20].ToString();
                    obj.Total_SubsidyAmt = Convert.ToDouble(Total_SubsidyAm);

                    string Total_Beneficiarie = value.Rows[i][21].ToString();
                    obj.Total_Beneficiaries = Convert.ToDouble(Total_Beneficiarie);


                    obj.Cid = 0;// Int32.Parse(value.Rows[i][22].ToString());

                    lst.Add(obj);
                    objEntity.CLSS_MainMaster.Add(obj);
                }
                objEntity.SaveChanges();
            }
            //kal karte hai nulll ja raha ha
            return "sussess";
        }

        [HttpGet]
        [Route("DeleteCLSS_ExcelDetails")]
        public string DeleteCLSS_ExcelDetails(string excelId)
        {
            string message = "";
            if (excelId != "")
            {
                int id = Convert.ToInt32(excelId);
                EmployeeEntities objEntity = new EmployeeEntities();
                var data = objEntity.CLSS_MainMaster.Find(id);
                // objEntity.ClssCityWises.Remove(data);
                objEntity.CLSS_MainMaster.Remove(data);

                int i = objEntity.SaveChanges();

                if (i > 0)
                {
                    message = "Records has been successfully deleted";
                }
                else
                {
                    message = "Records deletion has been faild";
                }
            }
            return message;
        }
        //---------------ClssCityWise   end



        //----------------------------------------------------------------- 3 StateScore --> tblStateWiseScore
        [Route("ReadExcelCLSSSheet")]
        [HttpGet]
        public List<ExcelSheet> ReadExcelCLSSSheet()
        {
            var path = HttpContext.Current.Request.MapPath("~/upload_excel/ExcelUpload.xlsx");
            FileStream fileStream = File.OpenRead(path);
            IExcelDataReader reader = null;
            if (fileStream.Name.EndsWith(".xls"))
            {
                reader = ExcelReaderFactory.CreateBinaryReader(fileStream);
            }
            else if (fileStream.Name.EndsWith(".xlsx"))
            {
                reader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
            }
            DataSet excelRecords = reader.AsDataSet();
            reader.Close();
            List<ExcelSheet> lstExcel = new List<ExcelSheet>();
            var finalRecords = excelRecords.Tables[0];
            for (int i = 0; i < excelRecords.Tables.Count; i++)
            {
                ExcelSheet objExcel = new ExcelSheet();
                objExcel.SheetName = excelRecords.Tables[i].TableName;

                lstExcel.Add(objExcel);
            }
            return lstExcel;
        }


        //----------------------------------------------------------------- 3 StateScore --> tblStateWiseScore
        [HttpPost]
        [Route("UploadExcel_StateWiseScore")]  // Bulk Insert tblStateWiseScoreExcel  ****
        public string ExcelUploadStateScore()
        {
            // Bulk Insert tblStateWiseScoreExcel
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<tblStateWiseScore> lst = new List<tblStateWiseScore>();
                for (int i = 1; i < value.Rows.Count; i++)
                {

                    //  ScoreId StateId Codes StateName   Sanction_vs_Demand Grounding_Sanction 
                    //Completion_vs_Sanction BLC_Houses_Geotagged    Relelase_vs_Sanction MIS_Annexure_uploading  Beneficiary_Attachment Reforms_Achievement JN_Houses_vacant Population_Census_2011  TG_12_Housing_Shortage Aadhar_Coverage Cities_included_in_Mission Total_Demand_as_per_Road_map    Demand_met Per_Demand_met  Total_PMAY_U_Houses_ISSR_AHP_BLC_CLSS Valid_Aadhar_Beneficiaries  Bene_Percentage HFAPoA_funds_Released   HFAPoA_Received HFAPoA_Status   ISSR_NOP AHP_NOP BLC_NOP ISSR_CA_Committed   AHP_CA_Committed BLC_CA_Committed    ISSR_Sanct_for_Release AHP_Sanct_for_Release   BLC_Sanct_for_Release ISSR_CA_Released    AHP_CA_Released BLC_CA_Released ISSR_Balance_for_Release AHP_Balance_for_Release BLC_Balance_for_Release ISSR_Houses_Sanctioned  AHP_Houses_Sanctioned BLC_Houses_Sanctioned   ISSR_Grounded AHP_Grounded    BLC_Grounded ISSR_Completed  AHP_Completed BLC_Completed   PMAY_Funds_Released PMAY_Ucs_Received   PMAY_UC_Pending PMAY_Houses_Occupied    Reforms Reforms_Achieved    SLTC_Funds_Released_RsinnCr SLTC_Specialists_Approved   SLTC_Specialists_in_Place CLTC_Funds_Released_RsinCr  CLTC_Specialists_Approved CLTC_Specialists_in_Place   Projects_Approved Projects_uploaded   Percent_Projects_uploaded BLC_Houses_Approved BLC_Houses_Grounded BLC_Houses_Geo_Tagged   CLSS_MIS_Survey CLSS_Beneficiaries_EWS_LIG_MIG  CLSS_Subsidy_EWS_LIG_MIG JN_Houses_Sanctioned    JN_Houses_Completed JN_Houses_Occupied  JN_Houses_In_Progress JN_Houses_Unoccupied    JN_Houses_Non_Starter JN_UC_Pending   RAY_Houses_Sanctioned RAY_Houses_Completed    RAY_Houses_Occupied RAY_Houses_In_Progress  RAY_Houses_Unoccupied RAY_Houses_Non_Starter  RAY_UC_Pending Division

                    tblStateWiseScore obj = new tblStateWiseScore();
                    // obj.ScoreId = Convert.ToInt32(value.Rows[i][0].ToString());
                    obj.StateId = Convert.ToInt32(value.Rows[i][0].ToString());
                    obj.Codes = value.Rows[i][1].ToString(); ;
                    obj.StateName = value.Rows[i][2].ToString(); ;

                    if (value.Rows[i][3].ToString() == "")
                    {
                        obj.Sanction_vs_Demand = 0;
                    }
                    else
                    {
                        obj.Sanction_vs_Demand = Convert.ToDouble(value.Rows[i][3].ToString());
                    }

                    if (value.Rows[i][4].ToString() == "")
                    {
                        obj.Grounding_Sanction = 0;
                    }
                    else
                    {
                        obj.Grounding_Sanction = Convert.ToDouble(value.Rows[i][4].ToString());
                    }
                    //Completion_vs_Sanction BLC_Houses_Geotagged    Relelase_vs_Sanction 

                    if (value.Rows[i][5].ToString() == "")
                    {
                        obj.Completion_vs_Sanction = 0;
                    }
                    else
                    {
                        obj.Completion_vs_Sanction = Convert.ToDouble(value.Rows[i][5].ToString());
                    }

                    if (value.Rows[i][6].ToString() == "")
                    {
                        obj.BLC_Houses_Geotagged = 0;
                    }
                    else
                    {
                        obj.BLC_Houses_Geotagged = Convert.ToDouble(value.Rows[i][6].ToString());
                    }

                    if (value.Rows[i][7].ToString() == "")
                    {
                        obj.Relelase_vs_Sanction = 0;
                    }
                    else
                    {
                        obj.Relelase_vs_Sanction = Convert.ToDouble(value.Rows[i][7].ToString());
                    }
                    //MIS_Annexure_uploading  Beneficiary_Attachment Reforms_Achievement
                    if (value.Rows[i][8].ToString() == "")
                    {
                        obj.MIS_Annexure_uploading = 0;
                    }
                    else
                    {
                        obj.MIS_Annexure_uploading = Convert.ToDouble(value.Rows[i][8].ToString());
                    }

                    if (value.Rows[i][9].ToString() == "")
                    {
                        obj.Beneficiary_Attachment = 0;
                    }
                    else
                    {
                        obj.Beneficiary_Attachment = Convert.ToDouble(value.Rows[i][9].ToString());
                    }

                    if (value.Rows[i][10].ToString() == "")
                    {
                        obj.Reforms_Achievement = "0";
                    }
                    else
                    {
                        obj.Reforms_Achievement = value.Rows[i][10].ToString();
                    }
                    // JN_Houses_vacant Population_Census_2011  
                    if (value.Rows[i][11].ToString() == "")
                    {
                        obj.JN_Houses_vacant = 0;
                    }
                    else
                    {
                        obj.JN_Houses_vacant = Convert.ToDouble(value.Rows[i][11].ToString());
                    }

                    if (value.Rows[i][12].ToString() == "")
                    {
                        obj.Population_Census_2011 = 0;
                    }
                    else
                    {
                        obj.Population_Census_2011 = Convert.ToDouble(value.Rows[i][12].ToString());
                    }
                    //TG_12_Housing_Shortage Aadhar_Coverage Cities_included_in_Mission 
                    if (value.Rows[i][13].ToString() == "")
                    {
                        obj.TG_12_Housing_Shortage = 0;
                    }
                    else
                    {
                        obj.TG_12_Housing_Shortage = Convert.ToDouble(value.Rows[i][13].ToString());
                    }

                    if (value.Rows[i][14].ToString() == "")
                    {
                        obj.Aadhar_Coverage = "0";
                    }
                    else
                    {
                        obj.Aadhar_Coverage = (value.Rows[i][14].ToString());
                    }

                    obj.Cities_included_in_Mission = Convert.ToDouble(value.Rows[i][15].ToString());
                    //Total_Demand_as_per_Road_map    Demand_met Per_Demand_met  

                    obj.Total_Demand_as_per_Road_map = Convert.ToDouble(value.Rows[i][16].ToString());


                    if (value.Rows[i][17].ToString() == "")
                    {
                        obj.Per_Demand_met = 0;
                    }
                    else
                    {
                        obj.Demand_met = Convert.ToDouble(value.Rows[i][17].ToString());
                    }

                    if (value.Rows[i][18].ToString() == "")
                    {
                        obj.Per_Demand_met = 0;
                    }
                    else
                    {
                        obj.Per_Demand_met = Convert.ToDouble(value.Rows[i][18].ToString());
                    }
                    //Total_PMAY_U_Houses_ISSR_AHP_BLC_CLSS Valid_Aadhar_Beneficiaries 

                    if (value.Rows[i][19].ToString() == "")
                    {
                        obj.Total_PMAY_U_Houses_ISSR_AHP_BLC_CLSS = 0;
                    }
                    else
                    {
                        obj.Total_PMAY_U_Houses_ISSR_AHP_BLC_CLSS = Convert.ToDouble(value.Rows[i][19].ToString());
                    }

                    if (value.Rows[i][20].ToString() == "")
                    {
                        obj.Valid_Aadhar_Beneficiaries = 0;
                    }
                    else
                    {
                        obj.Valid_Aadhar_Beneficiaries = Convert.ToDouble(value.Rows[i][20].ToString());
                    }
                    //Bene_Percentage HFAPoA_funds_Released   

                    if (value.Rows[i][21].ToString() == "")
                    {
                        obj.Bene_Percentage = 0;
                    }
                    else
                    {
                        obj.Bene_Percentage = Convert.ToDouble(value.Rows[i][21].ToString());
                    }

                    if (value.Rows[i][22].ToString() == "")
                    {
                        obj.HFAPoA_funds_Released = 0;
                    }
                    else
                    {
                        obj.HFAPoA_funds_Released = Convert.ToDouble(value.Rows[i][22].ToString());
                    }
                    //HFAPoA_Received HFAPoA_Status  
                    if (value.Rows[i][23].ToString() == "")
                    {
                        obj.HFAPoA_Received = 0;
                    }
                    else
                    {
                        obj.HFAPoA_Received = Convert.ToDouble(value.Rows[i][23].ToString());
                    }

                    obj.HFAPoA_Status = value.Rows[i][24].ToString();
                    //ISSR_NOP AHP_NOP 

                    if (value.Rows[i][25].ToString() == "")
                    {
                        obj.ISSR_NOP = 0;
                    }
                    else
                    {
                        obj.ISSR_NOP = Convert.ToDouble(value.Rows[i][25].ToString());
                    }

                    if (value.Rows[i][26].ToString() == "")
                    {
                        obj.AHP_NOP = 0;
                    }
                    else
                    {
                        obj.AHP_NOP = Convert.ToDouble(value.Rows[i][26].ToString());
                    }
                    //BLC_NOP ISSR_CA_Committed  

                    if (value.Rows[i][27].ToString() == "")
                    {
                        obj.BLC_NOP = 0;
                    }
                    else
                    {
                        obj.BLC_NOP = Convert.ToDouble(value.Rows[i][27].ToString());
                    }

                    if (value.Rows[i][28].ToString() == "")
                    {
                        obj.ISSR_CA_Committed = 0;
                    }
                    else
                    {
                        obj.ISSR_CA_Committed = Convert.ToDouble(value.Rows[i][28].ToString());
                    }
                    //AHP_CA_Committed BLC_CA_Committed   

                    if (value.Rows[i][29].ToString() == "")
                    {
                        obj.AHP_CA_Committed = 0;
                    }
                    else
                    {
                        obj.AHP_CA_Committed = Convert.ToDouble(value.Rows[i][29].ToString());
                    }
                    if (value.Rows[i][30].ToString() == "")
                    {
                        obj.BLC_CA_Committed = 0;
                    }
                    else
                    {
                        obj.BLC_CA_Committed = Convert.ToDouble(value.Rows[i][30].ToString());
                    }

                    //ISSR_Sanct_for_Release AHP_Sanct_for_Release 

                    if (value.Rows[i][31].ToString() == "")
                    {
                        obj.ISSR_Sanct_for_Release = 0;
                    }
                    else
                    {
                        obj.ISSR_Sanct_for_Release = Convert.ToDouble(value.Rows[i][31].ToString());
                    }
                    //----------------------------------------------------
                    if (value.Rows[i][32].ToString() == "")
                    {
                        obj.AHP_Sanct_for_Release = 0;
                    }
                    else
                    {
                        obj.AHP_Sanct_for_Release = Convert.ToDouble(value.Rows[i][32].ToString());
                    }
                    //BLC_Sanct_for_Release ISSR_CA_Released    

                    if (value.Rows[i][33].ToString() == "")
                    {
                        obj.BLC_Sanct_for_Release = 0;
                    }
                    else
                    {
                        obj.BLC_Sanct_for_Release = Convert.ToDouble(value.Rows[i][33].ToString());
                    }

                    if (value.Rows[i][34].ToString() == "")
                    {
                        obj.ISSR_CA_Released = 0;
                    }
                    else
                    {
                        obj.ISSR_CA_Released = Convert.ToDouble(value.Rows[i][34].ToString());
                    }
                    //AHP_CA_Released BLC_CA_Released ISSR_Balance_for_Release 

                    if (value.Rows[i][35].ToString() == "")
                    {
                        obj.AHP_CA_Released = 0;
                    }
                    else
                    {
                        obj.AHP_CA_Released = Convert.ToDouble(value.Rows[i][35].ToString());
                    }

                    if (value.Rows[i][36].ToString() == "")
                    {
                        obj.BLC_CA_Released = 0;
                    }
                    else
                    {
                        obj.BLC_CA_Released = Convert.ToDouble(value.Rows[i][36].ToString());
                    }

                    if (value.Rows[i][37].ToString() == "")
                    {
                        obj.ISSR_Balance_for_Release = 0;
                    }
                    else
                    {
                        obj.ISSR_Balance_for_Release = Convert.ToDouble(value.Rows[i][37].ToString());
                    }
                    ////AHP_Balance_for_Release BLC_Balance_for_Release 
                    if (value.Rows[i][38].ToString() == "")
                    {
                        obj.AHP_Balance_for_Release = 0;
                    }
                    else
                    {
                        obj.AHP_Balance_for_Release = Convert.ToDouble(value.Rows[i][38].ToString());
                    }

                    if (value.Rows[i][39].ToString() == "")
                    {
                        obj.BLC_Balance_for_Release = 0;
                    }
                    else
                    {
                        obj.BLC_Balance_for_Release = Convert.ToDouble(value.Rows[i][39].ToString());
                    }
                    ///ISSR_Houses_Sanctioned  AHP_Houses_Sanctioned 

                    if (value.Rows[i][40].ToString() == "")
                    {
                        obj.ISSR_Houses_Sanctioned = 0;
                    }
                    else
                    {
                        obj.ISSR_Houses_Sanctioned = Convert.ToDouble(value.Rows[i][40].ToString());
                    }

                    if (value.Rows[i][41].ToString() == "")
                    {
                        obj.AHP_Houses_Sanctioned = 0;
                    }
                    else
                    {
                        obj.AHP_Houses_Sanctioned = Convert.ToDouble(value.Rows[i][41].ToString());
                    }
                    ///BLC_Houses_Sanctioned   ISSR_Grounded AHP_Grounded 

                    if (value.Rows[i][42].ToString() == "")
                    {
                        obj.BLC_Houses_Sanctioned = 0;
                    }
                    else
                    {
                        obj.BLC_Houses_Sanctioned = Convert.ToDouble(value.Rows[i][42].ToString());
                    }

                    if (value.Rows[i][43].ToString() == "")
                    {
                        obj.ISSR_Grounded = 0;
                    }
                    else
                    {
                        obj.ISSR_Grounded = Convert.ToDouble(value.Rows[i][43].ToString());
                    }

                    if (value.Rows[i][44].ToString() == "")
                    {
                        obj.AHP_Grounded = 0;
                    }
                    else
                    {
                        obj.AHP_Grounded = Convert.ToDouble(value.Rows[i][44].ToString());
                    }
                    ///BLC_Grounded ISSR_Completed  AHP_Completed 

                    if (value.Rows[i][45].ToString() == "")
                    {
                        obj.BLC_Grounded = 0;
                    }
                    else
                    {
                        obj.BLC_Grounded = Convert.ToDouble(value.Rows[i][45].ToString());
                    }

                    if (value.Rows[i][46].ToString() == "")
                    {
                        obj.ISSR_Completed = 0;
                    }
                    else
                    {
                        obj.ISSR_Completed = Convert.ToDouble(value.Rows[i][46].ToString());
                    }

                    if (value.Rows[i][47].ToString() == "")
                    {
                        obj.AHP_Completed = 0;
                    }
                    else
                    {
                        obj.AHP_Completed = Convert.ToDouble(value.Rows[i][47].ToString());
                    }
                    ///BLC_Completed   PMAY_Funds_Released 

                    if (value.Rows[i][48].ToString() == "")
                    {
                        obj.BLC_Completed = 0;
                    }
                    else
                    {
                        obj.BLC_Completed = Convert.ToDouble(value.Rows[i][48].ToString());
                    }

                    if (value.Rows[i][49].ToString() == "")
                    {
                        obj.PMAY_Funds_Released = 0;
                    }
                    else
                    {
                        obj.PMAY_Funds_Released = Convert.ToDouble(value.Rows[i][49].ToString());
                    }
                    ///PMAY_Ucs_Received   PMAY_UC_Pending

                    if (value.Rows[i][50].ToString() == "")
                    {
                        obj.PMAY_Ucs_Received = 0;
                    }
                    else
                    {
                        obj.PMAY_Ucs_Received = Convert.ToDouble(value.Rows[i][50].ToString());
                    }

                    if (value.Rows[i][51].ToString() == "")
                    {
                        obj.PMAY_UC_Pending = 0;
                    }
                    else
                    {
                        obj.PMAY_UC_Pending = Convert.ToDouble(value.Rows[i][51].ToString());
                    }

                    ///PMAY_Houses_Occupied    Reforms Reforms_Achieved  

                    if (value.Rows[i][52].ToString() == "")
                    {
                        obj.PMAY_Houses_Occupied = 0;
                    }
                    else
                    {
                        obj.PMAY_Houses_Occupied = Convert.ToDouble(value.Rows[i][52].ToString());
                    }

                    obj.Reforms = value.Rows[i][53].ToString();

                    if (value.Rows[i][54].ToString() == "")
                    {
                        obj.Reforms_Achieved = "0";
                    }
                    else
                    {
                        obj.Reforms_Achieved = value.Rows[i][54].ToString();
                    }

                    ///SLTC_Funds_Released_RsinnCr SLTC_Specialists_Approved   

                    if (value.Rows[i][55].ToString() == "")
                    {
                        obj.SLTC_Funds_Released_RsinnCr = 0;
                    }
                    else
                    {
                        obj.SLTC_Funds_Released_RsinnCr = Convert.ToDouble(value.Rows[i][55].ToString());
                    }

                    if (value.Rows[i][56].ToString() == "-")
                    {
                        obj.SLTC_Specialists_Approved = 0;
                    }
                    else
                    {
                        obj.SLTC_Specialists_Approved = Convert.ToDouble(value.Rows[i][56].ToString());
                    }
                    ///SLTC_Specialists_in_Place CLTC_Funds_Released_RsinCr 

                    if (value.Rows[i][57].ToString() == "-")
                    {
                        obj.SLTC_Specialists_in_Place = 0;
                    }
                    else
                    {
                        obj.SLTC_Specialists_in_Place = Convert.ToDouble(value.Rows[i][57].ToString());
                    }

                    if (value.Rows[i][58].ToString() == "")
                    {
                        obj.CLTC_Funds_Released_RsinCr = 0;
                    }
                    else
                    {
                        obj.CLTC_Funds_Released_RsinCr = Convert.ToDouble(value.Rows[i][58].ToString());
                    }

                    ///CLTC_Specialists_Approved CLTC_Specialists_in_Place  

                    if (value.Rows[i][59].ToString() == "")
                    {
                        obj.CLTC_Specialists_Approved = 0;
                    }
                    else
                    {
                        obj.CLTC_Specialists_Approved = Convert.ToDouble(value.Rows[i][59].ToString());
                    }

                    if (value.Rows[i][60].ToString() == "" || value.Rows[i][60].ToString() == "-")
                    {
                        obj.CLTC_Specialists_in_Place = 0;
                    }
                    else
                    {
                        obj.CLTC_Specialists_in_Place = Convert.ToDouble(value.Rows[i][60].ToString());
                    }
                    ///Projects_Approved Projects_uploaded   

                    if (value.Rows[i][61].ToString() == "" || value.Rows[i][61].ToString() == "-")
                    {
                        obj.Projects_Approved = 0;
                    }
                    else
                    {
                        obj.Projects_Approved = Convert.ToDouble(value.Rows[i][61].ToString());
                    }

                    if (value.Rows[i][62].ToString() == "" || value.Rows[i][62].ToString() == "-")
                    {
                        obj.Projects_uploaded = 0;
                    }
                    else
                    {
                        obj.Projects_uploaded = Convert.ToDouble(value.Rows[i][62].ToString());
                    }
                    ///Percent_Projects_uploaded BLC_Houses_Approved BLC_Houses_Grounded BLC_Houses_Geo_Tagged  
                    ///CLSS_MIS_Survey CLSS_Beneficiaries_EWS_LIG_MIG  CLSS_Subsidy_EWS_LIG_MIG JN_Houses_Sanctioned  
                    ///JN_Houses_Completed JN_Houses_Occupied  JN_Houses_In_Progress JN_Houses_Unoccupied   

                    if (value.Rows[i][63].ToString() == "" || value.Rows[i][63].ToString() == "-")
                    {
                        obj.Percent_Projects_uploaded = 0;
                    }
                    else
                    {
                        obj.Percent_Projects_uploaded = Convert.ToDouble(value.Rows[i][63].ToString());
                    }

                    obj.BLC_Houses_Approved = Convert.ToDouble(value.Rows[i][64].ToString());
                    obj.BLC_Houses_Grounded = Convert.ToDouble(value.Rows[i][65].ToString());
                    obj.BLC_Houses_Geo_Tagged = Convert.ToDouble(value.Rows[i][66].ToString());
                    obj.CLSS_MIS_Survey = Convert.ToDouble(value.Rows[i][67].ToString());

                    obj.CLSS_Beneficiaries_EWS_LIG_MIG = Convert.ToDouble(value.Rows[i][68].ToString());
                    obj.CLSS_Subsidy_EWS_LIG_MIG = Convert.ToDouble(value.Rows[i][69].ToString());
                    obj.JN_Houses_Sanctioned = Convert.ToDouble(value.Rows[i][70].ToString());
                    obj.JN_Houses_Completed = Convert.ToDouble(value.Rows[i][71].ToString());

                    obj.JN_Houses_Occupied = Convert.ToDouble(value.Rows[i][72].ToString());
                    obj.JN_Houses_In_Progress = Convert.ToDouble(value.Rows[i][73].ToString());
                    obj.JN_Houses_Unoccupied = Convert.ToDouble(value.Rows[i][74].ToString());
                    ///JN_Houses_Non_Starter JN_UC_Pending   RAY_Houses_Sanctioned RAY_Houses_Completed    RAY_Houses_Occupied 
                    ///RAY_Houses_In_Progress  RAY_Houses_Unoccupied RAY_Houses_Non_Starter  RAY_UC_Pending Division

                    obj.JN_Houses_Non_Starter = Convert.ToDouble(value.Rows[i][75].ToString());

                    obj.JN_UC_Pending = Convert.ToDouble(value.Rows[i][76].ToString());
                    obj.RAY_Houses_Sanctioned = Convert.ToDouble(value.Rows[i][77].ToString());
                    obj.RAY_Houses_Completed = Convert.ToDouble(value.Rows[i][78].ToString());
                    obj.RAY_Houses_Occupied = Convert.ToDouble(value.Rows[i][79].ToString());

                    obj.RAY_Houses_In_Progress = Convert.ToDouble(value.Rows[i][80].ToString());
                    obj.RAY_Houses_Unoccupied = Convert.ToDouble(value.Rows[i][81].ToString());
                    obj.RAY_Houses_Non_Starter = Convert.ToDouble(value.Rows[i][82].ToString());
                    obj.RAY_UC_Pending = Convert.ToDouble(value.Rows[i][83].ToString());
                    obj.Division = value.Rows[i][84].ToString();

                    lst.Add(obj);
                    objEntity.tblStateWiseScores.Add(obj);
                }
                objEntity.SaveChanges();
            }
            return "upload has been sussessful";
        }
        [HttpPost]
        [Route("UploadExcel_StateScore111111111111")]
        public string Excel_StateScoreUpload()
        {
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<Testtable> lst = new List<Testtable>();
                for (int i = 1; i < value.Rows.Count; i++)
                {
                    Testtable obj = new Testtable();
                    obj.A = value.Rows[i][0].ToString();
                    obj.B = value.Rows[i][1].ToString();
                    obj.C = value.Rows[i][2].ToString(); ;

                    obj.D = value.Rows[i][3].ToString(); ;
                    obj.E = value.Rows[i][4].ToString(); ;
                    lst.Add(obj);
                    objEntity.Testtables.Add(obj);
                }
                objEntity.SaveChanges();
            }
            //kal karte hai nulll ja raha ha
            return "sussess";
        }

        [Route("GetExcelScoreDetails")]
        [HttpGet]
        public IEnumerable<tblStateWiseScoreVM> GetExcelScoreDetails()
        {
            IEnumerable<tblStateWiseScoreVM> objExcel = new List<tblStateWiseScoreVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.tblStateWiseScores.Select(a => new tblStateWiseScoreVM
                {
                    ScoreId = a.ScoreId,
                    StateId = a.StateId,
                    Codes = a.Codes,
                    StateName = a.StateName,
                    Sanction_vs_Demand = a.Sanction_vs_Demand.ToString(),
                    Grounding_Sanction = a.Grounding_Sanction.ToString(),
                    Completion_vs_Sanction = a.Completion_vs_Sanction.ToString(),
                    BLC_Houses_Geotagged = a.BLC_Houses_Geotagged.ToString(),
                    Relelase_vs_Sanction = a.Relelase_vs_Sanction.ToString(),
                    MIS_Annexure_uploading = a.MIS_Annexure_uploading.ToString(),
                    Beneficiary_Attachment = a.Beneficiary_Attachment.ToString(),

                    Reforms_Achievement = a.Reforms_Achievement,
                    JN_Houses_vacant = a.JN_Houses_vacant.ToString(),
                    Population_Census_2011 = a.Population_Census_2011.ToString(),
                    TG_12_Housing_Shortage = a.TG_12_Housing_Shortage.ToString(),
                    Aadhar_Coverage = a.Aadhar_Coverage.ToString(),

                    Cities_included_in_Mission = a.Cities_included_in_Mission.ToString(),
                    Total_Demand_as_per_Road_map = a.Total_Demand_as_per_Road_map.ToString(),
                    Demand_met = a.Demand_met.ToString(),
                    Per_Demand_met = a.Per_Demand_met.ToString(),

                    Total_PMAY_U_Houses_ISSR_AHP_BLC_CLSS = a.Total_PMAY_U_Houses_ISSR_AHP_BLC_CLSS.ToString(),
                    Valid_Aadhar_Beneficiaries = a.Valid_Aadhar_Beneficiaries.ToString(),
                    Bene_Percentage = a.Bene_Percentage.ToString(),
                    HFAPoA_funds_Released = a.HFAPoA_funds_Released.ToString(),
                    HFAPoA_Received = a.HFAPoA_Received.ToString(),

                    HFAPoA_Status = a.HFAPoA_Status,
                    ISSR_NOP = a.ISSR_NOP.ToString(),
                    AHP_NOP = a.AHP_NOP.ToString(),
                    BLC_NOP = a.BLC_NOP.ToString(),

                    ISSR_Sanct_for_Release = a.ISSR_Sanct_for_Release.ToString(),
                    AHP_Sanct_for_Release = a.AHP_Sanct_for_Release.ToString(),
                    BLC_Sanct_for_Release = a.BLC_Sanct_for_Release.ToString(),
                    ISSR_CA_Released = a.ISSR_CA_Released.ToString(),
                    AHP_CA_Released = a.AHP_CA_Released.ToString(),
                    BLC_CA_Released = a.BLC_CA_Released.ToString(),

                    ISSR_Balance_for_Release = a.ISSR_Balance_for_Release.ToString(),
                    AHP_Balance_for_Release = a.AHP_Balance_for_Release.ToString(),
                    BLC_Balance_for_Release = a.BLC_Balance_for_Release.ToString(),
                    ISSR_Houses_Sanctioned = a.ISSR_Houses_Sanctioned.ToString(),
                    AHP_Houses_Sanctioned = a.AHP_Houses_Sanctioned.ToString(),
                    BLC_Houses_Sanctioned = a.BLC_Houses_Sanctioned.ToString(),

                    ISSR_Grounded = a.ISSR_Grounded.ToString(),
                    AHP_Grounded = a.AHP_Grounded.ToString(),
                    BLC_Grounded = a.BLC_Grounded.ToString(),
                    ISSR_Completed = a.ISSR_Completed.ToString(),
                    AHP_Completed = a.AHP_Completed.ToString(),
                    BLC_Completed = a.BLC_Completed.ToString(),

                    PMAY_Funds_Released = a.PMAY_Funds_Released.ToString(),
                    PMAY_Ucs_Received = a.PMAY_Ucs_Received.ToString(),
                    PMAY_UC_Pending = a.PMAY_UC_Pending.ToString(),
                    PMAY_Houses_Occupied = a.PMAY_Houses_Occupied.ToString(),
                    Reforms = a.Reforms,
                    Reforms_Achieved = a.Reforms_Achieved.ToString(),

                    SLTC_Funds_Released_RsinnCr = a.SLTC_Funds_Released_RsinnCr.ToString(),
                    SLTC_Specialists_Approved = a.SLTC_Specialists_Approved.ToString(),
                    SLTC_Specialists_in_Place = a.SLTC_Specialists_in_Place.ToString(),
                    CLTC_Funds_Released_RsinCr = a.CLTC_Funds_Released_RsinCr.ToString(),
                    CLTC_Specialists_Approved = a.CLTC_Specialists_Approved.ToString(),
                    CLTC_Specialists_in_Place = a.CLTC_Specialists_in_Place.ToString(),

                    Projects_Approved = a.Projects_Approved.ToString(),
                    Projects_uploaded = a.Projects_uploaded.ToString(),

                    Percent_Projects_uploaded = a.Percent_Projects_uploaded.ToString(),
                    BLC_Houses_Approved = a.BLC_Houses_Approved.ToString(),
                    BLC_Houses_Grounded = a.BLC_Houses_Grounded.ToString(),
                    BLC_Houses_Geo_Tagged = a.BLC_Houses_Geo_Tagged.ToString(),
                    CLSS_MIS_Survey = a.CLSS_MIS_Survey.ToString(),
                    CLSS_Beneficiaries_EWS_LIG_MIG = a.CLSS_Beneficiaries_EWS_LIG_MIG.ToString(),
                    CLSS_Subsidy_EWS_LIG_MIG = a.CLSS_Subsidy_EWS_LIG_MIG.ToString(),

                    JN_Houses_Sanctioned = a.JN_Houses_Sanctioned.ToString(),
                    JN_Houses_Completed = a.JN_Houses_Completed.ToString(),
                    JN_Houses_Occupied = a.JN_Houses_Occupied.ToString(),
                    JN_Houses_In_Progress = a.JN_Houses_In_Progress.ToString(),
                    JN_Houses_Unoccupied = a.JN_Houses_Unoccupied.ToString(),
                    JN_Houses_Non_Starter = a.JN_Houses_Non_Starter.ToString(),
                    JN_UC_Pending = a.JN_UC_Pending.ToString(),
                    RAY_Houses_Sanctioned = a.RAY_Houses_Sanctioned.ToString(),

                    RAY_Houses_Completed = a.RAY_Houses_Completed.ToString(),
                    RAY_Houses_Occupied = a.RAY_Houses_Occupied.ToString(),
                    RAY_Houses_In_Progress = a.RAY_Houses_In_Progress.ToString(),
                    RAY_Houses_Unoccupied = a.RAY_Houses_Unoccupied.ToString(),
                    RAY_Houses_Non_Starter = a.RAY_Houses_Non_Starter.ToString(),
                    RAY_UC_Pending = a.RAY_UC_Pending.ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objExcel;
        }

        [HttpGet]
        [Route("DeleteExcelScore_Details")]
        public string DeleteExcelScore(string excelId)
        {
            string message = "";
            if (excelId != "")
            {
                int id = Convert.ToInt32(excelId);
                EmployeeEntities objEntity = new EmployeeEntities();
                var data = objEntity.tblStateWiseScores.Find(id);
                objEntity.tblStateWiseScores.Remove(data);
                int i = objEntity.SaveChanges();
                if (i > 0)
                {
                    message = "Record deleted successfully ";
                }
                else
                {
                    message = "Deletion Faild";
                }
            }
            return message;
        }

        [HttpGet]
        [Route("DeleteExcelPD_Details")]
        public string DeleteExcelPD_Details(string excelId)
        {
            string message = "";
            if (excelId != "")
            {
                int id = Convert.ToInt32(excelId);
                EmployeeEntities objEntity = new EmployeeEntities();
                var data = objEntity.Physical_Dashboard.Find(id);
                objEntity.Physical_Dashboard.Remove(data);
                int i = objEntity.SaveChanges();
                if (i > 0)
                {
                    message = "Record deleted successfully ";
                }
                else
                {
                    message = "Deletion Faild";
                }
            }
            return message;
        }
        //----------------------------------------------------------------- 3 StateScore --> tblStateWiseScore


        //-------------------------------------------------------------------------------
        [HttpGet]
        [Route("GetDetailsById")]
        public Testtable ExcelScore(string Id)
        {
            Testtable objTest = new Testtable();

            if (Id != "")
            {
                int id = Convert.ToInt32(Id);
                EmployeeEntities objEntity = new EmployeeEntities();
                objTest = objEntity.Testtables.Where(a => a.id == id).FirstOrDefault();
            }
            return objTest;
        }
        [HttpGet]
        [Route("GetExcelPMAY_ById")]
        public PMAY_PROJECTS_Fin GetExcelPMAY_ById(string SrNo)
        {
            PMAY_PROJECTS_Fin objPmay = new PMAY_PROJECTS_Fin();

            if (SrNo != "")
            {
                int id = Convert.ToInt32(SrNo);
                EmployeeEntities objEntity = new EmployeeEntities();
                objPmay = objEntity.PMAY_PROJECTS_Fin.Where(a => a.SrNo == id).FirstOrDefault();
            }
            return objPmay;
        }

        [HttpPut]
        [Route("UpdateExcelDetails")]
        public bool ExcelScore(Testtable excelfile)
        {
            Testtable objTest = new Testtable();
            EmployeeEntities objEntity = new EmployeeEntities();
            bool status = false;

            var data = objEntity.Testtables.Where(a => a.id == excelfile.id).FirstOrDefault();
            if (data != null)
            {
                data.id = excelfile.id;
                data.A = excelfile.A;
                data.B = excelfile.B;
                data.C = excelfile.C;
                data.D = excelfile.D;
                data.E = excelfile.E;
            }
            int i = objEntity.SaveChanges();
            if (i > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }

        //public IEnumerable<tblStateWiseScoreVM> GetExcelScoreDetails()
        //{
        //    IEnumerable<tblStateWiseScoreVM> objExcel = new List<tblStateWiseScoreVM>();
        //    EmployeeEntities objEntity = new EmployeeEntities();

        //------------------------- PDashboard --------------------------------
        [HttpPost]
        [Route("UploadPDashboard_Excel")] // bulk inset PhysicalDashboard  ****
        public string UploadPDashboard_Excel()
        {  //// PhysicalDashboard bulk insert
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<Physical_Dashboard> lst = new List<Physical_Dashboard>();
                for (int i = 1; i < value.Rows.Count; i++)
                {
                    Physical_Dashboard obj = new Physical_Dashboard();
                    obj.SrNo = Convert.ToInt32(value.Rows[i][0].ToString());
                    if (value.Rows[i][1].ToString().Length == 1)
                    {
                        obj.State1 = Convert.ToString("0" + value.Rows[i][1].ToString());
                    }
                    else
                    {
                        obj.State1 = Convert.ToString(value.Rows[i][1].ToString());
                    }
                    obj.StateCode = value.Rows[i][2].ToString();

                    obj.Demand = Convert.ToDouble(value.Rows[i][3].ToString());
                    obj.Houses_Sanctioned = Convert.ToDouble(value.Rows[i][4].ToString());

                    obj.CentralShare = Convert.ToDouble(value.Rows[i][5].ToString());
                    obj.StateShare = Convert.ToDouble(value.Rows[i][6].ToString());

                    obj.ULBShare = Convert.ToDouble(value.Rows[i][7].ToString());
                    obj.BeneficiaryShare = Convert.ToDouble(value.Rows[i][8].ToString());

                    obj.TotalCost = Convert.ToDouble(value.Rows[i][9].ToString());
                    obj.Grounded = Convert.ToDouble(value.Rows[i][10].ToString());

                    obj.Completed = Convert.ToDouble(value.Rows[i][11].ToString());
                    obj.Occupied = Convert.ToDouble(value.Rows[i][12].ToString());
                    obj.CAApproved = Convert.ToDouble(value.Rows[i][13].ToString());
                    obj.CASanctionedforRelease = Convert.ToDouble(value.Rows[i][14].ToString());

                    obj.CAReleased = Convert.ToDouble(value.Rows[i][15].ToString());
                    obj.PendingforRelease = Convert.ToDouble(value.Rows[i][16].ToString());
                    obj.IIIQ_15_16 = Convert.ToDouble(value.Rows[i][17].ToString());
                    obj.IV_Q_15_16 = Convert.ToDouble(value.Rows[i][18].ToString());

                    obj.IQ_16_17 = Convert.ToDouble(value.Rows[i][19].ToString());
                    obj.IIQ_16_17 = Convert.ToDouble(value.Rows[i][20].ToString());
                    obj.IIIQ_16_17 = Convert.ToDouble(value.Rows[i][21].ToString());
                    obj.IV_Q_16_17 = Convert.ToDouble(value.Rows[i][22].ToString());

                    obj.I_Q_17_18 = Convert.ToDouble(value.Rows[i][23].ToString());
                    obj.II_Q_17_18 = Convert.ToDouble(value.Rows[i][24].ToString());
                    obj.III_Q_17_18 = Convert.ToDouble(value.Rows[i][25].ToString());
                    obj.IV_Q_17_18 = Convert.ToDouble(value.Rows[i][26].ToString());

                    obj.I_Q_18_19 = Convert.ToDouble(value.Rows[i][27].ToString());
                    obj.II_Q_18_19 = Convert.ToDouble(value.Rows[i][28].ToString());
                    obj.III_Q_18_19 = Convert.ToDouble(value.Rows[i][29].ToString());
                    obj.IV_Q_18_19 = Convert.ToDouble(value.Rows[i][30].ToString());

                    obj.I_Q_19_20 = Convert.ToDouble(value.Rows[i][31].ToString());
                    obj.SRNo1 = 0;// Convert.ToDouble(value.Rows[i][32].ToString());
                    obj.State2 = 0;// Convert.ToDouble(value.Rows[i][33].ToString());
                    obj.CumSanctioned = Convert.ToDouble(value.Rows[i][34].ToString());

                    obj.CASanctioned_15_16 = Convert.ToDouble(value.Rows[i][35].ToString());
                    obj.CASanctioned_16_17 = Convert.ToDouble(value.Rows[i][36].ToString());
                    obj.CASanctioned_17_18 = Convert.ToDouble(value.Rows[i][37].ToString());
                    obj.CASanctioned_18_19 = Convert.ToDouble(value.Rows[i][38].ToString());

                    obj.CASanctioned_19_20 = Convert.ToDouble(value.Rows[i][39].ToString());
                    obj.CumuCAReleased = Convert.ToDouble(value.Rows[i][40].ToString());
                    obj.CumuCA_Released_15_16 = Convert.ToDouble(value.Rows[i][41].ToString());
                    obj.CumuCA_Released_16_17 = Convert.ToDouble(value.Rows[i][42].ToString());

                    obj.CumuCA_Released_17_18 = Convert.ToDouble(value.Rows[i][43].ToString());
                    obj.CumuCA_Released_18_19 = Convert.ToDouble(value.Rows[i][44].ToString());
                    obj.CumuCA_Released_19_20 = Convert.ToDouble(value.Rows[i][45].ToString());
                    //   obj.k = "0";// value.Rows[i][46].ToString();
                    //   obj.ll = "0";// value.Rows[i][47].ToString();
                    obj.HS_Cum_20_8_18 = Convert.ToDouble(value.Rows[i][46].ToString());

                    obj.HS_15_16 = Convert.ToDouble(value.Rows[i][47].ToString());
                    obj.HS_16_17 = Convert.ToDouble(value.Rows[i][48].ToString());
                    obj.HS_17_18 = Convert.ToDouble(value.Rows[i][49].ToString());
                    obj.HS_18_19 = Convert.ToDouble(value.Rows[i][50].ToString());
                    obj.HS_19_20 = Convert.ToDouble(value.Rows[i][51].ToString());

                    obj.HC_20_08_18 = Convert.ToDouble(value.Rows[i][52].ToString());
                    obj.HC_14_15 = Convert.ToDouble(value.Rows[i][53].ToString());
                    obj.HC_15_16 = Convert.ToDouble(value.Rows[i][54].ToString());
                    obj.HC_16_17 = Convert.ToDouble(value.Rows[i][55].ToString());
                    obj.HC_17_18 = Convert.ToDouble(value.Rows[i][56].ToString());

                    obj.HC_18_19 = Convert.ToDouble(value.Rows[i][57].ToString());
                    obj.HC_19_20 = Convert.ToDouble(value.Rows[i][58].ToString());
                    obj.HO_Cum = Convert.ToDouble(value.Rows[i][59].ToString());
                    obj.HO_14_15 = Convert.ToDouble(value.Rows[i][60].ToString());
                    obj.HO_15_16 = Convert.ToDouble(value.Rows[i][61].ToString());

                    obj.HO_16_17 = Convert.ToDouble(value.Rows[i][62].ToString());
                    obj.HO_17_18 = Convert.ToDouble(value.Rows[i][63].ToString());
                    obj.HO_18_19 = Convert.ToDouble(value.Rows[i][64].ToString());
                    obj.HO_19_20 = Convert.ToDouble(value.Rows[i][65].ToString());
                    //  obj.F63 = 0; // Convert.ToDouble(value.Rows[i][68].ToString());

                    obj.Expenditure = Convert.ToDouble(value.Rows[i][66].ToString());  // CHANGES
                    obj.Division = value.Rows[i][67].ToString();     // CHANGES
                    lst.Add(obj);
                    objEntity.Physical_Dashboard.Add(obj);
                }
                objEntity.SaveChanges();
            }
            return "sussess";
        }
        [Route("GetPDashboard_ExcelDetails")]
        [HttpGet]
        public IEnumerable<Physical_DashboardVM> GetPDashboard_ExcelDetails()
        {
            IEnumerable<Physical_DashboardVM> objExcel = new List<Physical_DashboardVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.Physical_Dashboard.Select(a => new Physical_DashboardVM
                {
                    //Id = a.sId,
                    SrNo = a.SrNo.ToString(),
                    State1 = a.State1.ToString(),
                    StateCode = a.StateCode,
                    Demand = a.StateCode,
                    Houses_Sanctioned = a.Houses_Sanctioned.ToString(),
                    CentralShare = a.CentralShare.ToString(),
                    StateShare = a.StateShare.ToString(),
                    ULBShare = a.ULBShare.ToString(),
                    BeneficiaryShare = a.BeneficiaryShare.ToString(),
                    TotalCost = a.TotalCost.ToString(),
                    Grounded = a.Grounded.ToString(),
                    Completed = a.Completed.ToString(),
                    Occupied = a.Occupied.ToString(),
                    CAApproved = a.CAApproved.ToString(),
                    CASanctionedforRelease = a.CASanctionedforRelease.ToString(),
                    CAReleased = a.CAReleased.ToString(),
                    PendingforRelease = a.PendingforRelease.ToString(),
                    IIIQ_15_16 = a.IIIQ_15_16.ToString(),
                    IV_Q_15_16 = a.IV_Q_15_16.ToString(),
                    IQ_16_17 = a.IQ_16_17.ToString(),
                    IIQ_16_17 = a.IIQ_16_17.ToString(),
                    IIIQ_16_17 = a.IIIQ_16_17.ToString(),
                    IV_Q_16_17 = a.IV_Q_16_17.ToString(),
                    I_Q_17_18 = a.I_Q_17_18.ToString(),
                    II_Q_17_18 = a.II_Q_17_18.ToString(),
                    III_Q_17_18 = a.III_Q_17_18.ToString(),
                    IV_Q_17_18 = a.IV_Q_17_18.ToString(),
                    I_Q_18_19 = a.I_Q_18_19.ToString(),
                    II_Q_18_19 = a.II_Q_18_19.ToString(),
                    III_Q_18_19 = a.III_Q_18_19.ToString(),
                    IV_Q_18_19 = a.IV_Q_18_19.ToString(),
                    I_Q_19_20 = a.I_Q_19_20.ToString(),
                    SRNo1 = a.SRNo1.ToString(),
                    State2 = a.State2.ToString(),
                    CumSanctioned = a.CumSanctioned.ToString(),
                    CASanctioned_15_16 = a.CASanctioned_15_16.ToString(),
                    CASanctioned_16_17 = a.CASanctioned_16_17.ToString(),
                    CASanctioned_17_18 = a.CASanctioned_17_18.ToString(),
                    CASanctioned_18_19 = a.CASanctioned_18_19.ToString(),
                    CASanctioned_19_20 = a.CASanctioned_19_20.ToString(),
                    CumuCAReleased = a.CumuCAReleased.ToString(),
                    CumuCA_Released_15_16 = a.CumuCA_Released_15_16.ToString(),
                    CumuCA_Released_16_17 = a.CumuCA_Released_16_17.ToString(),
                    CumuCA_Released_17_18 = a.CumuCA_Released_17_18.ToString(),
                    CumuCA_Released_18_19 = a.CumuCA_Released_18_19.ToString(),
                    CumuCA_Released_19_20 = a.CumuCA_Released_19_20.ToString(),
                    //   k =a.k,
                    //   ll =a.ll,
                    HS_Cum_20_8_18 = a.HS_Cum_20_8_18.ToString(),
                    HS_15_16 = a.HS_15_16.ToString(),
                    HS_16_17 = a.HS_16_17.ToString(),
                    HS_17_18 = a.HS_17_18.ToString(),
                    HS_18_19 = a.HS_18_19.ToString(),
                    HS_19_20 = a.HS_19_20.ToString(),
                    HC_20_08_18 = a.HC_20_08_18.ToString(),
                    HC_14_15 = a.HC_14_15.ToString(),
                    HC_15_16 = a.HC_15_16.ToString(),
                    HC_16_17 = a.HC_16_17.ToString(),
                    HC_17_18 = a.HC_17_18.ToString(),
                    HC_18_19 = a.HC_18_19.ToString(),
                    HC_19_20 = a.HC_19_20.ToString(),
                    HO_Cum = a.HO_Cum.ToString(),
                    HO_14_15 = a.HO_14_15.ToString(),
                    HO_15_16 = a.HO_15_16.ToString(),
                    HO_16_17 = a.HO_16_17.ToString(),
                    HO_17_18 = a.HO_17_18.ToString(),
                    HO_18_19 = a.HO_18_19.ToString(),
                    HO_19_20 = a.HO_19_20.ToString(),
                    //   F63 = a.F63.ToString(),
                    Expenditure = a.Expenditure.ToString(),
                    Division = a.Division.ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objExcel;
        }
        //------------------------- PDashboard --------------------------------

        //------------------Excel Deamnd City Details-----------------------------------------
        [HttpPost]
        [Route("UploadExcelDemandCityWise")] // bulk inset DemandCityWise *****
        public string UploadExcelDemandCityWise()
        {  //// testTable bulk insert
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<DemandCityWise> lst = new List<DemandCityWise>();
                for (int i = 1; i < value.Rows.Count; i++)
                {
                    DemandCityWise obj = new DemandCityWise();
                    obj.SrNo = Convert.ToInt32(value.Rows[i][0].ToString());
                    obj.State_Name = value.Rows[i][1].ToString();
                    obj.State_Code = (value.Rows[i][2].ToString());//float.Parse 

                    obj.District_Name = value.Rows[i][3].ToString(); ;
                    obj.District_Code = (value.Rows[i][4].ToString()); //float.Parse
                    obj.CITY_Name = value.Rows[i][5].ToString();
                    obj.City_Code = (value.Rows[i][6].ToString());//float.Parse
                    obj.ISSR = float.Parse(value.Rows[i][7].ToString());
                    obj.AHP = float.Parse(value.Rows[i][8].ToString());
                    obj.BLC = float.Parse(value.Rows[i][9].ToString());
                    obj.CLSS = float.Parse(value.Rows[i][10].ToString());
                    obj.demand = float.Parse(value.Rows[i][11].ToString());
                    obj.Cid = 0;
                    lst.Add(obj);
                    objEntity.DemandCityWises.Add(obj);
                }
                objEntity.SaveChanges();
            }
            return "Success";
        }
        [Route("GetDemandCityDetails")]
        [HttpGet]
        public IEnumerable<DemandCityWiseVM> GetDemandCityDetails()
        {
            IEnumerable<DemandCityWiseVM> objExcel = new List<DemandCityWiseVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.DemandCityWises.Select(a => new DemandCityWiseVM
                {
                    SrNo = a.SrNo.ToString(),
                    State_Name = a.State_Name,
                    State_Code = a.State_Code.ToString(),
                    District_Name = a.District_Name,
                    District_Code = a.District_Code.ToString(),
                    CITY_Name = a.CITY_Name.ToString(),
                    City_Code = a.City_Code.ToString(),
                    ISSR = a.ISSR.ToString(),
                    AHP = a.AHP.ToString(),
                    BLC = a.BLC.ToString(),
                    CLSS = a.CLSS.ToString(),
                    demand = a.demand.ToString(),
                    Cid = a.Cid,
                    Division = a.Division,
                }).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objExcel;
        }

        [HttpGet]
        [Route("DeleteExcelDemandCity_Details")]
        public string DeleteExcelDemandCity_Details(string excelId)
        {
            string message = "";
            if (excelId != "")
            {
                int id = Convert.ToInt32(excelId);
                EmployeeEntities objEntity = new EmployeeEntities();
                var data = objEntity.DemandCityWises.Find(id);
                objEntity.DemandCityWises.Remove(data);
                int i = objEntity.SaveChanges();
                if (i > 0)
                {
                    message = "Record deleted successfully ";
                }
                else
                {
                    message = "Deletion Faild";
                }
            }
            return message;
        }


        //--------------------------------------------------------------------------
        [Route("GetCLSS_MainMaster_ExcelVM")]
        [HttpGet]
        public IEnumerable<CLSS_MainMasterVM> GetCLSS_MainMasterVM()
        {
            IEnumerable<CLSS_MainMasterVM> objExcel = new List<CLSS_MainMasterVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.CLSS_MainMaster.Select(a => new CLSS_MainMasterVM
                {
                    // Id = a.Id.ToString(),
                    SrNo = a.SrNo.ToString(),
                    state_Name = a.state_Name,
                    State_Code = a.State_Code.ToString(),
                    District_Name = a.District_Name.ToString(),
                    Dcode = a.Dcode.ToString(),
                    City_Name = a.City_Name.ToString(),
                    CityCode = a.CityCode.ToString(),
                    EWS_Bene = a.EWS_Bene.ToString(),
                    EWS_Loan_Amt = a.EWS_Loan_Amt.ToString(),

                    EWS_Subsidy = a.EWS_Subsidy.ToString(),
                    LIG_Bene = a.LIG_Bene.ToString(),
                    LIG_Loan_Amt = a.LIG_Loan_Amt.ToString(),
                    LIG_Subsidy = a.LIG_Subsidy.ToString(),
                    MIG1_Bene = a.MIG1_Bene.ToString(),
                    MIG1_Loan_Amt = a.MIG1_Loan_Amt.ToString(),
                    MIG1_SubsidyAmt = a.MIG1_SubsidyAmt.ToString(),

                    MIG2_Bene = a.MIG2_Bene.ToString(),
                    MIG2_Loan_Am = a.MIG2_Loan_Am.ToString(),
                    MIG2_SubsidyAmt = a.MIG2_SubsidyAmt.ToString(),
                    Total_LoanAmt = a.Total_LoanAmt.ToString(),
                    Total_SubsidyAmt = a.Total_SubsidyAmt.ToString(),
                    Total_Beneficiaries = a.Total_Beneficiaries.ToString(),
                    Cid = a.Cid.ToString(),
                }).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objExcel;
        }

        [HttpPost]
        [Route("UploadCLSS_MainMaster_Excel")] // bulk inset DemandCityWise *****
        public string UploadCLSS_MainMaster_Excel()
        {  //// testTable bulk insert
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<CLSS_MainMaster> lst = new List<CLSS_MainMaster>();
                for (int i = 1; i < value.Rows.Count; i++)
                {
                    CLSS_MainMaster obj = new CLSS_MainMaster();
                    obj.SrNo = Convert.ToInt32(value.Rows[i][0].ToString());
                    obj.state_Name = value.Rows[i][1].ToString();
                    obj.State_Code = double.Parse(value.Rows[i][2].ToString());
                    obj.District_Name = value.Rows[i][3].ToString();
                    obj.Dcode = double.Parse(value.Rows[i][4].ToString());

                    obj.City_Name = value.Rows[i][5].ToString();
                    obj.CityCode = float.Parse(value.Rows[i][6].ToString());
                    obj.EWS_Bene = float.Parse(value.Rows[i][7].ToString());
                    obj.EWS_Loan_Amt = float.Parse(value.Rows[i][8].ToString());
                    obj.EWS_Subsidy = float.Parse(value.Rows[i][9].ToString());
                    obj.LIG_Bene = float.Parse(value.Rows[i][10].ToString());


                    obj.LIG_Loan_Amt = float.Parse(value.Rows[i][11].ToString());
                    obj.LIG_Subsidy = float.Parse(value.Rows[i][12].ToString());
                    obj.MIG1_Bene = float.Parse(value.Rows[i][13].ToString());
                    obj.MIG1_Loan_Amt = float.Parse(value.Rows[i][14].ToString());

                    obj.MIG1_SubsidyAmt = float.Parse(value.Rows[i][15].ToString());
                    obj.MIG2_Bene = float.Parse(value.Rows[i][16].ToString());
                    obj.MIG2_Loan_Am = float.Parse(value.Rows[i][17].ToString());
                    obj.MIG2_SubsidyAmt = float.Parse(value.Rows[i][18].ToString());

                    obj.Total_LoanAmt = float.Parse(value.Rows[i][19].ToString());
                    obj.Total_SubsidyAmt = float.Parse(value.Rows[i][20].ToString());
                    obj.Total_Beneficiaries = float.Parse(value.Rows[i][21].ToString());
                    if (value.Rows[i][22].ToString() == "" || value.Rows[i][22].ToString() == null)
                    {
                        obj.Cid = 0;
                    }
                    else
                        obj.Cid = Int32.Parse(value.Rows[i][22].ToString());

                    obj.Division = value.Rows[i][23].ToString();
                    lst.Add(obj);
                    objEntity.CLSS_MainMaster.Add(obj);
                }
                objEntity.SaveChanges();
            }
            return "sussess";
        }

        [HttpGet]
        [Route("DeleteExcelCLSSMainCity_Details")]
        public string DeleteExcelCLSSMainCity_Details(string excelId)
        {
            string message = "";
            if (excelId != "")
            {
                int id = Convert.ToInt32(excelId);
                EmployeeEntities objEntity = new EmployeeEntities();
                var data = objEntity.CLSS_MainMaster.Find(id);
                objEntity.CLSS_MainMaster.Remove(data);
                int i = objEntity.SaveChanges();
                if (i > 0)
                {
                    message = "Record deleted successfully ";
                }
                else
                {
                    message = "Deletion Faild";
                }
            }
            return message;
        }
        //--------------------------------------------------------------------------

        //[HttpGet]
        //[Route("DeleteExcelStateScore_Details")]
        //public string DeleteExcelStateScore_Details(string excelId)
        //{
        //    string message = "";
        //    if (excelId != "")
        //    {
        //        int id = Convert.ToInt32(excelId);
        //        EmployeeEntities objEntity = new EmployeeEntities();
        //        var data = objEntity.tblStateWiseScoreExcels.Find(id);
        //        objEntity.tblStateWiseScoreExcels.Remove(data);
        //        int i = objEntity.SaveChanges();
        //        if (i > 0)
        //        {
        //            message = "Record deleted successfully ";
        //        }
        //        else
        //        {
        //            message = "Deletion Faild";
        //        }
        //    }
        //    return message;
        //}

        // PMAY
        [Route("GetExcelPMAYDetails")]
        [HttpGet]
        public IEnumerable<PMAY_PROJECTS_FinVM> GetExcelPMAYDetails()
        {
            IEnumerable<PMAY_PROJECTS_FinVM> objExcel = new List<PMAY_PROJECTS_FinVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.PMAY_PROJECTS_Fin.Select(a => new PMAY_PROJECTS_FinVM
                {
                    SrNo = a.SrNo.ToString(),
                    Project_Code = a.Project_Code,
                    Annexure_ID = a.Annexure_ID,
                    Component = a.Component,
                    State = a.State.ToString(),
                    District = a.District.ToString(),
                    City = a.City.ToString(),
                    StateCode = a.StateCode.ToString(),
                    Dcode = a.Dcode.ToString(),
                    sunDisttCode = a.sunDisttCode.ToString(),
                    CityCode = a.CityCode.ToString(),

                    Project_Name = a.Project_Name,
                    CSMCDate = a.CSMCDate.ToString(),
                    CSMCNo = a.CSMCNo.ToString(),
                    FinYear = a.FinYear.ToString(),
                    NoofProjects = a.NoofProjects.ToString(),

                    Project_Cost = a.Project_Cost.ToString(),
                    Central_Assistance_involved = a.Central_Assistance_involved.ToString(),
                    State_Grant = a.State_Grant.ToString(),
                    ULBShare = a.ULBShare.ToString(),

                    BeneficiaryShare = a.BeneficiaryShare.ToString(),
                    Released_throug_EBR = a.Released_throug_EBR.ToString(),
                    CASanctionedForRel = a.CASanctionedForRel.ToString(),
                    FirstInstallmentReleased = a.FirstInstallmentReleased.ToString(),
                    SecondInstallmentReleased = a.SecondInstallmentReleased.ToString(),

                    ThirdInstallmentReleased = a.ThirdInstallmentReleased.ToString(),
                    CentralAssistanceReleased = a.CentralAssistanceReleased.ToString(),
                    UC_Received = a.UC_Received.ToString(),
                    UC_Pending = a.UC_Pending.ToString(),

                    Housesinvolved = a.Housesinvolved.ToString(),
                    FundsDisbursed_in_Houses = a.FundsDisbursed_in_Houses.ToString(),
                    Houses_Grounded = a.Houses_Grounded.ToString(),
                    HousesUnderProgress = a.HousesUnderProgress.ToString(),
                    Houses_Completed = a.Houses_Completed.ToString(),
                    HousesAllotted = a.HousesAllotted.ToString(),

                    HousesOccupied = a.HousesOccupied.ToString(),
                    Houses_yetto_Grounded = a.Houses_yetto_Grounded.ToString(),
                    Cid = "0"//a.Cid.ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objExcel;
        }
        [HttpPost]
        [Route("UploadPMay_Excel")] // bulk inset PhysicalDashboard  ****
        public string UploadPMay_Excel()
        {  //// PhysicalDashboard bulk insert
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<PMAY_PROJECTS_Fin> lst = new List<PMAY_PROJECTS_Fin>();

                try
                {
                    //9500
                    for (int i = 1; i < value.Rows.Count; i++)//value.Rows.Count - value.Rows.Count  9310
                    {
                        PMAY_PROJECTS_Fin obj = new PMAY_PROJECTS_Fin();
                        //  obj.SrNo = Convert.ToUInt32(value.Rows[i][0].ToString());
                        obj.Project_Code = value.Rows[i][1].ToString();
                        obj.Annexure_ID = value.Rows[i][2].ToString();

                        obj.Component = value.Rows[i][3].ToString();
                        obj.State = value.Rows[i][4].ToString();

                        obj.District = value.Rows[i][5].ToString();
                        obj.City = value.Rows[i][6].ToString();

                        obj.StateCode = value.Rows[i][7].ToString();
                        obj.Dcode = value.Rows[i][8].ToString();

                        obj.sunDisttCode = value.Rows[i][9].ToString();
                        obj.CityCode = value.Rows[i][10].ToString();
                        //if (value.Rows[i][11].ToString() != "")
                        //{
                           //  obj.Project_Name = "Nil";
                        //}
                        //else
                        //{
                        string projectName= value.Rows[i][11].ToString();
                        if(projectName.Length > 250)
                        {
                            string myString = projectName.Substring(0, 250);

                            int index = myString.LastIndexOf(' ');

                            obj.Project_Name = myString.Substring(0, index);
                        }
                        else
                        {
                            obj.Project_Name = projectName;
                        }
                 
                       

                        //.Substring(0,100);
                        //}20-01-2014 00:00:00

                        string strDt1 = value.Rows[i][12].ToString().Substring(0,10);
                        string[] strDt = strDt1.ToString().Split('-');
                        string strDate = strDt[1] + "-" + strDt[0] + "-" + strDt[2];
                        obj.CSMCDate = strDate; 

                        if (value.Rows[i][13].ToString() == "")
                        {
                            obj.CSMCNo = "0";
                        }
                        else
                        {
                            obj.CSMCNo = (value.Rows[i][13].ToString()); //Convert.ToDouble
                        }
                        obj.FinYear = value.Rows[i][14].ToString();

                        if (value.Rows[i][15].ToString() == "")
                        {
                            obj.NoofProjects = 0;
                        }
                        else
                        {
                            obj.NoofProjects = Convert.ToDouble(value.Rows[i][15].ToString());
                        }

                        if (value.Rows[i][16].ToString() == "")
                        {
                            obj.Project_Cost = 0;
                        }
                        else
                        {
                            obj.Project_Cost = Convert.ToDouble(value.Rows[i][16].ToString());
                        }

                        if (value.Rows[i][17].ToString() == "")
                        {
                            obj.Central_Assistance_involved = 0;
                        }
                        else
                        {
                            obj.Central_Assistance_involved = Convert.ToDouble(value.Rows[i][17].ToString());
                        }

                        if (value.Rows[i][18].ToString() == "")
                        {
                            obj.State_Grant = 0;
                        }
                        else
                        {
                            obj.State_Grant = Convert.ToDouble(value.Rows[i][18].ToString());
                        }

                        if (value.Rows[i][19].ToString() == "")
                        {
                            obj.ULBShare = 0;
                        }
                        else
                        {
                            obj.ULBShare = Convert.ToDouble(value.Rows[i][19].ToString());
                        }


                        if (value.Rows[i][20].ToString() == "")
                        {
                            obj.BeneficiaryShare = 0;
                        }
                        else
                        {
                            obj.BeneficiaryShare = Convert.ToDouble(value.Rows[i][20].ToString());
                        }

                        if (value.Rows[i][21].ToString() == "")
                        {
                            obj.Released_throug_EBR = 0;
                        }
                        else
                        {
                            obj.Released_throug_EBR = Convert.ToDouble(value.Rows[i][21].ToString());
                        }

                        if (value.Rows[i][22].ToString() == "")
                        {
                            obj.CASanctionedForRel = 0;
                        }
                        else
                        {
                            obj.CASanctionedForRel = Convert.ToDouble(value.Rows[i][22].ToString());
                        }

                        if (value.Rows[i][23].ToString() == "")
                        {
                            obj.FirstInstallmentReleased = 0;
                        }
                        else
                        {
                            obj.FirstInstallmentReleased = Convert.ToDouble(value.Rows[i][23].ToString());
                        }


                        if (value.Rows[i][24].ToString() == "")
                        {
                            obj.SecondInstallmentReleased = 0;
                        }
                        else
                        {
                            obj.SecondInstallmentReleased = Convert.ToDouble(value.Rows[i][24].ToString());
                        }

                        if (value.Rows[i][25].ToString() == "")
                        {
                            obj.ThirdInstallmentReleased = 0;
                        }
                        else
                        {
                            obj.ThirdInstallmentReleased = Convert.ToDouble(value.Rows[i][25].ToString());
                        }

                        if (value.Rows[i][26].ToString() == "")
                        {
                            obj.CentralAssistanceReleased = 0;
                        }
                        else
                        {
                            obj.CentralAssistanceReleased = Convert.ToDouble(value.Rows[i][26].ToString());
                        }

                        if (value.Rows[i][27].ToString() == "")
                        {
                            obj.UC_Received = 0;
                        }
                        else
                        {
                            obj.UC_Received = Convert.ToDouble(value.Rows[i][27].ToString());
                        }

                        if (value.Rows[i][28].ToString() == "")
                        {
                            obj.UC_Pending = 0;
                        }
                        else
                        {
                            obj.UC_Pending = Convert.ToDouble(value.Rows[i][28].ToString());
                        }

                        if (value.Rows[i][29].ToString() == "")
                        {
                            obj.Housesinvolved = 0;
                        }
                        else
                        {
                            obj.Housesinvolved = Convert.ToDouble(value.Rows[i][29].ToString());
                        }
                        if (value.Rows[i][30].ToString() == "")
                        {
                            obj.FundsDisbursed_in_Houses = 0;
                        }
                        else
                        {
                            obj.FundsDisbursed_in_Houses = Convert.ToDouble(value.Rows[i][30].ToString());
                        }

                        if (value.Rows[i][31].ToString() == "")
                        {
                            obj.Houses_Grounded = 0;
                        }
                        else
                        {
                            obj.Houses_Grounded = Convert.ToDouble(value.Rows[i][31].ToString());
                        }

                        if (value.Rows[i][32].ToString() == "")
                        {
                            obj.HousesUnderProgress = 0;
                        }
                        else
                        {
                            obj.HousesUnderProgress = Convert.ToDouble(value.Rows[i][32].ToString());
                        }
                        if (value.Rows[i][33].ToString() == "")
                        {
                            obj.Houses_Completed = 0;
                        }
                        else
                        {
                            obj.Houses_Completed = Convert.ToDouble(value.Rows[i][33].ToString());
                        }

                        if (value.Rows[i][34].ToString() == "")
                        {
                            obj.HousesAllotted = 0;
                        }
                        else
                        {
                            obj.HousesAllotted = Convert.ToDouble(value.Rows[i][34].ToString());
                        }

                        if (value.Rows[i][35].ToString() == "")
                        {
                            obj.HousesOccupied = 0;
                        }
                        else
                        {
                            obj.HousesOccupied = Convert.ToDouble(value.Rows[i][35].ToString());
                        }

                        if (value.Rows[i][36].ToString() == "")
                        {
                            obj.Houses_yetto_Grounded = 0;
                        }
                        else
                        {
                            obj.Houses_yetto_Grounded = Convert.ToDouble(value.Rows[i][36].ToString());
                        }

                        if (value.Rows[i][37].ToString() == "" || value.Rows[i][37].ToString() == null)
                        {
                            if (value.Rows[i][3].ToString() == "ISSR")
                            {
                                obj.Cid = "1";
                            }
                            else if (value.Rows[i][3].ToString() == "BLCS")
                            {
                                obj.Cid = "2";
                            }
                            else if (value.Rows[i][3].ToString() == "RAY" || value.Rows[i][3].ToString() == "RAY_AHP")
                            {
                                obj.Cid = "3";
                            }
                            else if (value.Rows[i][3].ToString() == "AHP")
                            {
                                obj.Cid = "4";
                            }
                            else
                                obj.Cid = "0";
                        }
                        else
                        {
                            obj.Cid = (value.Rows[i][37].ToString());//Convert.ToInt32
                        }

                        if (value.Rows[i][38].ToString() != "")
                        {
                            obj.DIVISION = value.Rows[i][38].ToString();
                        }
                        else
                        {
                            if (Int32.Parse(value.Rows[i][7].ToString()) == 35 || Int32.Parse(value.Rows[i][7].ToString()) == 12 || Int32.Parse(value.Rows[i][7].ToString()) == 18 || Int32.Parse(value.Rows[i][7].ToString()) == 10 || Int32.Parse(value.Rows[i][7].ToString()) == 4 || Int32.Parse(value.Rows[i][7].ToString()) == 26 || Int32.Parse(value.Rows[i][7].ToString()) == 25 ||
                                Int32.Parse(value.Rows[i][7].ToString()) == 7 || Int32.Parse(value.Rows[i][7].ToString()) == 20 || Int32.Parse(value.Rows[i][7].ToString()) == 31 || Int32.Parse(value.Rows[i][7].ToString()) == 14 || Int32.Parse(value.Rows[i][7].ToString()) == 17 || Int32.Parse(value.Rows[i][7].ToString()) == 15 ||
                                Int32.Parse(value.Rows[i][7].ToString()) == 13 || Int32.Parse(value.Rows[i][7].ToString()) == 34 || Int32.Parse(value.Rows[i][7].ToString()) == 11 || Int32.Parse(value.Rows[i][7].ToString()) == 16)
                            {
                                obj.DIVISION = "HFA-5";
                            }
                            else if (Int32.Parse(value.Rows[i][7].ToString()) == 28 || Int32.Parse(value.Rows[i][7].ToString()) == 29 || Int32.Parse(value.Rows[i][7].ToString()) == 32 || Int32.Parse(value.Rows[i][7].ToString()) == 21 ||
                                Int32.Parse(value.Rows[i][7].ToString()) == 33 || Int32.Parse(value.Rows[i][7].ToString()) == 36 || Int32.Parse(value.Rows[i][7].ToString()) == 19)
                            {

                                obj.DIVISION = "HFA-3";
                            }
                            else if (Int32.Parse(value.Rows[i][7].ToString()) == 22 || Int32.Parse(value.Rows[i][7].ToString()) == 6 || Int32.Parse(value.Rows[i][7].ToString()) == 2 || Int32.Parse(value.Rows[i][7].ToString()) == 1 ||
                                Int32.Parse(value.Rows[i][7].ToString()) == 6 || Int32.Parse(value.Rows[i][7].ToString()) == 2 || Int32.Parse(value.Rows[i][7].ToString()) == 1 || Int32.Parse(value.Rows[i][7].ToString()) == 23
                                || Int32.Parse(value.Rows[i][7].ToString()) == 3 || Int32.Parse(value.Rows[i][7].ToString()) == 8 || Int32.Parse(value.Rows[i][7].ToString()) == 9 || Int32.Parse(value.Rows[i][7].ToString()) == 5)
                            {
                                obj.DIVISION = "HFA-1";
                            }
                            else if (Int32.Parse(value.Rows[i][7].ToString()) == 30 || Int32.Parse(value.Rows[i][7].ToString()) == 24 || Int32.Parse(value.Rows[i][7].ToString()) == 27)
                            {
                                obj.DIVISION = "HFA-4";
                            }
                        }

                        //if (value.Rows[i][39].ToString() == "")
                        //{
                        //    obj.FundsDisbursed_in_Houses_II = 0;
                        //}
                        //else
                        //{
                        //    obj.FundsDisbursed_in_Houses_II = Convert.ToDouble(value.Rows[i][39].ToString());
                        //}

                        //if (value.Rows[i][40].ToString() == "")
                        //{
                        //    obj.FundsDisbursed_in_Houses_III = 0;
                        //}
                        //else
                        //{
                        //    obj.FundsDisbursed_in_Houses_III = Convert.ToDouble(value.Rows[i][40].ToString());
                        //}
                        
    



                        lst.Add(obj);
                        objEntity.PMAY_PROJECTS_Fin.Add(obj);

                    }


                    objEntity.SaveChanges();
                }
                catch (Exception ee )
                {
                     String S = ee.Message ;
                }
                finally { }
            }
            return "sussess";

        }

        //---------------------------------------------------------------------------------



        // JNNURM 
        [Route("GetExcelJNNURM_Details")]
        [HttpGet]
        public IEnumerable<JnNURM_TableVM> GetExcelJNNURM_Details()
        {
            IEnumerable<JnNURM_TableVM> objExcel = new List<JnNURM_TableVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.JnNURM_Master.Select(a => new JnNURM_TableVM
                {
                    SrNo = a.SrNo.ToString(),
                    Project_Code = a.Project_Code,
                    State = a.State,
                    Scheme = a.Scheme,
                    Distt = a.Distt,
                    CityTown = a.CityTown,
                    State_Code = a.State_Code,
                    DisttCode = a.DisttCode,
                    SubDisttCode = a.SubDisttCode,
                    TownCode = a.TownCode,
                    Project_Title = a.Project_Title,
                    App_Date = a.App_Date.ToString().Substring(0, 10),//  28-09-2006 00:00:00	
                    Cancelled_Date = a.Cancelled_Date,
                    O_ProjectCost = a.O_ProjectCost.ToString(),
                    O_CentrallShare = a.O_CentrallShare.ToString(),
                    O_DwellingUnit = a.O_DwellingUnit.ToString(),
                    ProjCost = a.ProjCost.ToString(),
                    Central_Share = a.Central_Share.ToString(),
                    DwellingUnit = a.DwellingUnit.ToString(),
                    Central_Share_Released_Projects = a.Central_Share_Released_Projects.ToString(),
                    Central_Share_Adjusted = a.Central_Share_Adjusted.ToString(),
                    Excess_ACA_Released = a.Excess_ACA_Released.ToString(),
                    CentralShareRefundedbyStateGovt = a.CentralShareRefundedbyStateGovt.ToString(),
                    UC_Received = a.UC_Received.ToString(),
                    Pending_UC = a.Pending_UC.ToString(),
                    Under_Progress = a.Under_Progress.ToString(),
                    Completed = a.Completed.ToString(),
                    Allotted = a.Allotted.ToString(),
                    Occupied = a.Occupied.ToString(),
                    UnOccupied = a.UnOccupied.ToString(),
                    NonStarter = a.NonStarter.ToString(),
                    Grounded = a.Grounded.ToString(),
                    Completed1 = a.Completed1.ToString(),
                    Occupied1 = a.Occupied1.ToString(),
                    Division = a.Division.ToString(),

                }).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objExcel;
        }

        //-----------------
        // JNNURM 
        [Route("GetExcelClssMaster_Details")]
        [HttpGet]  
        public IEnumerable<ClssMasterNewVM> GetExcelClssMaster_Details()
        {
            IEnumerable<ClssMasterNewVM> objExcel = new List<ClssMasterNewVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.CLSS_MAster.Select(a => new ClssMasterNewVM
                {
                    SrNo = a.SrNo.ToString(),
                    State = a.State,
                    StateCode =  a.StateCode.ToString()  ,
                    Loan_EWS_LIG =a.Loan_EWS_LIG.ToString(),
                    Subsidy_EWS_LIG = a.Subsidy_EWS_LIG.ToString(),
                    No_Beneficiary_EWS_LIG = a.No_Beneficiary_EWS_LIG.ToString(),
                    Loan_MIG = a.Loan_MIG.ToString(),
                    Subsidy_MIG = a.Subsidy_MIG.ToString(),
                    No_Beneficiary_MIG = a.No_Beneficiary_MIG.ToString(),
                    Loan_TOTAL_14_15 = a.Loan_TOTAL_14_15.ToString(),
                    Loan_TOTAL_15_16 = a.Loan_TOTAL_15_16.ToString(),

                    Loan_TOTAL_16_17 =a.Loan_TOTAL_16_17.ToString(),
                    Loan_TOTAL_17_18 =a.Loan_TOTAL_17_18.ToString(),
                    Loan_TOTAL_18_19 =a.Loan_TOTAL_18_19.ToString(),
                    Loan_TOTAL_19_20 =a.Loan_TOTAL_19_20.ToString(),


                    Loan_TOTAL_20_21 = a.Loan_TOTAL_20_21.ToString(),
                    Loan_TOTAL_21_22 = a.Loan_TOTAL_21_22.ToString(),
                    Loan_TOTAL = a.Loan_TOTAL.ToString(),


                    Subsidy_Total = a.Subsidy_Total.ToString(),
                    NoBeneficiary_Total = a.NoBeneficiary_Total.ToString(),
                    Bene2014_15 = a.Bene2014_15.ToString(),
                    Bene2015_16 = a.Bene2015_16.ToString(),
                    Bene2016_17 = a.Bene2016_17.ToString(),
                    Bene2017_18 = a.Bene2017_18.ToString(),
                    Bene2018_19 = a.Bene2018_19.ToString(),
                    Bene2019_20 = a.Bene2019_20.ToString(),



                    Bene2020_21 = a.Bene2020_21.ToString(),
                    Bene2021_22 = a.Bene2021_22.ToString(),
                    Subsidy2014_15 = a.Subsidy2014_15.ToString(),
                    Subsidy2015_16 = a.Subsidy2015_16.ToString(),
                    Subsidy2016_17 = a.Subsidy2016_17.ToString(),
                    Subsidy2017_18 = a.Subsidy2017_18.ToString(),
                    Subsidy2018_19 = a.Subsidy2018_19.ToString(),
                    Subsidy2019_20 = a.Subsidy2019_20.ToString(),
                    Subsidy20_21 = a.Subsidy20_21.ToString(),
                    Subsidy21_22 = a.Subsidy21_22.ToString(),
                    Division = a.Division.ToString().ToString(),
                }).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objExcel;
        }


        [HttpPost]
        [Route("UploadCLSS_Masternew_Excel")] // bulk inset UploadCLSS_Masternew_Excel  ****
        public string UploadCLSS_Masternew_Excel()
        {  //// PhysicalDashboard bulk insert
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<CLSS_MAster> lst = new List<CLSS_MAster>();

                try
                {
                    //9500
                    for (int i = 1; i < value.Rows.Count; i++)//value.Rows.Count - value.Rows.Count  9310
                    {
                        CLSS_MAster obj = new CLSS_MAster();
                        obj.SrNo = Convert.ToUInt32(value.Rows[i][0].ToString());
                        obj.State = value.Rows[i][1].ToString();
                        obj.StateCode = Convert.ToDouble(value.Rows[i][2].ToString());
                        obj.Loan_EWS_LIG = Convert.ToDouble(value.Rows[i][3].ToString());
                        obj.Subsidy_EWS_LIG = Convert.ToDouble(value.Rows[i][4].ToString());
                        obj.No_Beneficiary_EWS_LIG = Convert.ToDouble(value.Rows[i][5].ToString());

                        obj.Loan_MIG = Convert.ToDouble(value.Rows[i][6].ToString());
                        obj.Subsidy_MIG = Convert.ToDouble(value.Rows[i][7].ToString());
                        obj.No_Beneficiary_MIG = Convert.ToDouble(value.Rows[i][8].ToString());
                        obj.Loan_TOTAL_14_15 = Convert.ToDouble(value.Rows[i][9].ToString());


                        obj.Loan_TOTAL_15_16 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Loan_TOTAL_16_17 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Loan_TOTAL_17_18 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Loan_TOTAL_18_19 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Loan_TOTAL_19_20 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Loan_TOTAL_20_21 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Loan_TOTAL_21_22 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Loan_TOTAL = Convert.ToDouble(value.Rows[i][9].ToString());

                        obj.Subsidy_Total = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.NoBeneficiary_Total = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Bene2014_15 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Bene2015_16 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Bene2016_17 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Bene2017_18 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Bene2018_19 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Bene2019_20 = Convert.ToDouble(value.Rows[i][9].ToString());


                        obj.Bene2020_21 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Bene2021_22 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Subsidy2014_15 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Subsidy2015_16 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Subsidy2016_17 = Convert.ToDouble(value.Rows[i][9].ToString());

                        obj.Subsidy2017_18 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Subsidy2018_19 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Subsidy2019_20 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Subsidy20_21 = Convert.ToDouble(value.Rows[i][9].ToString());
                        obj.Subsidy21_22 = Convert.ToDouble(value.Rows[i][9].ToString());

                        obj.Division =  value.Rows[i][9].ToString();

                         
                         
                        //if (value.Rows[i][19].ToString() == "")
                        //{
                        //    obj.ULBShare = 0;
                        //}
                        //else
                        //{
                        //    obj.ULBShare = Convert.ToDouble(value.Rows[i][19].ToString());
                        //}
                         
                        lst.Add(obj);
                        objEntity.CLSS_MAster.Add(obj);
                    }
                    objEntity.SaveChanges();
                }
                catch (Exception ee)
                {
                    String S = ee.Message;
                }
                finally { }
            }
            return "sussess";

        }
        //-------------

        [HttpPost]
        [Route("UploadJNNURM_Excel")] // bulk inset PhysicalDashboard  ****
        public string UploadJNNURM_Excel()
        {  //// PhysicalDashboard bulk insert
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<JnNURM_Master> lst = new List<JnNURM_Master>();
                for (int i = 1; i < value.Rows.Count; i++)
                {
                    JnNURM_Master obj = new JnNURM_Master();
                    //   obj.id = Convert.ToUInt32(value.Rows[i][0].ToString());
                    obj.SrNo = Convert.ToUInt32(value.Rows[i][0].ToString());
                    obj.Project_Code = value.Rows[i][1].ToString();

                    obj.State = value.Rows[i][2].ToString();
                    obj.Scheme = value.Rows[i][3].ToString();
                    obj.Distt = value.Rows[i][4].ToString();
                    obj.CityTown = value.Rows[i][5].ToString();

                    obj.State_Code = value.Rows[i][6].ToString();
                    obj.DisttCode = value.Rows[i][7].ToString();
                    obj.SubDisttCode = value.Rows[i][8].ToString();
                    obj.TownCode = value.Rows[i][9].ToString();
                    obj.Project_Title = value.Rows[i][10].ToString();
                    obj.App_Date = (value.Rows[i][11].ToString()); //DateTime.Parse

                    obj.Cancelled_Date = value.Rows[i][12].ToString();
                    obj.O_ProjectCost = double.Parse(value.Rows[i][13].ToString());

                    obj.O_CentrallShare = double.Parse(value.Rows[i][14].ToString());
                    obj.O_DwellingUnit = double.Parse(value.Rows[i][15].ToString());

                    obj.ProjCost = double.Parse(value.Rows[i][16].ToString());
                    obj.Central_Share = double.Parse(value.Rows[i][17].ToString());

                    obj.DwellingUnit = double.Parse(value.Rows[i][18].ToString());
                    obj.Central_Share_Released_Projects = double.Parse(value.Rows[i][19].ToString());

                    obj.Central_Share_Adjusted = double.Parse(value.Rows[i][20].ToString());
                    obj.Excess_ACA_Released = double.Parse(value.Rows[i][21].ToString());


                    obj.CentralShareRefundedbyStateGovt = Convert.ToDouble(value.Rows[i][22].ToString());
                    obj.UC_Received = double.Parse(value.Rows[i][23].ToString());

                    obj.Pending_UC = Convert.ToDouble(value.Rows[i][24].ToString());
                    obj.Under_Progress = Convert.ToDouble(value.Rows[i][25].ToString());
                    obj.Completed = Convert.ToDouble(value.Rows[i][26].ToString());
                    obj.Allotted = Convert.ToDouble(value.Rows[i][27].ToString());

                    obj.Occupied = Convert.ToDouble(value.Rows[i][28].ToString());
                    obj.UnOccupied = Convert.ToDouble(value.Rows[i][29].ToString());
                    obj.NonStarter = Convert.ToDouble(value.Rows[i][30].ToString());
                    obj.Grounded = Convert.ToDouble(value.Rows[i][31].ToString());

                    obj.Completed1 = Convert.ToDouble(value.Rows[i][32].ToString());
                    obj.Occupied1 = Convert.ToDouble(value.Rows[i][33].ToString());
                    obj.Division = value.Rows[i][34].ToString();
                    lst.Add(obj);
                    objEntity.JnNURM_Master.Add(obj);
                }
                objEntity.SaveChanges();
            }
            return "sussess";
        }


        [HttpGet]
        [Route("DeleteTableDCU")]
        public string DeleteData()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.HFA_Delete_DCW();
            objEntity.SaveChanges();
            return "Table has successfully deleted";
        }

        [HttpGet]
        [Route("DeleteTableJNNURM")]
        public string DeleteDataJNNURM()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.HFA_Delete_JNNURM();
            objEntity.SaveChanges();
            return "Table has successfully deleted";
        }

        [HttpGet]
        [Route("DeleteTablePMAY")]
        public string DeleteDataPMAY()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.HFA_Delete_PMAY();
            objEntity.SaveChanges();
            return "Table has successfully deleted";
        }

        //[HttpGet]
        //[Route("DeleteTablePMAY")]
        //public string DeleteDataPMAY()
        //{
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    objEntity.HFA_Delete_PMAY();
        //    objEntity.SaveChanges();
        //    return "Table has successfully deleted";
        //}
        [HttpGet]
        [Route("DeleteTableStateScore")]
        public string DeleteTableStateScore()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.HFA_Delete_StateScore();
            objEntity.SaveChanges();
            return "Table has successfully deleted";
        }

        [HttpGet]
        [Route("DeleteTablePD")]
        public string DeleteTablePD()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.HFA_Delete_PD();
            objEntity.SaveChanges();
            return "Table has successfully deleted";
        }

        [HttpGet]
        [Route("DeleteTableCLSS_CityWise")]
        public string DeleteTableCLSS_CityWise()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.HFA_Delete_CLSSCityWise();
            objEntity.SaveChanges();
            return "Table has successfully deleted";
        }

        //  clss master 
        [Route("GetExcelCLSSStateMaster")]
        [HttpGet]
        public IEnumerable<CLSS_MASTERVM> GetExcelCLSSStateMaster()
        {
            IEnumerable<CLSS_MASTERVM> objExcel = new List<CLSS_MASTERVM>();
            EmployeeEntities objEntity = new EmployeeEntities();
            try
            {
                objExcel = objEntity.CLSS_MAster.Select(a => new CLSS_MASTERVM
                {
                    SrNo = a.SrNo.ToString(),
                    State = a.State,
                    StateCode = a.StateCode.ToString(),
                    Loan_EWS_LIG = a.Loan_EWS_LIG.ToString(),
                    Subsidy_EWS_LIG = a.Subsidy_EWS_LIG.ToString(),
                    No_Beneficiary_EWS_LIG = a.No_Beneficiary_EWS_LIG.ToString(),
                    Loan_MIG = a.Loan_MIG.ToString(),
                    Subsidy_MIG = a.Subsidy_MIG.ToString(),
                    No_Beneficiary_MIG = a.No_Beneficiary_MIG.ToString(),
                    Loan_TOTAL = a.Loan_TOTAL.ToString(),
                    Subsidy_Total = a.Subsidy_Total.ToString(),
                    NoBeneficiary_Total = a.NoBeneficiary_Total.ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return objExcel;
        }
        [HttpPost]
        [Route("UploadExcelCLSSMaster")] // bulk inset PhysicalDashboard  ****
        public string UploadExcelCLSSMaster()
        {  //// PhysicalDashboard bulk insert
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
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
                List<CLSS_MAster> lst = new List<CLSS_MAster>();
                for (int i = 1; i < value.Rows.Count; i++)
                {
                    CLSS_MAster obj = new CLSS_MAster();
                    obj.SrNo = Convert.ToUInt32(value.Rows[i][0].ToString());
                    obj.State = value.Rows[i][1].ToString();
                    obj.StateCode = 0;//value.Rows[i][2].ToString();
                    obj.Loan_EWS_LIG = Convert.ToUInt32(value.Rows[i][3].ToString());
                    obj.Subsidy_EWS_LIG = Convert.ToUInt32(value.Rows[i][4].ToString());
                    obj.No_Beneficiary_EWS_LIG = Convert.ToUInt32(value.Rows[i][5].ToString());
                    obj.Loan_MIG = Convert.ToUInt32(value.Rows[i][6].ToString());
                    obj.Subsidy_MIG = Convert.ToUInt32(value.Rows[i][7].ToString());
                    obj.No_Beneficiary_MIG = Convert.ToUInt32(value.Rows[i][8].ToString());
                    obj.Loan_TOTAL = Convert.ToUInt32(value.Rows[i][9].ToString());
                    obj.Subsidy_Total = Convert.ToUInt32(value.Rows[i][10].ToString());
                    obj.NoBeneficiary_Total = Convert.ToUInt32(value.Rows[i][11].ToString());

                    lst.Add(obj);
                    objEntity.CLSS_MAster.Add(obj);
                }
                objEntity.SaveChanges();
            }
            return "sussess";
        }
        [HttpGet]
        [Route("DeleteExcelCLSSMaster")]
        public string DeleteExcelCLSSMaster(string excelId)
        {
            string message = "";
            if (excelId != "")
            {
                int id = Convert.ToInt32(excelId);
                EmployeeEntities objEntity = new EmployeeEntities();
                var data = objEntity.CLSS_MAster.Find(id);
                objEntity.CLSS_MAster.Remove(data);
                int i = objEntity.SaveChanges();
                if (i > 0)
                {
                    message = "Record deleted successfully ";
                }
                else
                {
                    message = "Deletion Faild";
                }
            }
            return message;
        }

        [Route("AddVisitor")]
        [HttpPost]
        public string InsertVistor(VisitorMasterVM visitorMasterVm)
        {
            string strMsg = "";
            VisitorMaster objMaster = new VisitorMaster();
            objMaster.CityCode = visitorMasterVm.CityCode;
            objMaster.Dcode = visitorMasterVm.Dcode;
            objMaster.Description = visitorMasterVm.Description;
            objMaster.Extra = visitorMasterVm.Extra;
            objMaster.Notes = visitorMasterVm.Notes;
            objMaster.ProjectName = visitorMasterVm.ProjectName;
            objMaster.sFlag = visitorMasterVm.sFlag;
            objMaster.StateId = visitorMasterVm.StateId;
            EmployeeEntities objEntity = new EmployeeEntities();
            objEntity.VisitorMasters.Add(objMaster);
            int i = objEntity.SaveChanges();

            long? visitorId = objMaster.SrNo;

            FilesUploads(visitorMasterVm.ImageNames, "Image", visitorId);
            FilesUploads(visitorMasterVm.AudioNames, "Audio", visitorId);
            FilesUploads(visitorMasterVm.VideoNames, "Video", visitorId);
            if (i > 0)
            {
                strMsg = "Visitor have been successfully added";
            }
            else
            {
                strMsg = "Visitor have been faild";
            }

            return strMsg;
        }
        private List<Visitor_FileUpload> FilesUploads(string file, string type, long? projectId)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<Visitor_FileUpload> lstVistorUploads = new List<Visitor_FileUpload>();
            string[] strFiles = file.Split(',');
            for (int i = 0; i < strFiles.Length - 1; i++)
            {
                Visitor_FileUpload visitor_FileUpload = new Visitor_FileUpload();
                visitor_FileUpload.VisitorId = projectId;
                visitor_FileUpload.NameofFile = strFiles[i].ToString();

                string[] fileName = strFiles[i].Split('.');


                visitor_FileUpload.TypeOfFile = fileName[1];
                if (type == "Image")
                {

                    visitor_FileUpload.Path = "~/Upload/Image/" + strFiles[i].ToString();

                }
                else if (type == "Audio")
                {

                    visitor_FileUpload.Path = "~/Upload/Audio/" + strFiles[i].ToString();

                }
                else if (type == "Video")
                {
                    visitor_FileUpload.Path = "~/Upload/Video/" + strFiles[i].ToString();
                }
                //lstVistorUploads.Add(visitor_FileUpload);
                objEntity.Visitor_FileUpload.Add(visitor_FileUpload);
            }
            objEntity.SaveChanges();
            return lstVistorUploads.ToList();
        }

        [Route("FileUploads")]
        [HttpPost]
        public HttpResponseMessage UploadImage(string status)
        {
            var httpRequest = HttpContext.Current.Request;

            System.Web.HttpFileCollection httpFileCollection = System.Web.HttpContext.Current.Request.Files;
            try
            {
                for (int i = 0; i < httpFileCollection.Count; i++)
                {
                    System.Web.HttpPostedFile httpPostedFile = httpFileCollection[i];
                    if (httpPostedFile.ContentLength > 0)
                    {
                        var fileName = (Path.GetFileName(httpPostedFile.FileName));
                        if (status == "Image")
                        {
                            var filePath = HttpContext.Current.Server.MapPath("~/Upload/Image/" + fileName);
                            httpPostedFile.SaveAs(filePath);
                        }
                        else if (status == "Audio")
                        {
                            var filePath = HttpContext.Current.Server.MapPath("~/Upload/Audio/" + fileName);
                            httpPostedFile.SaveAs(filePath);
                        }
                        else if (status == "Video")
                        {
                            var filePath = HttpContext.Current.Server.MapPath("~/Upload/Video/" + fileName);
                            httpPostedFile.SaveAs(filePath);
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        //[HttpGet]
        //[Route("GetSDC_CDCLSS")]
        //public HFA_sp_CLSS_DivCompWise_Result GetSDC_CDCLSS(string stateCode, string dcode, string cityCode , string Cid ,string Div)
        //{  //HFA_sp_CLSS_DivCompWise_old
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    HFA_sp_CLSS_DivCompWise_Result lstBulding = objEntity.HFA_sp_CLSS_DivCompWise(stateCode, dcode , cityCode, Cid, Div).FirstOrDefault();
        //    return lstBulding;
        //}

        [Route("GetSDC_CDCLSS")]
        public CLSSWiseDivDet GetSDC_CDCLSS(string stateCode, string dcode, string cityCode, string Cid, string Div)
        {
            //List<ComponentMaster> lstCompMaster = new List<ComponentMaster>();
            EmployeeEntities objEntity = new EmployeeEntities();
            var lstCompMaster = objEntity.GetSDC_CDCLSSe(stateCode, dcode, cityCode, Cid, Div).FirstOrDefault();
            return lstCompMaster;
        }
        [HttpGet]
        [Route("HFA_JNNURMCity_Wise")]
        public JNNURMDivDet HFA_JNNURMCity_Wise(string stateCode, string dcode, string cityCode, string Cid, string Div)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            JNNURMDivDet lstBulding = objEntity.HFA_JNNURMCity_Wisee(stateCode, dcode, cityCode, Cid, Div).FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("GetPmayDataFinYearWise")]
        public sp_GetPmayFinYearData_Result GetPmayDataFinYearWise()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            sp_GetPmayFinYearData_Result lstBulding = objEntity.sp_GetPmayFinYearData().FirstOrDefault();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_CSMC_AllIndiaWise_Result")]
        public List<sp_CSMC_AllIndiaWise_Result> sp_CSMC_AllIndiaWise()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_CSMC_AllIndiaWise_Result> lstBulding = new List<sp_CSMC_AllIndiaWise_Result>();
            lstBulding = objEntity.sp_CSMC_AllIndiaWise().ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_Houses_Status")]
        public List<sp_Houses_Status_Result> sp_Houses_Status()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_Houses_Status_Result> lstBulding = new List<sp_Houses_Status_Result>();
            lstBulding = objEntity.sp_Houses_Status().ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_Houses_StatusNew")]
        public List<sp_Houses_StatusNew_Result> sp_Houses_StatusNew(string stateCode, string DisttCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_Houses_StatusNew_Result> lstBulding = new List<sp_Houses_StatusNew_Result>();
            lstBulding = objEntity.sp_Houses_StatusNew(stateCode, DisttCode, cityCode).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("PMay_FinYearWiseReport")]
        public List<PMay_FinYearWiseReport_Result> PMay_FinYearWiseReport()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<PMay_FinYearWiseReport_Result> lstBulding = new List<PMay_FinYearWiseReport_Result>();
            lstBulding = objEntity.PMay_FinYearWiseReport().ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("PMay_FinYearWiseReportNew")]
        public List<PMay_FinYearWiseReportNew_Result> PMay_FinYearWiseReportNew(string stateCode, string DisttCode, string cityCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<PMay_FinYearWiseReportNew_Result> lstBulding = new List<PMay_FinYearWiseReportNew_Result>();
            lstBulding = objEntity.PMay_FinYearWiseReportNew(stateCode, DisttCode, cityCode).ToList();
            return lstBulding;
        }
        // ----------------------------Update PMAY DATA ---------------------------------------
        [HttpPut]
        [Route("UpdateUserDetails")]
        public bool UpdateUser(PMAY_PROJECTS_Fin data)
        {
            PMAY_PROJECTS_Fin objTest = new PMAY_PROJECTS_Fin();
            EmployeeEntities objEntity = new EmployeeEntities();
            bool status = false;
            var value = objEntity.PMAY_PROJECTS_Fin.Where(a => a.Project_Code == data.Project_Code).FirstOrDefault();
            if (value != null)
            {
                value.Annexure_ID = data.Annexure_ID;
                value.Component = data.Component;

                value.State = data.State;
                value.StateCode = data.StateCode;

                value.District = data.District;
                value.Dcode = data.Dcode;

                value.City = data.City;
                value.CityCode = data.CityCode;

                value.Project_Name = data.Project_Name;
                value.CSMCDate = data.CSMCDate;
                value.CSMCNo = data.CSMCNo;
                value.FinYear = data.FinYear;

                value.NoofProjects = data.NoofProjects;
                value.Project_Cost = data.Project_Cost;
                value.Central_Assistance_involved = data.Central_Assistance_involved;

                value.State_Grant = data.State_Grant;
                value.ULBShare = data.ULBShare;
                value.BeneficiaryShare = data.BeneficiaryShare;

                value.Released_throug_EBR = data.Released_throug_EBR;
                value.CASanctionedForRel = data.CASanctionedForRel;
                value.FirstInstallmentReleased = data.FirstInstallmentReleased;

                value.SecondInstallmentReleased = data.SecondInstallmentReleased;
                value.ThirdInstallmentReleased = data.ThirdInstallmentReleased;
                value.CentralAssistanceReleased = data.CentralAssistanceReleased;

                value.UC_Received = data.UC_Received;
                value.UC_Pending = data.UC_Pending;
                value.Housesinvolved = data.Housesinvolved;

                value.FundsDisbursed_in_Houses = data.FundsDisbursed_in_Houses;
                value.Houses_Grounded = data.Houses_Grounded;
                value.HousesUnderProgress = data.HousesUnderProgress;

                value.Houses_Completed = data.Houses_Completed;
                value.HousesAllotted = data.HousesAllotted;
                value.HousesOccupied = data.HousesOccupied;

                value.Houses_yetto_Grounded = data.Houses_yetto_Grounded;
                value.Cid = data.Cid;
                value.DIVISION = data.DIVISION;
            }
            int i = objEntity.SaveChanges();
            if (i > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
        // ----------------------------Update PMAY DATA ---------------------------------------
        [HttpGet]
        [Route("sp_GetHousesStatusForComp")]
        public List<sp_GetHousesStatusForComp_Result> sp_GetHousesStatusForComp(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusForComp_Result> lstBulding = new List<sp_GetHousesStatusForComp_Result>();
            lstBulding = objEntity.sp_GetHousesStatusForComp(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_GetHousesStatus_CompWise")]
        public List<sp_GetHousesStatus_CompWise_Result> sp_GetHousesStatus_CompWise(string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatus_CompWise_Result> lstBulding = new List<sp_GetHousesStatus_CompWise_Result>();
            lstBulding = objEntity.sp_GetHousesStatus_CompWise(Cid).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_GetHousesStatus_CompWiseNew")]
        public List<sp_GetHousesStatus_CompWiseNew_Result> sp_GetHousesStatus_CompWiseNew(string state_Code, string dcode, string cityCode, string Cid, string FinYear)
        {// New Change
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatus_CompWiseNew_Result> lstBulding = new List<sp_GetHousesStatus_CompWiseNew_Result>();
            lstBulding = objEntity.sp_GetHousesStatus_CompWiseNew(state_Code, dcode, cityCode, Cid, FinYear).ToList();

            return lstBulding;
        }

        [HttpGet]
        [Route("sp_GetHousesStatus_ISSR_Wise")]
        public List<sp_GetHousesStatus_ISSR_Wise_Result> sp_GetHousesStatus_ISSR_Wise(string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatus_ISSR_Wise_Result> lstBulding = new List<sp_GetHousesStatus_ISSR_Wise_Result>();
            lstBulding = objEntity.sp_GetHousesStatus_ISSR_Wise(Cid).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_GetHousesStatus_ISSR_FinYearWise")]
        public List<sp_GetHousesStatus_ISSR_FinYearWise_Result> sp_GetHousesStatus_ISSR_FinYearWise(string stateCode, string DisttCode, string cityCode, string Cid, string FinYear)
        {
            // Changes Made  sp_GetHousesStatus_ISSR_FinYearWise
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatus_ISSR_FinYearWise_Result> lstBulding = new List<sp_GetHousesStatus_ISSR_FinYearWise_Result>();
            lstBulding = objEntity.sp_GetHousesStatus_ISSR_FinYearWise(stateCode, DisttCode, cityCode, Cid, FinYear).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_GetHousesStatus_ISSR_FinYear")]
        public List<sp_GetHousesStatus_ISSR_ALL_Result> sp_GetHousesStatus_ISSR_FinYear(string stateCode, string DisttCode, string cityCode, string Cid, string finYear)
        {
            // Changes Made  sp_GetHousesStatus_ISSR_FinYearWise
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatus_ISSR_ALL_Result> lstBulding = new List<sp_GetHousesStatus_ISSR_ALL_Result>();
            lstBulding = objEntity.sp_GetHousesStatus_ISSR_ALL(stateCode, DisttCode, cityCode, Cid, finYear).ToList();
            return lstBulding;
        }


        [HttpGet]
        [Route("sp_GetHousesStatusForVertical")]
        public List<sp_GetHousesStatusForVertical_Result> sp_GetHousesStatusForVertical(string stateCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusForVertical_Result> lstBulding = new List<sp_GetHousesStatusForVertical_Result>();
            lstBulding = objEntity.sp_GetHousesStatusForVertical(Int32.Parse(stateCode)).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_GetHousesStatusForVerticalJN")]
        public List<sp_GetHousesStatusForVerticaJN_Result> sp_GetHousesStatusForVerticalJN(string stateCode, string DisttCode, string cityCode)
        {
            // Changes Made
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusForVerticaJN_Result> lstBulding = new List<sp_GetHousesStatusForVerticaJN_Result>();
            lstBulding = objEntity.sp_GetHousesStatusForVerticaJN(stateCode, DisttCode, cityCode).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_CLSS_HousesStatusForVertical")]
        public List<sp_CLSS_HousesStatusForVertical_Result> sp_CLSS_HousesStatusForVertical(string stateCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_CLSS_HousesStatusForVertical_Result> lstBulding = new List<sp_CLSS_HousesStatusForVertical_Result>();
            lstBulding = objEntity.sp_CLSS_HousesStatusForVertical(stateCode).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_GetHousesStatusFor2014_15")]
        public List<sp_GetHousesStatusFor2014_15_Result> sp_GetHousesStatusFor2014_15(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor2014_15_Result> lstBulding = new List<sp_GetHousesStatusFor2014_15_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor2014_15(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_GetHousesStatusFor2015_16")]
        public List<sp_GetHousesStatusFor2015_16_Result> sp_GetHousesStatusFor2015_16(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor2015_16_Result> lstBulding = new List<sp_GetHousesStatusFor2015_16_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor2015_16(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_GetHousesStatusFor2016_17")]
        public List<sp_GetHousesStatusFor2016_17_Result> sp_GetHousesStatusFor2016_17(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor2016_17_Result> lstBulding = new List<sp_GetHousesStatusFor2016_17_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor2016_17(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_GetHousesStatusFor2017_18")]
        public List<sp_GetHousesStatusFor2017_18_Result> sp_GetHousesStatusFor2017_18(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor2017_18_Result> lstBulding = new List<sp_GetHousesStatusFor2017_18_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor2017_18(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_GetHousesStatusFor2018_19")]
        public List<sp_GetHousesStatusFor2018_19_Result> sp_GetHousesStatusFor2018_19(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor2018_19_Result> lstBulding = new List<sp_GetHousesStatusFor2018_19_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor2018_19(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_GetHousesStatusFor2019_20")]
        public List<sp_GetHousesStatusFor2019_20_Result> sp_GetHousesStatusFor2019_20(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor2019_20_Result> lstBulding = new List<sp_GetHousesStatusFor2019_20_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor2019_20(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_GetHousesStatus_ISSR_2014_15")]
        public List<sp_GetHousesStatusFor_ISSR_2014_15_Result> sp_GetHousesStatus_ISSR_2014_15(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor_ISSR_2014_15_Result> lstBulding = new List<sp_GetHousesStatusFor_ISSR_2014_15_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor_ISSR_2014_15(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_GetHousesStatus_ISSR_2015_16")]
        public List<sp_GetHousesStatus_ISSR_2015_16_Result> sp_GetHousesStatus_ISSR_2015_16(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatus_ISSR_2015_16_Result> lstBulding = new List<sp_GetHousesStatus_ISSR_2015_16_Result>();
            lstBulding = objEntity.sp_GetHousesStatus_ISSR_2015_16(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_GetHousesStatus_ISSR_2016_17")]
        public List<sp_GetHousesStatusFor_ISSR_2016_17_Result> sp_GetHousesStatus_ISSR_2016_17(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor_ISSR_2016_17_Result> lstBulding = new List<sp_GetHousesStatusFor_ISSR_2016_17_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor_ISSR_2016_17(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_GetHousesStatus_ISSR_2017_18")]
        public List<sp_GetHousesStatusFor_ISSR_2017_18_Result> sp_GetHousesStatus_ISSR_2017_18(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor_ISSR_2017_18_Result> lstBulding = new List<sp_GetHousesStatusFor_ISSR_2017_18_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor_ISSR_2017_18(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_GetHousesStatus_ISSR_2018_19")]
        public List<sp_GetHousesStatusFor_ISSR_2018_19_Result> sp_GetHousesStatus_ISSR_2018_19(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor_ISSR_2018_19_Result> lstBulding = new List<sp_GetHousesStatusFor_ISSR_2018_19_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor_ISSR_2018_19(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_GetHousesStatus_ISSR_2019_20")]
        public List<sp_GetHousesStatusFor_ISSR_2019_20_Result> sp_GetHousesStatus_ISSR_2019_20(string stateCode, string DisttCode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetHousesStatusFor_ISSR_2019_20_Result> lstBulding = new List<sp_GetHousesStatusFor_ISSR_2019_20_Result>();
            lstBulding = objEntity.sp_GetHousesStatusFor_ISSR_2019_20(stateCode, DisttCode, cityCode, Cid).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_GetDetailsDataPopUp")]
        public List<sp_GetDetailsDataPopUp_Result> sp_GetDetailsDataPopUp(string stateCode, string Cid, string finYear, string type)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetDetailsDataPopUp_Result> lstBulding = new List<sp_GetDetailsDataPopUp_Result>();
            lstBulding = objEntity.sp_GetDetailsDataPopUp(stateCode, Cid, finYear, type).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("GetFinancialPMAY_Data")]
        public List<Proc_GetFinancialPMAY_Data_Result> GetFinancialPMAY_Data(string stateCode, string DisttCode, string cityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<Proc_GetFinancialPMAY_Data_Result> lstBulding = new List<Proc_GetFinancialPMAY_Data_Result>();
            lstBulding = objEntity.Proc_GetFinancialPMAY_Data(stateCode, DisttCode, cityCode, Cid, finYear).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("GetFinancialISSR_Data")]
        public List<Proc_GetFinancialISSR_Data_Result> GetFinancialISSR_Data(string stateCode, string DisttCode, string cityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<Proc_GetFinancialISSR_Data_Result> lstBulding = new List<Proc_GetFinancialISSR_Data_Result>();
            lstBulding = objEntity.Proc_GetFinancialISSR_Data(stateCode, DisttCode, cityCode, Cid, finYear).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("GetFinance_StatusForCLSS")]
        public List<sp_GetFinance_StatusForCLSS_Result> GetFinance_StatusForCLSS(string stateCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_GetFinance_StatusForCLSS_Result> lstBulding = new List<sp_GetFinance_StatusForCLSS_Result>();
            lstBulding = objEntity.sp_GetFinance_StatusForCLSS(stateCode).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("GetAll_RegisterDetails")]
        public List<Users_RegisterVM> RegisterDetails()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<Users_RegisterVM> lstUser = new List<Users_RegisterVM>();
            lstUser = objEntity.Users_Register.Select(a => new Users_RegisterVM
            {
                UserId = a.UserId,
                UserName = a.UserName,
                LastName = a.LastName,
                UserType = a.UserType,
                Password = a.Password,
                DesignationId = a.DesignationId,
                States_UT = a.State_Master.States_UT,

                District = a.Distt_Master.District,
               
                City = a.City_Master.City,
                ZipCode = a.ZipCode,
                LastLoginDate = a.LastLoginDate.ToString(),
                PasswordChangeDate = a.PasswordChangeDate.ToString(),
                RoleName = a.RoleMaster.RoleName,
                EmailId = a.EmailId,
                MobileNo = a.MobileNo,
                PhoneNo = a.PhoneNo,
                TaskName = a.TaskName,
                UserStatus = a.UserStatus
            }).ToList();
            return lstUser;
        }
        [HttpGet]
        [Route("GetStateMapData")]
        public List<StateMap> GetStateMapData()
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<Combined_States> lstSate = new List<Combined_States>();
            lstSate = objEntity.Combined_States.ToList();

            List<StateMap> lstMap = new List<StateMap>();
            int count = 1;
            foreach (var item in lstSate)
            {
                StateMap objMap = new StateMap();
                objMap.map = "map_" + count;
                objMap.hover = item.Name_of_the_State__UT;
                objMap.data = new StateData()
                {
                    Grounded = item.Grounded,
                    Occupied=item.Occupied,
                    Completed=item.Completed
                };
                lstMap.Add(objMap);
                count++;
            }
            count = 1;
            return lstMap;
        }
        [HttpPost]
        [Route("InsertCity_MasterData")]
        public string InsertDistrictData(City_Master data)
        {
            string message = "";
            if (data != null)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
                objEntity.City_Master.Add(data);
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


        [HttpPut]
        [Route("UpdateDistt_MasterData")]
        public string UpdateDistrictData(Distt_Master data)
        {
            string message = "";
            if (data != null)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
                var record = objEntity.Distt_Master.Find(data.DisttId);
                if(record != null)
                {
                    record.StateCode = data.StateCode;
                    record.Distt = data.Distt;
                    record.District = data.District;
                    record.Dcode = data.Dcode;
                    record.Minority = data.Minority;
                    record.BackwardDistrict = data.BackwardDistrict;
                    record.Status = data.Status;
                    int i = objEntity.SaveChanges();
                    if (i > 0)
                    {
                        message = "Distt Master data Updated succeffully";
                    }
                    else
                    {
                        message = "Update failed";
                    }
                }
              
            }
            return message;
        }


        [HttpGet]
        [Route("GetRayHouses")]
        public List<sp_RayThirdInstHouses_Result> GetRayHouses(string stateCode, string DisttCode, string cityCode, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_RayThirdInstHouses_Result> lstBulding = new List<sp_RayThirdInstHouses_Result>();
            lstBulding = objEntity.sp_RayThirdInstHouses(stateCode, DisttCode, cityCode, finYear).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_create_PMAYDATA")]
        public List<sp_create_PMAYDATA_Result> sp_create_PMAYDATA(string stateCode, string dcode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_create_PMAYDATA_Result> lstBulding = new List<sp_create_PMAYDATA_Result>();
            lstBulding = objEntity.sp_create_PMAYDATA(stateCode, dcode, cityCode).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_create_BLC_AHP_DATA")]
        public List<sp_create_BLC_AHP_DATA_Result> sp_create_BLC_AHP_DATA(string stateCode, string dcode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_create_BLC_AHP_DATA_Result> lstBulding = new List<sp_create_BLC_AHP_DATA_Result>();
            lstBulding = objEntity.sp_create_BLC_AHP_DATA(stateCode, dcode, cityCode, Cid).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_create_ISSR_DATA")]
        public List<sp_create_ISSR_DATA_Result> sp_create_ISSR_DATA(string stateCode, string dcode, string cityCode, string Cid)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_create_ISSR_DATA_Result> lstBulding = new List<sp_create_ISSR_DATA_Result>();
            lstBulding = objEntity.sp_create_ISSR_DATA(stateCode, dcode, cityCode, Cid).ToList();
            return lstBulding;
        }
        // to check
        [HttpGet]
        [Route("sp_create_PMAYCriticalDATA")]
        public List<sp_Get_Critical_HousesStatus_Result> sp_create_PMAYCriticalDATA(string stateCode, string dcode, string cityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_Get_Critical_HousesStatus_Result> lstBulding = new List<sp_Get_Critical_HousesStatus_Result>();
            lstBulding = objEntity.sp_Get_Critical_HousesStatus(stateCode, dcode, cityCode, Cid, finYear).ToList();
            return lstBulding;
        }

        //[HttpGet]
        //[Route("sp_create_PMAYCriticalDATA")]
        //public List<PMAYCritical_DATAFinYeraWise> sp_create_PMAYCriticalDATA(string stateCode, string dcode, string cityCode, string Cid, string finYear)
        //{
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    List<PMAYCritical_DATAFinYeraWise> lstBulding = new List<PMAYCritical_DATAFinYeraWise>();
        //    lstBulding = objEntity.sp_Get_Critical_HousesStatus_e(stateCode, dcode, cityCode, Cid, finYear).ToList();
        //    return lstBulding;
        //}






        [HttpGet]
        [Route("sp_Get_Graph_Critical_ISSR_HousesStatus")]
        public List<sp_Get_Graph_Critical_ISSR_HousesStatus_Result> sp_Get_Graph_Critical_ISSR_HousesStatus(string stateCode, string dcode, string cityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_Get_Graph_Critical_ISSR_HousesStatus_Result> lstBulding = new List<sp_Get_Graph_Critical_ISSR_HousesStatus_Result>();
            lstBulding = objEntity.sp_Get_Graph_Critical_ISSR_HousesStatus(stateCode, dcode, cityCode, Cid, finYear).ToList();
            return lstBulding;
        }
        //[HttpGet]
        //[Route("sp_Get_Critical_AHP_HousesStatusNew")]
        //public List<sp_Get_Critical_AHP_HousesStatus_Result> sp_Get_Critical_AHP_HousesStatusNew(string stateCode, string dcode, string cityCode, string Cid, string finYear)
        //{
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    List<sp_Get_Critical_AHP_HousesStatus_Result> lstBulding = new List<sp_Get_Critical_AHP_HousesStatus_Result>();
        //    lstBulding = objEntity.sp_Get_Critical_AHP_HousesStatus(stateCode, dcode, cityCode, Cid, finYear).ToList();
        //    return lstBulding;
        //}

        [HttpGet]
        [Route("sp_Get_Critical_AHP_HousesStatus")]
        public List<sp_Get_Critical_AHP_HousesStatus_Result> sp_Get_Critical_AHP_HousesStatus(string stateCode, string dcode, string cityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_Get_Critical_AHP_HousesStatus_Result> lstBulding = new List<sp_Get_Critical_AHP_HousesStatus_Result>();
            lstBulding = objEntity.sp_Get_Critical_AHP_HousesStatus(stateCode, dcode, cityCode, Cid, finYear).ToList();
            return lstBulding;
        }


        [HttpGet]
        [Route("sp_Get_Critical_ISSR_HousesStatus")]
        public List<sp_Get_Critical_ISSR_HousesStatus_Result> sp_Get_Critical_ISSR_HousesStatus(string stateCode, string dcode, string cityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_Get_Critical_ISSR_HousesStatus_Result> lstBulding = new List<sp_Get_Critical_ISSR_HousesStatus_Result>();
            lstBulding = objEntity.sp_Get_Critical_ISSR_HousesStatus(stateCode, dcode, cityCode, Cid, finYear).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_Get_Critical_GRID_AHP_HousesStatus")]
        public List<sp_Get_Critical_GRID_AHP_HousesStatus_Result> sp_Get_Critical_GRID_AHP_HousesStatus(string stateCode, string dcode, string cityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_Get_Critical_GRID_AHP_HousesStatus_Result> lstBulding = new List<sp_Get_Critical_GRID_AHP_HousesStatus_Result>();
            lstBulding = objEntity.sp_Get_Critical_GRID_AHP_HousesStatus(stateCode, dcode, cityCode, Cid, finYear).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_Get_Critical_GRID_BLC_HousesStatus")]
        public List<sp_Get_Critical_GRID_BLC_HousesStatus_Result> sp_Get_Critical_GRID_BLC_HousesStatus(string stateCode, string dcode, string cityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_Get_Critical_GRID_BLC_HousesStatus_Result> lstBulding = new List<sp_Get_Critical_GRID_BLC_HousesStatus_Result>();
            lstBulding = objEntity.sp_Get_Critical_GRID_BLC_HousesStatus(stateCode, dcode, cityCode, Cid, finYear).ToList();
            return lstBulding;
        }
        //
        //

        [HttpGet]
        [Route("sp_Get_Critical_BLCS_HousesStatus")]
        public List<sp_Get_Critical_BLCS_HousesStatus_Result> sp_Get_Critical_BLCS_HousesStatus_Result(string stateCode, string dcode, string cityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_Get_Critical_BLCS_HousesStatus_Result> lstBulding = new List<sp_Get_Critical_BLCS_HousesStatus_Result>();
            lstBulding = objEntity.sp_Get_Critical_BLCS_HousesStatus(stateCode, dcode, cityCode, Cid, finYear).ToList();
            return lstBulding;
        }
        

        [HttpGet]
        [Route("sp_create_PMAYDATAFinYeraWise")]
        public List<PMAYDATAFinYeraWise> sp_create_PMAYDATAFinYeraWise(string stateCode, string dcode, string CityCode,  string finYear)
        {
            List<PMAYDATAFinYeraWise> lstDivMaster = new List<PMAYDATAFinYeraWise>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.PMAYDATAFinYera_Wise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }

        //[HttpGet]
        //[Route("sp_create_PMAYDATAFinYeraWise")]
        //public List<PMAYDATAFinYeraWise> sp_create_PMAYDATAFinYeraWise(string stateCode, string dcode, string CityCode, string finYear)
        //{
        //    List<PMAYDATAFinYeraWise> lstDivMaster = new List<PMAYDATAFinYeraWise>();
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    lstDivMaster = objEntity.PMAYDATAFinYera_Wise_e(stateCode, dcode, CityCode, finYear).ToList();
        //    return lstDivMaster;
        //}


        [HttpGet]
        [Route("sp_create_BLCS_DATAFinYeraWise")]
        public List<PMAYDATAFinYeraWise> sp_create_BLCS_DATAFinYeraWise(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<PMAYDATAFinYeraWise> lstDivMaster = new List<PMAYDATAFinYeraWise>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.BLCS_DATAFinYera_Wise_e(stateCode, dcode, CityCode, finYear).ToList();

            return lstDivMaster;
        }

        [HttpGet]
        [Route("sp_create_AHP_DATAFinYeraWise")]
        public List<PMAYDATAFinYeraWise> sp_create_AHP_DATAFinYeraWise(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<PMAYDATAFinYeraWise> lstDivMaster = new List<PMAYDATAFinYeraWise>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.AHP_DATAFinYera_Wise_e(stateCode, dcode, CityCode, finYear).ToList();

            return lstDivMaster;
        }

        [HttpGet]
        [Route("sp_create_ISSR_DATAFinYeraWise")]
        public List<PMAYDATAFinYeraWise> sp_create_CLSS_DATAFinYeraWise(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<PMAYDATAFinYeraWise> lstDivMaster = new List<PMAYDATAFinYeraWise>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.ISSR_DATAFinYera_Wise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }

        [HttpGet]
        [Route("sp_create_CRITICAL_DATAFinYeraWise")]
        public List<PMAYCritical_DATAFinYeraWise> sp_create_CRITICAL_DATAFinYeraWise(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<PMAYCritical_DATAFinYeraWise> lstDivMaster = new List<PMAYCritical_DATAFinYeraWise>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.sp_create_PMayCritical_DATAFinYeraWise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }

        [HttpGet]
        [Route("sp_create_CRITICAL_GRIDISSR_DATAFinYeraWise")]
        public List<PMAYCritical_DATAFinYeraWise> sp_create_CRITICAL_GRIDISSR_DATAFinYeraWise(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<PMAYCritical_DATAFinYeraWise> lstDivMaster = new List<PMAYCritical_DATAFinYeraWise>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.sp_create_ISSR_GraphCritical_DATAFinYeraWise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }
        [HttpGet]
        [Route("sp_create_CRITICAL_GRIDAHP_DATAFinYeraWise")]
        public List<PMAYCritical_DATAFinYeraWise> sp_create_CRITICAL_GRIDAHP_DATAFinYeraWise(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<PMAYCritical_DATAFinYeraWise> lstDivMaster = new List<PMAYCritical_DATAFinYeraWise>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.sp_create_AHP_GraphCritical_DATAFinYeraWise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }

        [HttpGet]
        [Route("sp_create_CRITICAL_GRIDBLCS_DATAFinYeraWise")]
        public List<PMAYCritical_DATAFinYeraWise> sp_create_CRITICAL_GRIDBLCS_DATAFinYeraWise(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<PMAYCritical_DATAFinYeraWise> lstDivMaster = new List<PMAYCritical_DATAFinYeraWise>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.sp_create_BLCS_GraphCritical_DATAFinYeraWise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }




        [HttpGet]
        [Route("sp_createGrid__CRITICAL_DATAFinYeraWise")]
        public List<PMAYCritical_DATAFinYeraWise> sp_createGrid__CRITICAL_DATAFinYeraWise(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<PMAYCritical_DATAFinYeraWise> lstDivMaster = new List<PMAYCritical_DATAFinYeraWise>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.sp_create_Grid_Critical_DATAFinYeraWise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }

        //[HttpGet]
        //[Route("sp_Houses_StatusNew")]
        //public List<sp_Houses_StatusNew_Result> sp_Houses_StatusNew(string stateCode, string DisttCode, string cityCode)
        //{
        //    EmployeeEntities objEntity = new EmployeeEntities();
        //    List<sp_Houses_StatusNew_Result> lstBulding = new List<sp_Houses_StatusNew_Result>();
        //    lstBulding = objEntity.sp_Houses_StatusNew(stateCode, DisttCode, cityCode).ToList();
        //    return lstBulding;
        //////}
        ///

        [HttpGet]
        [Route("DeleteRegister")]
        public string DeleteRegister(bool status,string id)
        {
            string message = "";
            if (id != "")
            {
                long userId = Convert.ToInt64(id);
                Register_Users obj = new Register_Users();
                EmployeeEntities objEntity = new EmployeeEntities();
                var data = objEntity.Users_Register.Find(userId);
                if(data !=null)
                {
                    data.UserStatus = status;
                }
                int i = objEntity.SaveChanges();
                if (i > 0)
                {
                    message = " data saved succeffully";
                }
                else
                {
                    message = "Save failed";
                }
            }
            return message;
        }


        [HttpPost]
        [Route("SaveUpdateStateScore")]
        public string SaveUpdateStateScore(tblStateWiseScoreVM  Sscore)
        {
            string message = "";
            if (Sscore != null)
            {
                EmployeeEntities objEntity = new EmployeeEntities();
               var data = objEntity.tblStateWiseScores.Where(a => a.StateId == Sscore.StateId).FirstOrDefault();
                    if(data != null)
                    {
                        data.StateId = Sscore.StateId;
                    }
                    else
                    {
                        tblStateWiseScore objAdd = new tblStateWiseScore();
                        objAdd.StateId = Sscore.StateId;

                        objEntity.tblStateWiseScores.Add(objAdd);
                    }
               
                int i = objEntity.SaveChanges();
                if (i > 0)
                {
                    message = "data saved succeffully";
                }
                else
                {
                    message = "Save failed";
                }
            }
            return message;
        }


        //> sp_create_Finance_ConsPMAYDATA(string state_Code, string dcode, string cityCode, string component, string finYear

        [HttpGet]
        [Route("GetFinancial_Cons_PMAYData")]
        public List<sp_create_Finance_ConsPMAYDATA_Result> GetFinancial_Cons_PMAYData(string stateCode, string dcode, string CityCode, string cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_create_Finance_ConsPMAYDATA_Result> lstBulding = new List<sp_create_Finance_ConsPMAYDATA_Result>();
            lstBulding = objEntity.sp_create_Finance_ConsPMAYDATA(stateCode, dcode, CityCode, cid, finYear).ToList();
            return lstBulding;
        }
        [HttpGet]
        [Route("sp_create_Finance_Cons_ISSR_DATA")]
        public List<sp_create_Finance_Cons_ISSR_DATA_Result> sp_create_Finance_Cons_ISSR_DATA(string stateCode, string dcode, string CityCode, string cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_create_Finance_Cons_ISSR_DATA_Result> lstBulding = new List<sp_create_Finance_Cons_ISSR_DATA_Result>();
            lstBulding = objEntity.sp_create_Finance_Cons_ISSR_DATA(stateCode, dcode, CityCode, cid, finYear).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("Fin_PMAY_Graph_DATAFinYeraWise")]
        public List<FinData> Fin_PMAY_Graph_DATAFinYeraWise_e(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<FinData> lstDivMaster = new List<FinData>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.Fin_PMAY_Graph_DATAFinYeraWise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }

        [HttpGet]
        [Route("Fin_BLCS_Graph_DATAFinYeraWise")]
        public List<FinData> sp_Finance_BLCS_DATAFinYeraWise_e(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<FinData> lstDivMaster = new List<FinData>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.sp_Finance_BLCS_DATAFinYeraWise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }

        [HttpGet]
        [Route("Fin_AHP_Graph_DATAFinYeraWise")]
        public List<FinData> sp_Finance_AHP_DATAFinYeraWise_e(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<FinData> lstDivMaster = new List<FinData>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.sp_Finance_AHP_DATAFinYeraWise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }

        [HttpGet]
        [Route("Fin_ISSR_Graph_DATAFinYeraWise")]
        public List<FinData> sp_Finance_ISSR_DATAFinYeraWise_e(string stateCode, string dcode, string CityCode, string finYear)
        {
            List<FinData> lstDivMaster = new List<FinData>();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.sp_Finance_ISSR_DATAFinYeraWise_e(stateCode, dcode, CityCode, finYear).ToList();
            return lstDivMaster;
        }
        //        sp_Finance_PMAYDATAFinYeraWise
        //sp_Finance_ISSR_DATAFinYeraWise
        //  sp_Finance_BLCS_DATAFinYeraWise
        //  sp_Finance_AHP_DATAFinYeraWise

        [HttpGet]
        [Route("sp_Dynamic_Physical_CompWiseView")]
        public FinDataModel sp_Dynamic_Physical_CompWiseView(string state_Code, string dcode, string cityCode, string Cid, string FinYear)
        {
            FinDataModel lstDivMaster = new FinDataModel();
            EmployeeEntities objEntity = new EmployeeEntities();
            lstDivMaster = objEntity.sp_Dynamic_Physical_CompWiseView_e(state_Code, dcode, cityCode, Cid, FinYear);
            return lstDivMaster;
            //http://localhost:58396/api/buldings/sp_Dynamic_Physical_CompWiseView?state_Code=0&dcode=0&cityCode=0&component=0&finYear=0
        }
        
         [HttpGet]
        [Route("sp_create_Fin_ConsPMAYDATA")]
        public List<sp_create_Fin_ConsPMAYDATA_Result> sp_create_Fin_ConsPMAYDATA(string stateCode, string dcode, string CityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_create_Fin_ConsPMAYDATA_Result> lstBulding = new List<sp_create_Fin_ConsPMAYDATA_Result>();
            lstBulding = objEntity.sp_create_Fin_ConsPMAYDATA(stateCode, dcode, CityCode, Cid, finYear).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("Get_Clss_Master_Result")]
        public List<Get_Clss_Master_Result> Get_Clss_Master_Result(string stateCode)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<Get_Clss_Master_Result> lstBulding = new List<Get_Clss_Master_Result>();
            lstBulding = objEntity.Get_Clss_Master(stateCode).ToList();
            return lstBulding;
        }

        [HttpGet]
        [Route("sp_create_Fin_Cons_ISSRDATA")]
        public List<sp_create_Fin_Cons_ISSRDATA_Result> sp_create_Fin_Cons_ISSRDATA(string stateCode, string dcode, string CityCode, string Cid, string finYear)
        {
            EmployeeEntities objEntity = new EmployeeEntities();
            List<sp_create_Fin_Cons_ISSRDATA_Result> lstBulding = new List<sp_create_Fin_Cons_ISSRDATA_Result>();
            lstBulding = objEntity.sp_create_Fin_Cons_ISSRDATA(stateCode, dcode, CityCode, Cid, finYear).ToList();
            return lstBulding;
        }
    }

}

