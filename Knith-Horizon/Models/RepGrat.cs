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
    
    public partial class RepGrat
    {
        public int id { get; set; }
        public Nullable<int> Eno { get; set; }
        public Nullable<System.DateTime> DOL { get; set; }
        public Nullable<decimal> Grat_Amt { get; set; }
        public Nullable<decimal> Till_Paid { get; set; }
        public string Bank_name { get; set; }
        public Nullable<decimal> PayAmount { get; set; }
        public Nullable<System.DateTime> PaidOn { get; set; }
        public string RefNo { get; set; }
        public Nullable<System.DateTime> RefDate { get; set; }
        public Nullable<int> TotYears { get; set; }
    }
}
