//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HouseHotelv2.Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property
    {
        public Property()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public string PropertyID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Unit_description { get; set; }
        public string Number_of_Bedrooms { get; set; }
        public string Price_mid_season { get; set; }
        public string Availability { get; set; }
    
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
