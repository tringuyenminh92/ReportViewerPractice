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
    
    public partial class T_Piping_Hour_Details
    {
        public int Piping_hrs_ID { get; set; }
        public string Hour_Type { get; set; }
        public string Hour_Title { get; set; }
        public string Hour_Description { get; set; }
        public Nullable<double> Hour_Value { get; set; }
        public Nullable<bool> flgStatus { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}