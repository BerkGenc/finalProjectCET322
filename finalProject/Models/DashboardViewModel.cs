using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class DashboardViewModel
    {
        public int device_count { get; set; }
        public int normal_count { get; set; }
        public int maintenance_count { get; set; }
        public int unavailable_count { get; set; }
    }
}
