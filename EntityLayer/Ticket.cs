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
    
    public partial class Ticket
    {
        public Ticket()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int TicketNo { get; set; }
        public string TypeOfTicket { get; set; }
        public int Passenger { get; set; }
        public string Status { get; set; }
    
        public virtual Discount Discount { get; set; }
        public virtual Passenger Passenger1 { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
