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
    
    public partial class AirFare
    {
        public AirFare()
        {
            this.Flight_Schedule = new HashSet<Flight_Schedule>();
        }
    
        public int AfID { get; set; }
        public int Route { get; set; }
        public int Fare { get; set; }
    
        public virtual Route Route1 { get; set; }
        public virtual ICollection<Flight_Schedule> Flight_Schedule { get; set; }
    }
}
