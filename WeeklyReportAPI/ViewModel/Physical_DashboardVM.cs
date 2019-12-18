using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class Physical_DashboardVM
    {
        public int sid { get; set; }
        public string SrNo { get; set; }
        public string State1 { get; set; }
        public string  StateCode { get; set; }
        public string Demand { get; set; }
        public string Houses_Sanctioned { get; set; }  // correction
        public string CentralShare { get; set; }

        public string StateShare { get; set; }
        public string ULBShare { get; set; }
        public string BeneficiaryShare { get; set; }
        public string TotalCost { get; set; }
        public string Grounded { get; set; }
        public string Completed { get; set; }
        public string Occupied { get; set; }
        public string CAApproved { get; set; }

        public string CASanctionedforRelease { get; set; }
        public string CAReleased { get; set; }
        public string PendingforRelease { get; set; }
        public string IIIQ_15_16 { get; set; }
        public string IV_Q_15_16 { get; set; }
        public string IQ_16_17 { get; set; }
        public string IIQ_16_17 { get; set; }
        public string IIIQ_16_17 { get; set; }

        public string IV_Q_16_17 { get; set; }
        public string I_Q_17_18 { get; set; }
        public string II_Q_17_18 { get; set; }
        public string III_Q_17_18 { get; set; }
        public string IV_Q_17_18 { get; set; }
        public string I_Q_18_19 { get; set; }
        public string II_Q_18_19 { get; set; }
        public string III_Q_18_19 { get; set; }

        public string IV_Q_18_19 { get; set; }
        public string I_Q_19_20 { get; set; }
        public string SRNo1 { get; set; }
        public string State2 { get; set; }
        public string CumSanctioned { get; set; }
        public string CASanctioned_15_16 { get; set; }
        public string CASanctioned_16_17 { get; set; }
        public string CASanctioned_17_18 { get; set; }

        public string CASanctioned_18_19 { get; set; }
        public string CASanctioned_19_20 { get; set; }
        public string CumuCAReleased { get; set; }
        
        public string CumuCA_Released_15_16 { get; set; }
        public string CumuCA_Released_16_17 { get; set; }
        public string CumuCA_Released_17_18 { get; set; }
        public string CumuCA_Released_18_19 { get; set; }

        public string CumuCA_Released_19_20 { get; set; }
     //   public string k { get; set; }
     //   public string ll { get; set; }
        public string HS_Cum_20_8_18 { get; set; }

        public string HS_15_16 { get; set; }
        public string HS_16_17 { get; set; }
        public string HS_17_18 { get; set; }
        public string HS_18_19 { get; set; }

        public string HS_19_20 { get; set; }
        public string HC_20_08_18 { get; set; }
        public string HC_14_15 { get; set; }
        public string HC_15_16 { get; set; }

        public string HC_16_17 { get; set; }
        public string HC_17_18 { get; set; }
        public string HC_18_19 { get; set; }
        public string HC_19_20 { get; set; }

        public string HO_Cum { get; set; }
        public string HO_14_15 { get; set; }
        public string HO_15_16 { get; set; }
        public string HO_16_17 { get; set; }

        public string HO_17_18 { get; set; }
        public string HO_18_19 { get; set; }
        public string HO_19_20 { get; set; }
     //   public string F63 { get; set; }

        public string Expenditure { get; set; }
        public string Division { get; set; }
        

    }
}