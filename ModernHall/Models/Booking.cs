namespace ModernHall.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        public int Id { get; set; }

        public int? UserID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public DateTime? BookingDate { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(550)]
        public string EventDescription { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public DateTime? Createdon { get; set; }

        public long? CreatedBy { get; set; }

        public bool? IsActive { get; set; }

        public int PackageTypeId { get; set; }

        public virtual Package Package { get; set; }

        public virtual User User { get; set; }
    }
}
