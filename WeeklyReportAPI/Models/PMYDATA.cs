using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.Models
{
    public static class EmployeeEntitiesExtensions
    {
        public static List<PMAY_Data> HFA_sp_PMay_CompWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            //PMAY_Data  BuildingModel
            if (cid == null)
                cid = "0";
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<PMAY_Data>("HFA_sp_PMay_CompWiseN @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }

        public static List<PMAY_Data> HFA_sp_PMay_CompWiseNew_e(this EmployeeEntities emp, string StateCode, string dcode, string cityCode, string Cid, string Division)
        {
            //PMAY_Data  BuildingModel
            if (Cid == null)
                Cid = "0";
            if (Division == null)
                Division = "0";

            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", StateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", Cid),
                new SqlParameter("@Division", Division),
        };
            return emp.Database.SqlQuery<PMAY_Data>("HFA_sp_PMay_CompWiseNew @StateCode,@dcode,@cityCode,@Cid,@Division", parameters).ToList();
        }


        public static List<DemandNew> HFA_GetDemandCompWiseN_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            try
            {
                if (cid == null)
                    cid = "0";
                //PMAY_Data  BuildingModel

                SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
                return emp.Database.SqlQuery<DemandNew>("HFA_GetDemandCompWiseN @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally { }
        }
        //-------------
        public static List<DemandNew> HFA_GetDemandCompDiv_Wise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string Division)
        {
            try
            {

                SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                //new SqlParameter("@Cid", cid),
                new SqlParameter("@Division", Division),
           };
                return emp.Database.SqlQuery<DemandNew>("HFA_GetDemandCompDiv_Wise @StateCode,@dcode,@cityCode,@Division", parameters).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally { }
        }
        ///----------------
        public static List<ComponentWiseSanctioned> HFA_spPMayCompWiseData_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<ComponentWiseSanctioned>("HFA_spPMayCompWiseData @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }

        public static List<ComponentWiseSanctioned> HFA_sp_PMayCompAll_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<ComponentWiseSanctioned>("HFA_sp_PMayCompAll @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }

        public static List<PMAY_FinancialData> HFA_GetFinData_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<PMAY_FinancialData>("HFA_PMay_CompFYrWise14_15 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }
        public static List<PMAY_FinancialData> HFA_GetFinData15_16_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<PMAY_FinancialData>("HFA_PMay_CompFYrWise15_16 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }
        public static List<PMAY_FinancialData> HFA_GetFinData16_17_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<PMAY_FinancialData>("HFA_PMay_CompFYrWise16_17 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }
        public static List<PMAY_FinancialData> HFA_GetFinData17_18_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<PMAY_FinancialData>("HFA_PMay_CompFYrWise17_18 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }
        public static List<PMAY_FinancialData> HFA_GetFinData18_19_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<PMAY_FinancialData>("HFA_PMay_CompFYrWise18_19 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }

        public static List<PMAY_FinancialData> HFA_GetFinData19_20_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<PMAY_FinancialData>("HFA_PMay_CompFYrWise19_20 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }

        public static List<FinancialProgress> Finance_Progress14_15_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress14_15 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }
        public static List<FinancialProgress> Finance_Progress15_16_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress15_16 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }
        public static List<FinancialProgress> Finance_Progress16_17_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress16_17 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }
        public static List<FinancialProgress> Finance_Progress17_18_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress17_18 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }

        public static List<FinancialProgress> Finance_Progress18_19_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress18_19 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }
        public static List<FinancialProgress> Finance_Progress19_20_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            if (cid == null)
                cid = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress19_20 @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }

        public static List<PMAY_Data> SectorWiseReport_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid)
        {
            //PMAY_Data  BuildingModel
            if (cid == null)
                cid = "0";
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
        };
            return emp.Database.SqlQuery<PMAY_Data>("SectorWiseReport @StateCode,@dcode,@cityCode,@Cid", parameters).ToList();
        }
        public static List<DivisionDet> HFA_GetByDivision_e(this EmployeeEntities emp, string Division)
        {
            if (Division == null)
                Division = "0";
            SqlParameter[] parameters = {
                new SqlParameter("@Division", Division),
              };
            return emp.Database.SqlQuery<DivisionDet>("HFA_GetStatesByDivision @Division", parameters).ToList();
        }

        public static List<DivisionDet> HFA_GetByStateId_e(this EmployeeEntities emp, string StateId)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateId", StateId),
              };
            return emp.Database.SqlQuery<DivisionDet>("HFA_GetAllStates_ByStateId @StateId", parameters).ToList();
        }

        public static List<ConsStatesDet> HFA_GetByStateDivision_e(this EmployeeEntities emp, string stateCode, string Division)
        {
            if (Division == null)
                Division = "0";
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@Division", Division),
              };
            return emp.Database.SqlQuery<ConsStatesDet>("GetStateWiseFinYrDataNew @StateCode,@Division", parameters).ToList();
        }
        public static List<ConsStatesDet> HFA_GetByStateDivision_e1(this EmployeeEntities emp, string stateCode, string Division)
        {
            if (Division == null)
                Division = "0";
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@Division", Division),
              };
            return emp.Database.SqlQuery<ConsStatesDet>("GetStateWiseFinYrDataNew1 @StateCode,@Division", parameters).ToList();
        }

        public static List<FinancialProgress> Finance_Progress14_15_NEWe(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid, string Division)
        {
            if (cid == null)
                cid = "0";
            if (Division == null)
                Division = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
                new SqlParameter("@Division", Division),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress14_15_New @StateCode,@dcode,@cityCode,@Cid,@Division", parameters).ToList();
        }
        public static List<FinancialProgress> Finance_Progress15_16_NEWe(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid, string Division)
        {
            if (cid == null)
                cid = "0";
            if (Division == null)
                Division = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
                new SqlParameter("@Division", Division),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress15_16_New @StateCode,@dcode,@cityCode,@Cid,@Division", parameters).ToList();
        }
        public static List<FinancialProgress> Finance_Progress16_17_NEWe(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid, string Division)
        {
            if (cid == null)
                cid = "0";
            if (Division == null)
                Division = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
                new SqlParameter("@Division", Division),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress16_17_New @StateCode,@dcode,@cityCode,@Cid,@Division", parameters).ToList();
        }
        public static List<FinancialProgress> Finance_Progress17_18_NEWe(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid, string Division)
        {
            if (cid == null)
                cid = "0";
            if (Division == null)
                Division = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
                new SqlParameter("@Division", Division),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress17_18_New @StateCode,@dcode,@cityCode,@Cid,@Division", parameters).ToList();
        }
        public static List<FinancialProgress> Finance_Progress18_19_NEWe(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string cid, string Division)
        {
            if (cid == null)
                cid = "0";
            if (Division == null)
                Division = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", cid),
                new SqlParameter("@Division", Division),
        };
            return emp.Database.SqlQuery<FinancialProgress>("HFA_FinProgress18_19_New @StateCode,@dcode,@cityCode,@Cid,@Division", parameters).ToList();
        }

        //CLSSWiseDivDet  string stateCode, string dcode, string cityCode, string Cid, string Div
        public static List<CLSSWiseDivDet> GetSDC_CDCLSSe(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string Cid, string Div)
        {
            if (Cid == null)
                Cid = "0";
            if (Div == null)
                Div = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", Cid),
                new SqlParameter("@Div", Div),
        };
            return emp.Database.SqlQuery<CLSSWiseDivDet>("HFA_sp_CLSS_DivCompWise @StateCode,@dcode,@cityCode,@Cid,@Div", parameters).ToList();
        }
        public static List<JNNURMDivDet> HFA_JNNURMCity_Wisee(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string Cid, string Div)
        {
            if (Cid == null)
                Cid = "0";
            if (Div == null)
                Div = "0";
            //PMAY_Data  BuildingModel
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Cid", Cid),
                new SqlParameter("@Div", Div),
        };
            return emp.Database.SqlQuery<JNNURMDivDet>("HFA_JNNURMCity_Wise @StateCode,@dcode,@cityCode,@Cid,@Div", parameters).ToList();
        }

        public static List<PhysicalDetails> HFA_GetPD_ByStateDivision_e(this EmployeeEntities emp, string stateCode, string Division)
        {
            if (Division == null)
                Division = "0";
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@Division", Division),
              };
            return emp.Database.SqlQuery<PhysicalDetails>("Proc_CLSS_ParamNew @StateCode,@Division", parameters).ToList();
        }
        public static List<PMAYDATAFinYeraWise> PMAYDATAFinYera_Wise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYDATAFinYeraWise>("sp_create_PMAYDATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }

        public static List<PMAYDATAFinYeraWise> BLCS_DATAFinYera_Wise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYDATAFinYeraWise>("sp_create_BLCS_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }
        public static List<PMAYDATAFinYeraWise> AHP_DATAFinYera_Wise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYDATAFinYeraWise>("sp_create_AHP_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }
        public static List<PMAYDATAFinYeraWise> ISSR_DATAFinYera_Wise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYDATAFinYeraWise>("sp_create_ISSR_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }

        public static List<PMAYCritical_DATAFinYeraWise> sp_create_PMayCritical_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYCritical_DATAFinYeraWise>("sp_create_PMayCritical_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }
        public static List<PMAYCritical_DATAFinYeraWise> sp_create_ISSR_GraphCritical_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYCritical_DATAFinYeraWise>("sp_create_ISSR_GraphCritical_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }
        public static List<PMAYCritical_DATAFinYeraWise> sp_create_AHP_GraphCritical_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYCritical_DATAFinYeraWise>("sp_create_AHP_GraphCritical_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }
        public static List<PMAYCritical_DATAFinYeraWise> sp_create_BLCS_GraphCritical_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYCritical_DATAFinYeraWise>("sp_create_BLCS_GraphCritical_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }


        public static List<PMAYCritical_DATAFinYeraWise> sp_create_Grid_Critical_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYCritical_DATAFinYeraWise>("sp_create_Grid_Critical_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }

        // try it
        public static List<PMAYCritical_DATAFinYeraWise> sp_Get_Critical_HousesStatus_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode,string component, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                                new SqlParameter("@component", component),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYCritical_DATAFinYeraWise>("sp_Get_Critical_HousesStatus @StateCode,@dcode,@cityCode,@component ,@finYear", parameters).ToList();
        }
        //HFA_GetDemandCompWiseN_e
        public static List<DemandNew> HFA_GetDemand_COMP_DIV_CITYWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string DIV, string DemandT)
        {
            try
            {
                if (DIV == null)
                    DIV = "0";
                //PMAY_Data  BuildingModel

                SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@DIV", DIV),
                new SqlParameter("@DemandT", DemandT),

        };
                return emp.Database.SqlQuery<DemandNew>("HFA_GetDemandComp_Div_Wise @StateCode,@dcode,@cityCode,@DIV,@DemandT", parameters).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally { }
        }


        public static List<FinData> Fin_PMAY_Graph_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<FinData>("sp_Finance_PMAYDATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }

        public static List<FinData> sp_Finance_BLCS_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<FinData>("sp_Finance_BLCS_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }
        public static List<FinData> sp_Finance_AHP_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<FinData>("sp_Finance_AHP_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }
        public static List<FinData> sp_Finance_ISSR_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<FinData>("sp_Finance_ISSR_DATAFinYeraWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }

        public static FinDataModel sp_Dynamic_Physical_CompWiseView_e(this EmployeeEntities emp, string state_Code, string dcode, string cityCode, string component, string finYear)
        {
            FinDataModel obj = new FinDataModel();
            //SqlParameter[] parameters = {
            //    new SqlParameter("@State_Code", state_Code),
            //    new SqlParameter("@dcode", dcode),
            //    new SqlParameter("@cityCode", cityCode),
            //    new SqlParameter("@Component", component),
            //    new SqlParameter("@FinYear", finYear),
            //     };


            var results= emp.MultipleResults("[dbo].sp_Dynamic_Physical_CompWiseView @State_Code="+ state_Code + ",@dcode="+dcode+",@cityCode="+cityCode+",@Component="+component+",@FinYear="+ finYear)
                .With<string>()
                .With<FinData>()
                .Execute();

            foreach (var item in results) {
                if (typeof(IEnumerable<FinData>).IsAssignableFrom(item.GetType())) {
                    obj.FinData=item.Cast<FinData>();
                }

                if (typeof(IEnumerable<string>).IsAssignableFrom(item.GetType())) {
                    obj.FinYear = item.Cast<string>();
                }
            }

            return obj;

            //return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Dynamic_Physical_CompWiseView @State_Code,@dcode,@cityCode,@Component,@FinYear");
        }

        public static FinMonModel sp_Phy_Monitoring_View_e1(this EmployeeEntities emp, string state_Code, string dcode, string cityCode, string component, string finYear)
        {
            FinMonModel obj = new FinMonModel();
            //SqlParameter[] parameters = {
            //    new SqlParameter("@State_Code", state_Code),
            //    new SqlParameter("@dcode", dcode),
            //    new SqlParameter("@cityCode", cityCode),
            //    new SqlParameter("@Component", component),
            //    new SqlParameter("@FinYear", finYear),
            //     };


            var results = emp.MultipleResults("[dbo].sp_Phy_Monitoring_View @State_Code='" + state_Code + "',@dcode='" + dcode + "',@cityCode='" + cityCode + "',@Component='" + component + "',@FinYear='" + finYear + "'")
                .With<string>()
                .With<FinData>()
                .Execute();

            foreach (var item in results)
            {
                if (typeof(IEnumerable<FinMonData>).IsAssignableFrom(item.GetType()))
                {
                    obj.FinMonData = item.Cast<FinMonData>();
                }

                if (typeof(IEnumerable<string>).IsAssignableFrom(item.GetType()))
                {
                    obj.FinYear = item.Cast<string>();
                }
            }

            return obj;

            //return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Dynamic_Physical_CompWiseView @State_Code,@dcode,@cityCode,@Component,@FinYear");
        }

        public static List<FinMonitorData> sp_Phy_Monitoring_View_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string component, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@State_Code", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Component", component),
                new SqlParameter("@FinYear", finYear),
                 };
            return emp.Database.SqlQuery<FinMonitorData>("sp_Phy_Monitoring_View @State_Code,@dcode,@cityCode,@Component,@FinYear", parameters).ToList();
        }


        public static List<PMAYCritical_DATAFinYeraWise> sp_Phy_Critical_View_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string component, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@State_Code", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Component", component),
                new SqlParameter("@FinYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYCritical_DATAFinYeraWise>("sp_Phy_Critical_View @State_Code,@dcode,@cityCode,@Component,@FinYear", parameters).ToList();
        }
        public static List<PMAYCritical_DATAFinYeraWise> sp_Phy_Critical_View1_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string component, string finYear)
        {
            //var finParam = new SqlParameter()
            //{
            //    ParameterName = "@FinYear",
            //    SqlDbType = SqlDbType.VarChar,
            //    IsNullable = true
            //};
            //if (finYear == null) {
            //    finParam.Value = finYear;
            //}
            //else{
            //    finParam.Value = DBNull.Value;
            //}


            List<SqlParameter> parameters = new List<SqlParameter>{
                new SqlParameter("@State_Code", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Component", component),

                 };

            if (finYear != null)
            {
                parameters.Add(new SqlParameter("@FinYear", finYear));
            }

            return emp.Database.SqlQuery<PMAYCritical_DATAFinYeraWise>("sp_Phy_Critical_View_ @State_Code,@dcode,@cityCode,@Component" + (!string.IsNullOrEmpty(finYear) ? ",@FinYear" : string.Empty), parameters.ToArray()).ToList();
        }

        //---------------------------
        public static List<PMAYCritical_DATAFinYeraWise> sp_AHP_GraphCritical_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYCritical_DATAFinYeraWise>("sp_create_AHP_GraphCritical_DATA_FinWise @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }

        public static List<PMAYCritical_DATAFinYeraWise> sp_BLC_GraphCritical_DATAFinYeraWise_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string finYear)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@StateCode", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@finYear", finYear),
                 };
            return emp.Database.SqlQuery<PMAYCritical_DATAFinYeraWise>("sp_create_BLC_GraphCritical_DATA_FinWise   @StateCode,@dcode,@cityCode,@finYear", parameters).ToList();
        }
        public static List<PMAYShortFallFinYeraWise> sp_Phy_ShortFall_View_e(this EmployeeEntities emp, string stateCode, string dcode, string cityCode, string component, string finYear)
        {
            List<SqlParameter> parameters = new List<SqlParameter>{
                new SqlParameter("@State_Code", stateCode),
                new SqlParameter("@dcode", dcode),
                new SqlParameter("@cityCode", cityCode),
                new SqlParameter("@Component", component),

                 };
            if (finYear != null)
            {
                parameters.Add(new SqlParameter("@FinYear", finYear));
            }
            return emp.Database.SqlQuery<PMAYShortFallFinYeraWise>("sp_Phy_ShortFall @State_Code,@dcode,@cityCode,@Component" + (!string.IsNullOrEmpty(finYear) ? ",@FinYear" : string.Empty), parameters.ToArray()).ToList();
        }

    }
    //--------------------







    public class FinMonModel
    {
        public IEnumerable<string> FinYear { get; set; }
        public IEnumerable<FinMonData> FinMonData { get; set; }
    }
    public class FinMonData
    {
        public string FinYear { get; set; }
        public string StateCode { get; set; }
        public string dcode { get; set; }
        public string cityCode { get; set; }

        public string Component { get; set; }
        public double? Sanctioned { get; set; }
        public double? CAReleased { get; set; }
        public double? I_to_beRel { get; set; }
        public double? II_to_beRel { get; set; }
        public double? III_to_beRel { get; set; }
        public double? Total_Liability { get; set; }
        public double? UC_Pending { get; set; }

        public string cid { get; set; }
        public double? Project_Cost { get; set; }
        public double? Central_Assistance_involved { get; set; }
        public double? FirstInstallmentReleased { get; set; }
        public double? SecondInstallmentReleased { get; set; }
        public double? ThirdInstallmentReleased { get; set; }
        public double? UC_Received { get; set; }
    }


    public class FinMonitorData
    {
        public string FinYear { get; set; }
        public string StateCode { get; set; }
        public string dcode { get; set; }
        public string cityCode { get; set; }

        public string Component { get; set; }
        public double? Sanctioned { get; set; }
        public double? CAReleased { get; set; }
        public double? I_to_beRel { get; set; }
        public double? II_to_beRel { get; set; }
        public double? III_to_beRel { get; set; }
        public double? Total_Liability { get; set; }
        public double? UC_Pending { get; set; }

        public string cid { get; set; }
        public double? Project_Cost { get; set; }
        public double? Central_Assistance_involved { get; set; }
        public double? FirstInstallmentReleased { get; set; }
        public double? SecondInstallmentReleased { get; set; }
        public double? ThirdInstallmentReleased { get; set; }
        public double? UC_Received { get; set; }
    }


    public class PMAYShortFallFinYeraWise
    {
        public string State_Code { get; set; }
        public string dcode { get; set; }
        public string cityCode { get; set; }
        public string Fin_Year { get; set; }
        public string FinYear { get; set; }
        public string Component { get; set; }

        public Nullable<double> Houses_Completed { get; set; }
        public Nullable<double> Completed { get; set; }
        public Nullable<double> Actual_Completed { get; set; }
        public Nullable<double> Shortfall_Completed { get; set; }
    }



    //--------------------


    public class PMAY_Data
    {
        public double? Sanctioned { get; set; }
        public double? Houses_Grounded { get; set; }
        public double? Houses_Completed { get; set; }
        public double? Houses_Occupied { get; set; }
        public double? Investment_in_Project { get; set; }
        public double? CentralAssistanceCommitted { get; set; }
        public double? CentralAssistanceSanctioned { get; set; }
        public double? Second_Installment_Released { get; set; }
        public double? CentralAssistanceReleased { get; set; }
        public double? Central_Assistance_Liable_for_Release { get; set; }
        public double? CASanctforRelease { get; set; }
        public double? CA_Approved { get; set; }
        public double? CentralShare { get; set; }
        public double? StateShare { get; set; }
        public double? ULBShare { get; set; }
        public double? BeneficiaryShare { get; set; }
        public double? UC_Received { get; set; }
        public string StateCode { get; set; }
        public string dcode { get; set; }
        public string cityCode { get; set; }
        public string cid { get; set; }
        public string State_Code { get; set; }
        public string Division { get; set; }
    }

     
    public class DemandNew
    {
        public string State_Name { get; set; }
        public string State_Code { get; set; }
        public string District_Code { get; set; }
        public string District_Name { get; set; }
        public string City_Code { get; set; }
        public string City_Name { get; set; }
        public double ISSR { get; set; }
        public double AHP { get; set; }
        public double BLC { get; set; }
        public double CLSS { get; set; }
        public double demand { get; set; }
        public string Cid { get; set; }
        public double DemandN { get; set; }
        public double Division { get; set; }
    }

 
    public class ComponentWiseSanctioned
    {
        public double? Component { get; set; }
        public double? Sanctioned { get; set; }
        public string StateCode { get; set; }
        public string dcode { get; set; }
        public string cityCode { get; set; }
        public string cid { get; set; }
    }

 

    public class PMAY_FinancialData
    {
        public double? HG_14_15 { get; set; }
        public double? HC_14_15 { get; set; }
        public double? HO_14_15 { get; set; }
        public double? HS_14_15 { get; set; }

        public double? HG_15_16 { get; set; }
        public double? HC_15_16 { get; set; }
        public double? HO_15_16 { get; set; }
        public double? HS_15_16 { get; set; }

        public double? HG_16_17 { get; set; }
        public double? HC_16_17 { get; set; }
        public double? HO_16_17 { get; set; }
        public double? HS_16_17 { get; set; }

        public double? HG_17_18 { get; set; }
        public double? HC_17_18 { get; set; }
        public double? HO_17_18 { get; set; }
        public double? HS_17_18 { get; set; }

        public double? HG_18_19 { get; set; }
        public double? HC_18_19 { get; set; }
        public double? HO_18_19 { get; set; }
        public double? HS_18_19 { get; set; }


        public double? HG_19_20 { get; set; }
        public double? HC_19_20 { get; set; }
        public double? HO_19_20 { get; set; }
        public double? HS_19_20 { get; set; }


        public string FINYEAR_14_15 { get; set; }
        public string FINYEAR_15_16 { get; set; }
        public string FINYEAR_16_17 { get; set; }
        public string FINYEAR_17_18 { get; set; }
        public string FINYEAR_18_19 { get; set; }
        public string FINYEAR_19_20 { get; set; }

        public string FinYear { get; set; }
        public string StateCode { get; set; }
        public string dcode { get; set; }
        public string cityCode { get; set; }
        public string cid { get; set; }
    }


 
     

    public class FinDataModel
    {
        public IEnumerable<string> FinYear { get; set; }
        public IEnumerable<FinData> FinData { get; set; }
    }

    public class FinData
    {
        public string FinYear { get; set; }
        public string StateCode { get; set; }
        public string dcode { get; set; }
        public string cityCode { get; set; }
        public string cid { get; set; }
        public double? Project_Cost { get; set; }
        public double? Central_Assistance_involved { get; set; }
        public double? FirstInstallmentReleased { get; set; }
        public double? SecondInstallmentReleased { get; set; }
        public double? ThirdInstallmentReleased { get; set; }
        public double? UC_Received { get; set; }
    }

 

    public class FinancialProgress
    {
        public double? CAI { get; set; }
        public double? CAR { get; set; }
        public string FINYEAR { get; set; }
        public string StateCode { get; set; }
        public string dcode { get; set; }
        public string cityCode { get; set; }
        public string cid { get; set; }
        public string Division { get; set; }


    }

    public class DivisionDet
    {
        public string States_UT { get; set; }
        public string Codes { get; set; }
        public string Division { get; set; }
    }

    public class ConsStatesDet
    {
        public double? SrNo { get; set; }
        public double? State1 { get; set; }
        public string StateCode { get; set; }

        public double? Demand { get; set; }
        public double? HousesSanctioned { get; set; }
        public double? CentralShare { get; set; }
        public double? StateShare { get; set; }
        public double? ULBShare { get; set; }
        public double? BeneficiaryShare { get; set; }
        //   public double? TotalCost { get; set; }
        public double? Grounded { get; set; }
        public double? Completed { get; set; }
        public double? Occupied { get; set; }
        public double? CAApproved { get; set; }
        public double? CASanctionedforRelease { get; set; }
        public double? CAReleased { get; set; }
        public double? PendingforRelease { get; set; }
        public double? IIIQ_15_16 { get; set; }
        public double? IV_Q_15_16 { get; set; }
        public double? IQ_16_17 { get; set; }

        public double? IIQ_16_17 { get; set; }
        public double? IIIQ_16_17 { get; set; }
        public double? IV_Q_16_17 { get; set; }
        public double? I_Q_17_18 { get; set; }
        public double? II_Q_17_18 { get; set; }
        public double? III_Q_17_18 { get; set; }
        public double? IV_Q_17_18 { get; set; }
        public double? I_Q_18_19 { get; set; }
        public double? II_Q_18_19 { get; set; }
        public double? III_Q_18_19 { get; set; }

        public double? IV_Q_18_19 { get; set; }
        public double? I_Q_19_20 { get; set; }
        public double? SRNo1 { get; set; }
        public double? State2 { get; set; }
        public double? CumSanctioned { get; set; }
        public double? CASanctioned_15_16 { get; set; }
        public double? CASanctioned_16_17 { get; set; }
        public double? CASanctioned_17_18 { get; set; }
        public double? CASanctioned_18_19 { get; set; }

        public double? CASanctioned_19_20 { get; set; }
        public double? CumuCAReleased { get; set; }
        public double? CumuCA_Released_15_16 { get; set; }
        public double? CumuCA_Released_16_17 { get; set; }
        public double? CumuCA_Released_17_18 { get; set; }
        public double? CumuCA_Released_18_19 { get; set; }
        public double? CumuCA_Released_19_20 { get; set; }


        public double? k { get; set; }
        public double? ll { get; set; }
        public double? HS_Cum_20_8_18 { get; set; }
        public double? HS_15_16 { get; set; }
        public double? HS15_16 { get; set; }

        public double? HS16_17 { get; set; }
        public double? HS17_18 { get; set; }
        public double? HS18_19 { get; set; }

        public double? HC14_15 { get; set; }

        public double? HC15_16 { get; set; }
        public double? HC16_17 { get; set; }
        public double? HC17_18 { get; set; }
        public double? HC18_19 { get; set; }

        public double? HO15_16 { get; set; }
        public double? HO16_17 { get; set; }
        public double? HO17_18 { get; set; }
        public double? HO18_19 { get; set; }


        //public double? HS15_16 { get; set; }


        public double? HS_16_17 { get; set; }
        public double? HS_17_18 { get; set; }

        public double? HS_18_19 { get; set; }
        public double? HS_19_20 { get; set; }
        public double? HC_20_08_18 { get; set; }
        public double? HC_14_15 { get; set; }
        public double? HC_15_16 { get; set; }
        public double? HC_16_17 { get; set; }

        public double? HC_17_18 { get; set; }
        public double? HC_18_19 { get; set; }
        public double? HC_19_20 { get; set; }
        public double? HO_Cum { get; set; }
        public double? HO_14_15 { get; set; }
        public double? HO_15_16 { get; set; }

        public double? HO_16_17 { get; set; }
        public double? HO_17_18 { get; set; }
        public double? HO_18_19 { get; set; }
        public double? HO_19_20 { get; set; }
        public string F63 { get; set; }
        public double? Expenditure { get; set; }
        public string Division { get; set; }
        public double? totalCost { get; set; }

    }


    public class CLSSWiseDivDet
    {
        public string SrNo { get; set; }
        public string state_Name { get; set; }
        public string State_Code { get; set; }

        public string District_Name { get; set; }
        public string Dcode { get; set; }
        public string City_Name { get; set; }

        public string CityCode { get; set; }
        public double? EWS_Bene { get; set; }
        public string EWS_Loan_Amt { get; set; }


        //EWS_Subsidy , sum(LIG_Subsidy) LIG_Subsidy, sum(MIG1_SubsidyAmt) MIG1_SubsidyAmt, 
        // sum(MIG2_SubsidyAmt) MIG2_SubsidyAmt

        public double? EWS_Subsidy { get; set; }
        public double? LIG_Bene { get; set; }
        public string LIG_Loan_Amt { get; set; }

        public double? LIG_Subsidy { get; set; }
        public double? MIG1_Bene { get; set; }
        public string MIG1_Loan_Amt { get; set; }

        public double? MIG1_SubsidyAmt { get; set; }
        public double? MIG2_Bene { get; set; }
        public string MIG2_Loan_Am { get; set; }

        public double? MIG2_SubsidyAmt { get; set; }
        // public string Total_LoanAmt { get; set; }
        // public string Total_SubsidyAmt { get; set; }


        // public string Total_Beneficiaries { get; set; }
        public string Cid { get; set; }
        public string Division { get; set; }

        public double? EWS_LIG_Bene { get; set; }
        public double? EWS_LIG_Loan_Amt { get; set; }
        public double? EWS_LIG_Subsidy { get; set; }
        public double? MIG_BeneTotal { get; set; }
        public double? MIG_Loan_AmtTotal { get; set; }
        public double? MIG_SubsidyAmtTotal { get; set; }
        public double? Total_LoanAmt { get; set; }
        public double? Total_SubsidyAmt { get; set; }
        public double? Total_Beneficiaries { get; set; }



    }
    public class JNNURMDivDet
    {
        public string SrNo { get; set; }
        public string Project_Code { get; set; }
        public string State { get; set; }
        public string Scheme { get; set; }
        public string Distt { get; set; }
        public string CityTown { get; set; }
        public string State_Code { get; set; }
        public string DisttCode { get; set; }
        public string SubDisttCode { get; set; }
        public string TownCode { get; set; }
        public string Project_Title { get; set; }
        public string App_Date { get; set; }
        public string Cancelled_Date { get; set; }
        public double? O_ProjectCost { get; set; }
        public double? O_CentrallShare { get; set; }
        public double? O_DwellingUnit { get; set; }
        public double? ProjCost { get; set; }
        public double? Central_Share { get; set; }
        public double? DwellingUnit { get; set; }
        public double? Central_Share_Released_Projects { get; set; }
        public double? Central_Share_Adjusted { get; set; }
        public double? Excess_ACA_Released { get; set; }
        public double? CentralShareRefundedbyStateGovt { get; set; }
        public double? UC_Received { get; set; }
        public double? Pending_UC { get; set; }
        public double? Under_Progress { get; set; }
        public double? Completed { get; set; }
        public double? Allotted { get; set; }
        public double? Occupied { get; set; }
        public double? UnOccupied { get; set; }
        public double? NonStarter { get; set; }
        public double? Grounded { get; set; }
        public double? Completed1 { get; set; }
        public double? Occupied1 { get; set; }
        public double? Division { get; set; }
    }

    public class PhysicalDetails
    {
        public string SrNo { get; set; }
        public string Division { get; set; }
        public string State { get; set; }
        public string StateCode { get; set; }
        public Nullable<double> No_Bene_EWS_LIG { get; set; }
        public Nullable<double> No_Beneficiary_MIG { get; set; }
        public Nullable<double> NoBeneficiary_Total { get; set; }
        public Nullable<double> Subsidy_EWS_LIG { get; set; }
        public Nullable<double> Subsidy_MIG { get; set; }
        public Nullable<double> Subsidy_Total { get; set; }
        public Nullable<double> Loan_TOTAL { get; set; }
    }
    public class PMAYDATAFinYeraWise
    {
        public string State_Code { get; set; }
        public string dcode { get; set; }
        public string cityCode { get; set; }
        public string Fin_Year { get; set; }
        public string FinYear { get; set; }


        public Nullable<double> Housesinvolved { get; set; }
        public Nullable<double> FundsDisbursed_in_Houses { get; set; }
        public Nullable<double> Houses_Grounded { get; set; }
        public Nullable<double> Houses_Completed { get; set; }
        public Nullable<double> HousesOccupied { get; set; }
        public Nullable<double> FirstInstallmentReleased { get; set; }
        public Nullable<double> First_Houses { get; set; }
        public Nullable<double> SecondInstallmentReleased { get; set; }
        public Nullable<double> Second_Houses { get; set; }
        public Nullable<double> ThirdInstallmentReleased { get; set; }
        public Nullable<double> Third_Houses { get; set; }

        public Nullable<double> Bene2014_15 { get; set; }
        public Nullable<double> Bene2015_16 { get; set; }
        public Nullable<double> Bene2016_17 { get; set; }
        public Nullable<double> Bene2017_18 { get; set; }
        public Nullable<double> Bene2018_19 { get; set; }
        public Nullable<double> Bene2019_20 { get; set; }
    }
    public class PMAYCritical_DATAFinYeraWise
    {
        public string State_Code { get; set; }
        public string dcode { get; set; }
        public string cityCode { get; set; }
        public string Fin_Year { get; set; }
        public string FinYear { get; set; }
        public string Component { get; set; }

        public Nullable<double> Housesinvolved { get; set; }
        public Nullable<double> Istinstyettobereleased { get; set; }
        public Nullable<double> IIndinstyettobereleased { get; set; }
        public Nullable<double> ThirdInstyettobereleased { get; set; }
        public Nullable<double> GroundedbutyettobeCompleted { get; set; }
        public Nullable<double> CompletedbutyettobeOccupied { get; set; }
    }


    public static class MultipleResultSets
    {
        public static MultipleResultSetWrapper MultipleResults(this DbContext db, string storedProcedure)
        {
            return new MultipleResultSetWrapper(db, storedProcedure);
        }

        //
        public class MultipleResultSetWrapper
        {
            private readonly DbContext _db;
            private readonly string _storedProcedure;
            public List<Func<IObjectContextAdapter, DbDataReader, IEnumerable>> _resultSets;

            public MultipleResultSetWrapper(DbContext db, string storedProcedure)
            {
                _db = db;
                _storedProcedure = storedProcedure;
                _resultSets = new List<Func<IObjectContextAdapter, DbDataReader, IEnumerable>>();
            }

            public MultipleResultSetWrapper With<TResult>()
            {
                _resultSets.Add((adapter, reader) => adapter
                    .ObjectContext
                    .Translate<TResult>(reader)
                    .ToList());

                return this;
            }

            public List<IEnumerable> Execute()
            {
                var results = new List<IEnumerable>();

                using (var connection = _db.Database.Connection)
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "EXEC " + _storedProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        var adapter = ((IObjectContextAdapter)_db);
                        foreach (var resultSet in _resultSets)
                        {
                            results.Add(resultSet(adapter, reader));
                            reader.NextResult();
                        }
                    }

                    return results;
                }
            }
        }


    }





}


