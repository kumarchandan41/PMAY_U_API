using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class DistrictMasterVM
    {
        public long DisttId { get; set; }
        public string District { get; set; }
        public string Distt { get; set; }
        public string StateCode { get; set; }
        public string Dcode { get; set; }
        public string sunDisttCode { get; set; }
        public string BackwardDistrict { get; set; }
        public string Minority { get; set; }
        public string ActiveFlag { get; set; }
        public string Status { get; set; }
        public string StatesName { get; set; }

    }
}