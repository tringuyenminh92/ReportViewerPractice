﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuoteSystemLEntities : DbContext
    {
        public QuoteSystemLEntities()
            : base("name=QuoteSystemLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<T_Accumulators> T_Accumulators { get; set; }
        public DbSet<T_ANSIPiping> T_ANSIPiping { get; set; }
        public DbSet<T_AppRole> T_AppRole { get; set; }
        public DbSet<T_BillToCustomerDetails> T_BillToCustomerDetails { get; set; }
        public DbSet<T_Conduit> T_Conduit { get; set; }
        public DbSet<T_Configuration> T_Configuration { get; set; }
        public DbSet<T_DocumentLink> T_DocumentLink { get; set; }
        public DbSet<T_DocumentLinkCategory> T_DocumentLinkCategory { get; set; }
        public DbSet<T_Fields> T_Fields { get; set; }
        public DbSet<T_Fields_Value> T_Fields_Value { get; set; }
        public DbSet<T_Flange_type> T_Flange_type { get; set; }
        public DbSet<T_FlangePad> T_FlangePad { get; set; }
        public DbSet<T_FlangePattern> T_FlangePattern { get; set; }
        public DbSet<T_Flanges> T_Flanges { get; set; }
        public DbSet<T_Labor> T_Labor { get; set; }
        public DbSet<T_LABOR_DATA> T_LABOR_DATA { get; set; }
        public DbSet<T_labor_variables> T_labor_variables { get; set; }
        public DbSet<T_LaborCostFactors> T_LaborCostFactors { get; set; }
        public DbSet<T_LaborCostFactors_ShippableAssembly> T_LaborCostFactors_ShippableAssembly { get; set; }
        public DbSet<T_MotorHorsePower> T_MotorHorsePower { get; set; }
        public DbSet<T_MotorManufacturer> T_MotorManufacturer { get; set; }
        public DbSet<T_MotorRPM> T_MotorRPM { get; set; }
        public DbSet<T_MotorVoltage> T_MotorVoltage { get; set; }
        public DbSet<T_Piping_Clamp> T_Piping_Clamp { get; set; }
        public DbSet<T_Piping_Fitting> T_Piping_Fitting { get; set; }
        public DbSet<T_Piping_Flang> T_Piping_Flang { get; set; }
        public DbSet<T_Piping_Hour_Details> T_Piping_Hour_Details { get; set; }
        public DbSet<T_Piping_Kick> T_Piping_Kick { get; set; }
        public DbSet<T_Piping_NPT_PipeConn> T_Piping_NPT_PipeConn { get; set; }
        public DbSet<T_Piping_PipeConnect> T_Piping_PipeConnect { get; set; }
        public DbSet<T_Piping_ThrededFitting> T_Piping_ThrededFitting { get; set; }
        public DbSet<T_Piping_TubeConnect> T_Piping_TubeConnect { get; set; }
        public DbSet<T_PipingComponent_Values> T_PipingComponent_Values { get; set; }
        public DbSet<T_PipingComponents> T_PipingComponents { get; set; }
        public DbSet<T_PipingLabor_Data> T_PipingLabor_Data { get; set; }
        public DbSet<T_PipingLaborConfiguration> T_PipingLaborConfiguration { get; set; }
        public DbSet<T_PipingLaborForCSSS> T_PipingLaborForCSSS { get; set; }
        public DbSet<T_PipingLaborPaintRequirement> T_PipingLaborPaintRequirement { get; set; }
        public DbSet<T_PipingMaterial> T_PipingMaterial { get; set; }
        public DbSet<T_PipingSchedule> T_PipingSchedule { get; set; }
        public DbSet<T_PipingSchemMapping> T_PipingSchemMapping { get; set; }
        public DbSet<T_PipingSize> T_PipingSize { get; set; }
        public DbSet<T_Product> T_Product { get; set; }
        public DbSet<T_qts_All_SAP_Motors> T_qts_All_SAP_Motors { get; set; }
        public DbSet<T_Quote_Details> T_Quote_Details { get; set; }
        public DbSet<T_Quote_Parts> T_Quote_Parts { get; set; }
        public DbSet<T_Quote_Sections> T_Quote_Sections { get; set; }
        public DbSet<T_Quote_Sections_old> T_Quote_Sections_old { get; set; }
        public DbSet<T_Quote_Sub> T_Quote_Sub { get; set; }
        public DbSet<T_Quotes> T_Quotes { get; set; }
        public DbSet<T_Quotes_old> T_Quotes_old { get; set; }
        public DbSet<T_ResInfo> T_ResInfo { get; set; }
        public DbSet<T_Roles> T_Roles { get; set; }
        public DbSet<T_SalesGroup> T_SalesGroup { get; set; }
        public DbSet<T_SalesOffice> T_SalesOffice { get; set; }
        public DbSet<T_ShippableAssembly> T_ShippableAssembly { get; set; }
        public DbSet<T_status> T_status { get; set; }
        public DbSet<T_UserRoles> T_UserRoles { get; set; }
        public DbSet<T_Users> T_Users { get; set; }
        public DbSet<T_Contact_Information> T_Contact_Information { get; set; }
        public DbSet<T_Custom_Customers> T_Custom_Customers { get; set; }
        public DbSet<T_Flangetype> T_Flangetype { get; set; }
        public DbSet<T_LABOR_DATA_Tmp> T_LABOR_DATA_Tmp { get; set; }
        public DbSet<T_Labor_Tmp> T_Labor_Tmp { get; set; }
        public DbSet<T_MaterialCostFactors> T_MaterialCostFactors { get; set; }
        public DbSet<T_Piping_PaintDetail> T_Piping_PaintDetail { get; set; }
        public DbSet<T_PipingLabor_Data_Tmp> T_PipingLabor_Data_Tmp { get; set; }
        public DbSet<T_PipingType> T_PipingType { get; set; }
        public DbSet<T_qts_tblPUAdescr> T_qts_tblPUAdescr { get; set; }
        public DbSet<T_Quote_Parts_Tmp> T_Quote_Parts_Tmp { get; set; }
        public DbSet<T_Quote_Sections_Tmp> T_Quote_Sections_Tmp { get; set; }
        public DbSet<T_Quote_Sub_Tmp> T_Quote_Sub_Tmp { get; set; }
        public DbSet<T_sap_customer> T_sap_customer { get; set; }
        public DbSet<T_SAPCustomersImport_Temp> T_SAPCustomersImport_Temp { get; set; }
        public DbSet<T_sapmats> T_sapmats { get; set; }
    }
}