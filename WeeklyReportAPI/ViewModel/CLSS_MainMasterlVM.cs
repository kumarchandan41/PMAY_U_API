using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class CLSS_MainMasterVM
    {
        public string SrNo { get; set; }
        public string state_Name { get; set; }
        public string State_Code { get; set; }
        public string District_Name { get; set; }
        public string Dcode { get; set; }
        public string City_Name { get; set; }
        public string CityCode { get; set; }
        public string EWS_Bene { get; set; }
        public string EWS_Loan_Amt { get; set; }
        public string EWS_Subsidy { get; set; }
        public string LIG_Bene { get; set; }
        public string LIG_Loan_Amt { get; set; }
        public string LIG_Subsidy { get; set; }
        public string MIG1_Bene { get; set; }

        public string MIG1_Loan_Amt { get; set; }
        public string MIG1_SubsidyAmt { get; set; }
        public string MIG2_Bene { get; set; }
        public string MIG2_Loan_Am { get; set; }
        public string MIG2_SubsidyAmt { get; set; }

        public string Total_LoanAmt { get; set; }
        public string Total_SubsidyAmt { get; set; }
        public string Total_Beneficiaries { get; set; }
        public string Cid { get; set; }        
    }
}