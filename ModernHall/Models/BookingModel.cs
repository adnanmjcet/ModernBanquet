using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModernHall.Models
{
    public class BookingModel
    {
        public BookingModel()
        {
            BookingList = new List<BookingModel>();
        }
        public long Id { get; set; }
        public Nullable<long> UserID { get; set; }
        [Required]
        public string Title { get; set; }
        public string FullName { get; set; }
        public DateTime BookingDate { get; set; }
        public string Location { get; set; }
        public string EventDescription { get; set; }
        [Required]
        public string Mobile { get; set; }
        public Nullable<System.DateTime> Createdon { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> PackageType { get; set; }
        public string PackageName { get; set; }
        [Required]
        [Compare("Mobile")]
        public string ConfrimMobile { get; set; }

        public List<BookingModel> BookingList { get; set; }
    }
}