using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class JnNURM_TableVM
    {
      //  public string id { get; set; }
        public string SrNo { get; set; }
        public string Project_Code { get; set; }
        public string State { get; set; }
        public string Scheme { get; set; }
        public string Distt { get; set; }
        public string CityTown { get; set; }
        public string State_Code { get; set; }
        public string DisttCode { get; set; }
        public string SubDisttCode { get; set; }

        public string TownCode { get; set; }
        public string Project_Title { get; set; }
        public string App_Date { get; set; }
        public string Cancelled_Date { get; set; }
        public string O_ProjectCost { get; set; }
        public string O_CentrallShare { get; set; }
        public string O_DwellingUnit { get; set; }

        public string ProjCost { get; set; }
        public string Central_Share { get; set; }
        public string DwellingUnit { get; set; }
        public string Central_Share_Released_Projects { get; set; }
        public string Central_Share_Adjusted { get; set; }
        public string Excess_ACA_Released { get; set; }
        public string CentralShareRefundedbyStateGovt { get; set; }

        public string UC_Received { get; set; }
        public string Pending_UC { get; set; }
        public string Under_Progress { get; set; }
        public string Completed { get; set; }
        public string Allotted { get; set; }
        public string Occupied { get; set; }
        public string UnOccupied { get; set; }

        public string NonStarter { get; set; }
        public string Grounded { get; set; }
        public string Completed1 { get; set; }
        public string Occupied1 { get; set; }
        public string Division { get; set; }

    }
}