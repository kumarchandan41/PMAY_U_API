using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class CityMasterVM
    {
        public string City { get; set; }
        public string CityCode { get; set; }
        public string Dcode { get; set; }
        public string District { get; set; }

        public string CityId { get; set; }
        
        public string StatesName { get; set; }
        public string Codes { get; set; }
        public string ActiveFlag { get; set; }
        public string Status { get; set; }
    }
}