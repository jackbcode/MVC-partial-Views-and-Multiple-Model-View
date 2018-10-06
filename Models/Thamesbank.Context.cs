﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ThamesbankEntities10 : DbContext
    {
        public ThamesbankEntities10()
            : base("name=ThamesbankEntities10")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<DateRangeLapseTEST_Result> DateRangeLapseTEST(Nullable<System.DateTime> lowerDate, Nullable<System.DateTime> upperDate)
        {
            var lowerDateParameter = lowerDate.HasValue ?
                new ObjectParameter("LowerDate", lowerDate) :
                new ObjectParameter("LowerDate", typeof(System.DateTime));
    
            var upperDateParameter = upperDate.HasValue ?
                new ObjectParameter("UpperDate", upperDate) :
                new ObjectParameter("UpperDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DateRangeLapseTEST_Result>("DateRangeLapseTEST", lowerDateParameter, upperDateParameter);
        }
    
        public virtual ObjectResult<ListHICallOuts_v3TESTS_Result> ListHICallOuts_v3TESTS(string reportType, Nullable<System.DateTime> lowerDate, Nullable<System.DateTime> upperDate, Nullable<System.DateTime> lowerDateCover, Nullable<System.DateTime> upperDateCover)
        {
            var reportTypeParameter = reportType != null ?
                new ObjectParameter("ReportType", reportType) :
                new ObjectParameter("ReportType", typeof(string));
    
            var lowerDateParameter = lowerDate.HasValue ?
                new ObjectParameter("LowerDate", lowerDate) :
                new ObjectParameter("LowerDate", typeof(System.DateTime));
    
            var upperDateParameter = upperDate.HasValue ?
                new ObjectParameter("UpperDate", upperDate) :
                new ObjectParameter("UpperDate", typeof(System.DateTime));
    
            var lowerDateCoverParameter = lowerDateCover.HasValue ?
                new ObjectParameter("LowerDateCover", lowerDateCover) :
                new ObjectParameter("LowerDateCover", typeof(System.DateTime));
    
            var upperDateCoverParameter = upperDateCover.HasValue ?
                new ObjectParameter("UpperDateCover", upperDateCover) :
                new ObjectParameter("UpperDateCover", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListHICallOuts_v3TESTS_Result>("ListHICallOuts_v3TESTS", reportTypeParameter, lowerDateParameter, upperDateParameter, lowerDateCoverParameter, upperDateCoverParameter);
        }
    }
}