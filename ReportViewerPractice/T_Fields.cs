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
    
    public partial class T_Fields
    {
        public T_Fields()
        {
            this.T_Fields_Value = new HashSet<T_Fields_Value>();
        }
    
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public string FieldDescription { get; set; }
    
        public virtual ICollection<T_Fields_Value> T_Fields_Value { get; set; }
    }
}
