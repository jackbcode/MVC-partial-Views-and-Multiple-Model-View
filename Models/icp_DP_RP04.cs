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
    
    public partial class icp_DP_RP04
    {
        public int Branch_ { get; set; }
        public string Key_ { get; set; }
        public string ClientRef_ { get; set; }
        public string PolicyRef_ { get; set; }
        public Nullable<int> Sequence_ { get; set; }
        public string C_Name { get; set; }
        public string Sortcode { get; set; }
        public string Scheme { get; set; }
        public string AccountNumber { get; set; }
        public string Bank { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<decimal> MonthlyInstalme { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public Nullable<decimal> TotalPayment { get; set; }
        public Nullable<int> RefreshGenerationId { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    }
}