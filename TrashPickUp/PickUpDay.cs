//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrashPickUp
{
    using System;
    using System.Collections.Generic;
    
    public partial class PickUpDay
    {
        public int ID { get; set; }
        public string Day { get; set; }
        public bool Status { get; set; }
        public int EmployeeID { get; set; }
        public int AddressID { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
