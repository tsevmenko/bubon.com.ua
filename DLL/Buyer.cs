//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buyer
    {
        public Buyer()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public bool RSS { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
