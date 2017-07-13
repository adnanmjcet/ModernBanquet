namespace ModernHall.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? PackageTypeId { get; set; }

        public long? Amount { get; set; }

        public long? TotalAmount { get; set; }

        public long? Balance { get; set; }

        public bool? Status { get; set; }

        public int? PaymentTypeId { get; set; }

        public virtual Package Package { get; set; }

        public virtual PaymentTypetbl PaymentTypetbl { get; set; }

        public virtual User User { get; set; }
    }
}
