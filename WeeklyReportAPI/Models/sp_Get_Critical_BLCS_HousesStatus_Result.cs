//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeeklyReportAPI.Models
{
    using System;
    
    public partial class sp_Get_Critical_BLCS_HousesStatus_Result
    {
        public string FinYear { get; set; }
        public Nullable<double> Housesinvolved { get; set; }
        public Nullable<double> Istinstyettobereleased { get; set; }
        public Nullable<double> IIndinstyettobereleased { get; set; }
        public Nullable<double> ThirdInstyettobereleased { get; set; }
        public Nullable<double> GroundedbutyettobeCompleted { get; set; }
        public Nullable<double> CompletedbutyettobeOccupied { get; set; }
    }
}
