using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markiian
{
    public class EmployeeDTO
    {
        public Guid IdPerosne { get; set; }
        public string Company { get; set; }
        public DateTime BirthDay { get; set; }
        public string Spetialization { get; set; }
        public double AverageSelery { get; set; }

    }
}
