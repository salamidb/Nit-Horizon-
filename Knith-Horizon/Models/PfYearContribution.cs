//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Knith_Horizon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PfYearContribution
    {
        public int Eno { get; set; }
        public System.DateTime PMon { get; set; }
        public Nullable<decimal> PfSal { get; set; }
        public Nullable<decimal> EPF { get; set; }
        public Nullable<decimal> EPF_Diff { get; set; }
        public Nullable<decimal> PensionFund { get; set; }
        public Nullable<int> Absent_Days { get; set; }
    }
}
