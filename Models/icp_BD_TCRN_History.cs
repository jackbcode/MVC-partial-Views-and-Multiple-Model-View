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
    using System.Collections.Generic;
    
    public partial class icp_BD_TCRN_History
    {
        public int Branch_ { get; set; }
        public string Key_ { get; set; }
        public string ClientRef_ { get; set; }
        public string PolicyRef_ { get; set; }
        public Nullable<int> Sequence_ { get; set; }
        public string Operator { get; set; }
        public string Insco { get; set; }
        public string Scheme { get; set; }
        public Nullable<System.DateTime> InviteDate { get; set; }
        public string Excess { get; set; }
        public Nullable<decimal> Premium { get; set; }
        public Nullable<decimal> Charge { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Notes1 { get; set; }
        public string Notes2 { get; set; }
        public string Notes3 { get; set; }
        public Nullable<System.DateTime> History_ { get; set; }
        public Nullable<int> RefreshGenerationId { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    }
}