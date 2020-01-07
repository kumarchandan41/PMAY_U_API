using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyReportAPI.ViewModel
{
    public class Physical_Progress_ReportVM
    {
        public long PhysicalProgressId { get; set; }
        public string StateName { get; set; }
        public string DisttName { get; set; }
        public string CityName { get; set; }
        public string Codes { get; set; }
        public string Dcode { get; set; }
        public string CityCode { get; set; }

        public string Scheme { get; set; }
        public string ProjectCode { get; set; }
        public string CentralAssistance { get; set; }
        public string TotalSanction { get; set; }
        public string GroundLevel { get; set; }
        public string Pinth { get; set; }
        public string LinterLevel { get; set; }
        public string RoofLevel { get; set; }
        public string SuperStructure { get; set; }
        public string FinishingStage { get; set; }
        public Nullable<decimal> TotalProgressHouse { get; set; }
        public Nullable<decimal> ConstructionCompleted { get; set; }
        public string NonStarterHouse { get; set; }
        public string PowerSupply { get; set; }
        public string WaterSupply { get; set; }
        public string DrainageSupply { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<decimal> TotalHouseOccupiedBeneficiary { get; set; }
    }
}