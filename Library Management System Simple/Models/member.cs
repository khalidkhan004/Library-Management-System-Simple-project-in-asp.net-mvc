//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Management_System_Simple.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class member
    {
        public int id { get; set; }

        [DisplayName("Member Name")]
        public string name { get; set; }

        [DisplayName("Address")]
        public string address { get; set; }
        public Nullable<int> phone { get; set; }
    }
}
