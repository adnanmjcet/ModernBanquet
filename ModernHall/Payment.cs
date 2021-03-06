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
    
    public partial class Payment
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> PackageTypeId { get; set; }
        public Nullable<long> Amount { get; set; }
        public Nullable<long> TotalAmount { get; set; }
        public Nullable<long> Balance { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> PaymentTypeId { get; set; }
    
        public virtual Package Package { get; set; }
        public virtual PaymentTypetbl PaymentTypetbl { get; set; }
        public virtual User User { get; set; }
    }
}
