using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTemplate.Models
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
