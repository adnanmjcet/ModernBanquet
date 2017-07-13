using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModernHall.Models
{
    public class PaymentModel
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
        public List<PaymentModel> PaymentList { get; set; }

    }
}