using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class PMAY_PROJECTS_FinVM
    {
        public string SrNo { get; set; }
        public string Project_Code { get; set; }
        public string Annexure_ID { get; set; }
        public string Component { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string Dcode { get; set; }
        public string sunDisttCode { get; set; }

        public string CityCode { get; set; }
        public string Project_Name { get; set; }
        public string CSMCDate { get; set; }
        public string CSMCNo { get; set; }
        public string FinYear { get; set; }

        public string NoofProjects { get; set; }
        public string Project_Cost { get; set; }
        public string Central_Assistance_involved { get; set; }
        public string State_Grant { get; set; }
        public string ULBShare { get; set; }

        public string BeneficiaryShare { get; set; }
        public string Released_throug_EBR { get; set; }
        public string CASanctionedForRel { get; set; }
        public string FirstInstallmentReleased { get; set; }
        public string SecondInstallmentReleased { get; set; }
        public string ThirdInstallmentReleased { get; set; }
        public string CentralAssistanceReleased { get; set; }
        public string UC_Received { get; set; }
        public string UC_Pending { get; set; }
        public string Housesinvolved { get; set; }

        public string FundsDisbursed_in_Houses { get; set; }
        public string Houses_Grounded { get; set; }
        public string HousesUnderProgress { get; set; }
        public string Houses_Completed { get; set; }
        public string HousesAllotted { get; set; }

        public string HousesOccupied { get; set; }
        public string Houses_yetto_Grounded { get; set; }
        public string Cid { get; set; }
    }
}