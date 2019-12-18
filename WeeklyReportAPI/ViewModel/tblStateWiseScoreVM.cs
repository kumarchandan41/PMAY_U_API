using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class tblStateWiseScoreVM
    {
        public long ScoreId { get; set; }
        public int StateId { get; set; }
        public string Codes { get; set; }
        public string StateName { get; set; }

        public string Sanction_vs_Demand { get; set; }
        public string Grounding_Sanction { get; set; }

        public string Completion_vs_Sanction { get; set; }
        public string BLC_Houses_Geotagged { get; set; }
        public string Relelase_vs_Sanction { get; set; }
        public string MIS_Annexure_uploading { get; set; }
        public string Beneficiary_Attachment { get; set; }

        public string Reforms_Achievement { get; set; }
        public string JN_Houses_vacant { get; set; }
        public string Population_Census_2011 { get; set; }
        public string TG_12_Housing_Shortage { get; set; }
        public string Aadhar_Coverage { get; set; }
        public string Cities_included_in_Mission { get; set; }
        public string Total_Demand_as_per_Road_map { get; set; }

        public string Demand_met { get; set; }
        public string Per_Demand_met { get; set; }

        public string Total_PMAY_U_Houses_ISSR_AHP_BLC_CLSS { get; set; }
        public string Valid_Aadhar_Beneficiaries { get; set; }
        public string Bene_Percentage { get; set; }
        public string HFAPoA_funds_Released { get; set; }
        public string HFAPoA_Received { get; set; }


        public string HFAPoA_Status { get; set; }
        public string ISSR_NOP { get; set; }
        public string AHP_NOP { get; set; }
        public string BLC_NOP { get; set; }

        public string ISSR_Sanct_for_Release { get; set; }
        public string AHP_Sanct_for_Release { get; set; }
        public string BLC_Sanct_for_Release { get; set; }
        public string ISSR_CA_Released { get; set; }
        public string AHP_CA_Released { get; set; }
        public string BLC_CA_Released { get; set; }

        public string ISSR_Balance_for_Release { get; set; }
        public string AHP_Balance_for_Release { get; set; }
        public string BLC_Balance_for_Release { get; set; }
        public string ISSR_Houses_Sanctioned { get; set; }
        public string AHP_Houses_Sanctioned { get; set; }
        public string BLC_Houses_Sanctioned { get; set; }

        public string ISSR_Grounded { get; set; }
        public string AHP_Grounded { get; set; }
        public string BLC_Grounded { get; set; }
        public string ISSR_Completed { get; set; }
        public string AHP_Completed { get; set; }
        public string BLC_Completed { get; set; }

        public string PMAY_Funds_Released { get; set; }
        public string PMAY_Ucs_Received { get; set; }
        public string PMAY_UC_Pending { get; set; }
        public string PMAY_Houses_Occupied { get; set; }
        public string Reforms { get; set; }
        public string Reforms_Achieved { get; set; }

        public string SLTC_Funds_Released_RsinnCr { get; set; }
        public string SLTC_Specialists_Approved { get; set; }
        public string SLTC_Specialists_in_Place { get; set; }
        public string CLTC_Funds_Released_RsinCr { get; set; }
        public string CLTC_Specialists_Approved { get; set; }
        public string CLTC_Specialists_in_Place { get; set; }
        public string Projects_Approved { get; set; }
        public string Projects_uploaded { get; set; }

        public string Percent_Projects_uploaded { get; set; }
        public string BLC_Houses_Approved { get; set; }
        public string BLC_Houses_Grounded { get; set; }
        public string BLC_Houses_Geo_Tagged { get; set; }
        public string CLSS_MIS_Survey { get; set; }
        public string CLSS_Beneficiaries_EWS_LIG_MIG { get; set; }
        public string CLSS_Subsidy_EWS_LIG_MIG { get; set; }

        public string JN_Houses_Sanctioned { get; set; }
        public string JN_Houses_Completed { get; set; }
        public string JN_Houses_Occupied { get; set; }

        public string JN_Houses_In_Progress { get; set; }
        public string JN_Houses_Unoccupied { get; set; }
        public string JN_Houses_Non_Starter { get; set; }
        public string JN_UC_Pending { get; set; }

        public string RAY_Houses_Sanctioned { get; set; }
        public string RAY_Houses_Completed { get; set; }
        public string RAY_Houses_Occupied { get; set; }

        public string RAY_Houses_In_Progress { get; set; }
        public string RAY_Houses_Unoccupied { get; set; }
        public string RAY_Houses_Non_Starter { get; set; }
        public string RAY_UC_Pending { get; set; }

    }
}