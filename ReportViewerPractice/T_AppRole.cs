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
    
    public partial class T_AppRole
    {
        public T_AppRole()
        {
            this.T_UserRoles = new HashSet<T_UserRoles>();
        }
    
        public int AppRoleId { get; set; }
        public string AppRoleName { get; set; }
        public string AppRoleDescription { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<T_UserRoles> T_UserRoles { get; set; }
    }
}
