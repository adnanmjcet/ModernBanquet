using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModernHall.Models
{
    public class PackageModel
    {
        public int Id { get; set; }
        public string PackageName { get; set; }
        public List<PackageModel> PackageList { get; set; }

    }
}