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
    
    public partial class icp_dpstpqueue
    {
        public int Branch_ { get; set; }
        public string Key_ { get; set; }
        public Nullable<int> Suffix { get; set; }
        public string C_Ref { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> In_date { get; set; }
        public Nullable<int> In_tickcount { get; set; }
        public Nullable<System.DateTime> Proc_date { get; set; }
        public Nullable<int> Proc_tickcount { get; set; }
        public string In_time { get; set; }
        public string Proc_time { get; set; }
        public string Cc_remarks { get; set; }
        public Nullable<int> Manual_YENO_VTId { get; set; }
        public Nullable<int> RefreshGenerationId { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    }
}
