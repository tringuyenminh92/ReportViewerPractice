//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportViewerPractice
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_sap_customer
    {
        public int Customer { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Street { get; set; }
        public string POBox { get; set; }
        public string City { get; set; }
        public string Rg { get; set; }
        public string PostalCode { get; set; }
        public string Cty { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> SalesOfficeId { get; set; }
        public Nullable<int> SalesGroupId { get; set; }
    
        public virtual T_SalesGroup T_SalesGroup { get; set; }
        public virtual T_SalesOffice T_SalesOffice { get; set; }
    }
}
