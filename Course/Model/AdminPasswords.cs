//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Course.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdminPasswords
    {
        public int PasswordId { get; set; }
        public string Password { get; set; }
    
        public virtual AdminNames AdminNames { get; set; }
    }
}
