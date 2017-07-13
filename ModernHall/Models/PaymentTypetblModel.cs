using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModernHall.Models
{
    public class PaymentTypetblModel
    {
        public int Id { get; set; }
        public string PaymentType { get; set; }
        public List<PaymentTypetblModel> PaymentTypetblList { get; set; }

    }
}