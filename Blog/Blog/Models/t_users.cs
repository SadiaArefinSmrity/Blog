//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_users
    {
        public int userid { get; set; }
        public string user_fname { get; set; }
        public string user_lname { get; set; }
        public string user_username { get; set; }
        public string user_pass { get; set; }
        public string user_contact { get; set; }
        public Nullable<int> is_admin { get; set; }
    }
}
