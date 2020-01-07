using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class Project_Brief_DetailVM
    {
        public long ProjectId { get; set; }
        public string Codes { get; set; }
        public string Dcode { get; set; }
        public string CityCode { get; set; }
        public string Scheme { get; set; }
        public string Component { get; set; }
        public string ProjectCode { get; set; }
        public string NodalAgency { get; set; }
        public string ImplementingAgency { get; set; }
        public Nullable<System.DateTime> SLSMCDate { get; set; }
        public string WhetherSlum { get; set; }
        public Nullable<double> HousingCost { get; set; }
        public Nullable<double> InfaCost { get; set; }
        public Nullable<double> OtherCost { get; set; }
        public Nullable<double> General { get; set; }
        public Nullable<double> SC { get; set; }
        public Nullable<double> ST { get; set; }
        public Nullable<double> OBC { get; set; }
        public Nullable<double> OtherEWS { get; set; }
        public Nullable<double> Minority { get; set; }
        public Nullable<double> Joint { get; set; }
        public Nullable<double> Female { get; set; }
        public Nullable<double> Male { get; set; }
        public Nullable<double> Transgender { get; set; }
        public Nullable<double> TotalHouses { get; set; }
        public string PDF { get; set; }
    }
}