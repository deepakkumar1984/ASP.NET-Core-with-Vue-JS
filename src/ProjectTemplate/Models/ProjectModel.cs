using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_SPA_with_Vue_Js2.Models
{
    public class ProjectModel
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Owner { get; set; }
    }
}
