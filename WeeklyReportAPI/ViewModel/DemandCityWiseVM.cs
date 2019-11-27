using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class DemandCityWiseVM
    {
        public string SrNo { get; set; }
        public string State_Name { get; set; }
        public string State_Code { get; set; }
        public string District_Name { get; set; }
        public string District_Code { get; set; }
        public string CITY_Name { get; set; }
        public string City_Code { get; set; }
        public string ISSR { get; set; }
        public string AHP { get; set; }
        public string BLC { get; set; }
        public string CLSS { get; set; }
        public string demand { get; set; }
        public int? Cid { get; set; }
        public string Division { get; set; }
    }
}