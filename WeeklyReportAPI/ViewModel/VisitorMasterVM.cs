using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class VisitorMasterVM
    {
        public long SrNo { get; set; }
        public Nullable<long> VisitorId { get; set; }
        public Nullable<long> StateId { get; set; }
        public Nullable<long> Dcode { get; set; }
        public Nullable<long> CityCode { get; set; }
        public string ProjectName { get; set; }
        public string Notes { get; set; }
        public string Description { get; set; }
        public string Extra { get; set; }
        public string Userid { get; set; }
        public Nullable<bool> sFlag { get; set; }
        public string ImageNames { get; set; }
        public string AudioNames { get; set; }
        public string VideoNames { get; set; }
    }
}