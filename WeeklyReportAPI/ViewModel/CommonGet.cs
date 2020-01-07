using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeeklyReportAPI.Models;

namespace WeeklyReportAPI.ViewModel
{
    public class CommonGet
    {
        public List<CLSS_MAster> CLSS_MASTERVMS { get; set; }
        public List<PMAY_PROJECTS_Fin> PMAY_PROJECTS_FinVM { get; set; }
    }
}