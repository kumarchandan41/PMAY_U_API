using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class CLSS_MASTERVM
    {
        public string SrNo { get; set; }
        public string State { get; set; }
        public string StateCode { get; set; }
        public string Loan_EWS_LIG { get; set; }
        public string Subsidy_EWS_LIG { get; set; }
        public string No_Beneficiary_EWS_LIG { get; set; }
        public string Loan_MIG { get; set; }
        public string Subsidy_MIG { get; set; }
        public string No_Beneficiary_MIG { get; set; }
        public string Loan_TOTAL { get; set; }
        public string Subsidy_Total { get; set; }
        public string NoBeneficiary_Total { get; set; }
    }
}