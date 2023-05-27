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
            Id++;
            Name = name;
            LastName = lastName;
            UserName = (name + lastName).ToLower();
            Password = password;
        }
        public int Id { get; set; } = 1100;
        public string Name { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
