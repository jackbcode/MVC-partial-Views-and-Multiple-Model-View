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
    
    public partial class icp_yyxref
    {
        public int Branch_ { get; set; }
        public string Key_ { get; set; }
        public string C_Type { get; set; }
        public string Forw_short_ref { get; set; }
        public string Forw_client_ref { get; set; }
        public string Back_client_ref { get; set; }
        public string Back_short_ref { get; set; }
        public string C_Key { get; set; }
        public Nullable<int> RefreshGenerationId { get; set; }
        public Nullable<System.DateTime> LastUpdatedTime { get; set; }
    }
}