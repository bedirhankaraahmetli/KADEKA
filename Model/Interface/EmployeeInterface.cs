using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model
{
    internal interface EmployeeInterface
    {
        static int id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
    }
}
