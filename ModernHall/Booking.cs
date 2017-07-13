//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModernHall
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int Id { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Title { get; set; }
        public string FullName { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public string Location { get; set; }
        public string EventDescription { get; set; }
        public string Mobile { get; set; }
        public Nullable<System.DateTime> Createdon { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public int PackageTypeId { get; set; }
        public Nullable<int> PackageType { get; set; }

        public virtual Package Package { get; set; }
        public virtual User User { get; set; }
    }
}
