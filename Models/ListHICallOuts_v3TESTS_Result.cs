//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test__Connection.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class ListHICallOuts_v3TESTS_Result
    {
        [Display(Name = "Quote Reference")]
        public string Quote_Ref { get; set; }
        public string Name { get; set; }
        public string Premium { get; set; }
        public string Telephone { get; set; }

        [Display(Name = "Quote Source")]
        public string Quote_Source { get; set; }

        [Display(Name = "Quote Date")]
        public string Quote_Date { get; set; }

        [Display(Name = "Cover Date")]
        public string Cover_Date { get; set; }

        [Display(Name = "Call Back Date")]
        public Nullable<System.DateTime> CallBackDate { get; set; }
        public Nullable<int> OutcomeId { get; set; }
    }
}
