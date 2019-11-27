using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class StateMap
    {
        public string map { get; set; }
        public string hover { get; set; }
        public StateData data { get; set; }
    }
    public class StateData {
        public double? Grounded { get; set; }
        public double? Occupied { get; set; }
        public double? Completed { get; set; }
    }
}