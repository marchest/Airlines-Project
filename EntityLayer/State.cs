//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class State
    {
        public State()
        {
            this.Airports = new HashSet<Airport>();
            this.Contact_Details = new HashSet<Contact_Details>();
        }
    
        public int StateID { get; set; }
        public string StateName { get; set; }
        public int Country { get; set; }
    
        public virtual ICollection<Airport> Airports { get; set; }
        public virtual ICollection<Contact_Details> Contact_Details { get; set; }
        public virtual Country Country1 { get; set; }
    }
}
