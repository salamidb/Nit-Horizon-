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
    using System.ComponentModel.DataAnnotations;
    
    public partial class AttendIntegrity
    {
        [DataType(DataType.Text )]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-mm-dd}")]
        [Display(Name = "Employee ID NO")]
        public int Eno { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-mm-dd}")]
        [Display(Name = "From")]
        public System.DateTime CheckFDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "To")]
        public System.DateTime CheckTDate { get; set; }


       
        public string Checked { get; set; }
    }
}
