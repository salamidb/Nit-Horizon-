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
    
    public partial class Reminder
    {
        public string Rep_Type { get; set; }
        public string Duration { get; set; }
        public Nullable<System.DateTime> From_Date { get; set; }
        public Nullable<System.DateTime> To_Date { get; set; }
        public Nullable<int> Status { get; set; }
        public string Comp_Code { get; set; }
    }
}
