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
    
    public partial class icp_brhist
    {
        public int Branch_ { get; set; }
        public string Key_ { get; set; }
        public string ClientRef_ { get; set; }
        public string PolicyRef_ { get; set; }
        public Nullable<int> LedgerSuffix_ { get; set; }
        public Nullable<int> Suffix_ { get; set; }
        public string Polref { get; set; }
        public Nullable<int> Tran_suff { get; set; }
        public Nullable<int> Suffix { get; set; }
        public string C_Type { get; set; }
        public string Paymethod { get; set; }
        public Nullable<System.DateTime> Pay_dt { get; set; }
        public Nullable<decimal> Pay_amt { get; set; }
        public Nullable<System.DateTime> Dt_settled { get; set; }
        public Nullable<decimal> Settle_amt { get; set; }
        public Nullable<int> Icno_INSC_VTId { get; set; }
        public Nullable<int> Receipt_no { get; set; }
        public string Ref_no { get; set; }
        public string Operator { get; set; }
        public string Settlement_ref { get; set; }
        public Nullable<int> Settlement_id { get; set; }
        public Nullable<int> RefreshGenerationId { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    }
}
