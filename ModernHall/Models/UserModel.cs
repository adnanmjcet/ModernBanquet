using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModernHall.Models
{
    public class UserModel
    {
        public string Password { get; set; }

        public string Name { get; set; }
        public string EmailID { get; set; }
        public string Mobile { get; set; }
    }
}