using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class Project_Fund_ReleaseVM
    {
        public long ReleaseId { get; set; }
        public string Codes { get; set; }
        public string Dcode { get; set; }
        public string CityCode { get; set; }
        public string Release { get; set; }
        public string Source { get; set; }
        public string SanctionNumber { get; set; }
        public Nullable<double> HFAAmount { get; set; }
        public Nullable<double> TSPAmount { get; set; }
        public Nullable<double> SCSPAmount { get; set; }
        public string ProjectCode { get; set; }
        public string Installment { get; set; }
        public Nullable<System.DateTime> TxtSCSPDate { get; set; }
        public Nullable<double> FirstInstallment { get; set; }
    }
}