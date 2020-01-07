using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class Project_UC_SubmissionVM
    {
        public long UCID { get; set; }
        public string Codes { get; set; }
        public string Dcode { get; set; }
        public string CityCode { get; set; }
        public string ProjectCode { get; set; }
        public string SanctionNumber { get; set; }
        public Nullable<long> ReleaseId { get; set; }
        public string Release { get; set; }
        public string Installment { get; set; }
        public string LetterNo { get; set; }
        public Nullable<System.DateTime> UCDate { get; set; }
        public Nullable<double> UCAmount { get; set; }
    }
}