//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessLogic.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        public int Id { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public System.DateTime Time { get; set; }
        public decimal Altitude { get; set; }
        public decimal Accuracy { get; set; }
        public int CarId { get; set; }
        public decimal Speed { get; set; }    
        public virtual Car Car { get; set; }
    }
}
