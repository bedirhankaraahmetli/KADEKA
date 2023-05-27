using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model.Class
{
    internal class Waiter : EmployeeInterface
    {
        public Waiter(string name, string lastName, string password)
        {
            Id++;
            Name = name;
            LastName = lastName;
            Username = (name + lastName).ToLower();
            Password = password;
        }
        public static int Id { get; set; } = 1200;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime shiftStartTime { get; set; }

        void shiftStart()
        {
            shiftStartTime = DateTime.Now;
        }
    }
}
