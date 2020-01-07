using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeeklyReportAPI.Models;

namespace WeeklyReportAPI.ViewModel
{
    public class AllFnAPI
    {
        public List<Projct_Details> Project_DetailVM { get; set; }
        public List<Project_Brief_Detail> Project_Brief_DetailVM { get; set; }
        public List<Project_Fund_Release> Project_Fund_ReleaseVM { get; set; }
        public List<Project_UC_Submission> Project_UC_SubmissionVM { get; set; }
    }
}