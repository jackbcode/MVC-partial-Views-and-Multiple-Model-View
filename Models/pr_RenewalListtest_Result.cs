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

    public partial class pr_RenewalListtest_Result
    {
        [Display(Name = "Renewal Date")]
        public string Renewal_Date { get; set; }
        public string Reference { get; set; }

        [Display(Name = "Client Name")]
        public string ClientName { get; set; }
        public string Telephone { get; set; }

        [Display(Name = "Last Annual Premium")]
        public Nullable<decimal> Last_Annual_Premium { get; set; }

        [Display(Name = "This Years Premium")]
        public decimal This_Years_Premium { get; set; }

        [Display(Name = "Alternative Premium")]
        public decimal Alternative_Premium { get; set; }

        [Display(Name = "Claims Made")]
        public string Claims_Made { get; set; }
        public Nullable<System.DateTime> CallBackDate { get; set; }
        public Nullable<int> OutcomeId { get; set; }
    }
}
