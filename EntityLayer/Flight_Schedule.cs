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
    
    public partial class Flight_Schedule
    {
        public Flight_Schedule()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int Flight_ID { get; set; }
        public System.DateTime FlightDate { get; set; }
        public System.DateTime Departure { get; set; }
        public System.DateTime Arrival { get; set; }
        public int AirCraft { get; set; }
        public int NetFare { get; set; }
    
        public virtual AirCraft AirCraft1 { get; set; }
        public virtual AirFare AirFare { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}