using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model.Class
{
    internal class Manager : EmployeeInterface
    {
        public Manager(string name, string lastName, string password)
        {
            Name = name;
            LastName = lastName;
            Password = password;
        }
        public int id { get; set; } = 0;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
