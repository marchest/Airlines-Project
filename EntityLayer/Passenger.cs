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
    
    public partial class Passenger
    {
        public int Passenger_ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Contacts { get; set; }
    
        public virtual Contact_Details Contact_Details { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
