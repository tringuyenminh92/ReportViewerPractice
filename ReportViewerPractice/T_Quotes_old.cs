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
    
    public partial class T_Quotes_old
    {
        public T_Quotes_old()
        {
            this.T_Quote_Sections_old = new HashSet<T_Quote_Sections_old>();
        }
    
        public int auto { get; set; }
        public string Quote_number { get; set; }
        public string quoter { get; set; }
        public System.DateTime quote_started_date { get; set; }
        public System.DateTime quote_rec_date { get; set; }
        public System.DateTime quote_due_date { get; set; }
        public System.DateTime quote_issued_date { get; set; }
        public Nullable<int> sales_office { get; set; }
        public Nullable<int> sales_group { get; set; }
        public string cust_name { get; set; }
        public string cust_street { get; set; }
        public string cust_city { get; set; }
        public string cust_zip { get; set; }
        public string cust_state { get; set; }
        public string cust_country { get; set; }
        public string cust_sap_number { get; set; }
        public string contact_salutation { get; set; }
        public string contact_fname { get; set; }
        public string contact_lname { get; set; }
        public string contact_telbus { get; set; }
        public string contact_telmobile { get; set; }
        public string contact_telfax { get; set; }
        public string contact_email { get; set; }
        public string description { get; set; }
        public Nullable<double> est_price { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> LineItemIncrement { get; set; }
        public Nullable<int> TechPositionIncrement { get; set; }
        public string Approver { get; set; }
        public string Status { get; set; }
        public string ApproverComments { get; set; }
    
        public virtual ICollection<T_Quote_Sections_old> T_Quote_Sections_old { get; set; }
    }
}
