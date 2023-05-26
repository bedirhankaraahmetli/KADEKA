using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model.Class
{
    internal class Waiter : EmployeeInterface
    {
        public Waiter(int id, string name, string lastName, string password)
        {
            id++;
            Name = name;
            LastName = lastName;
            Password = password;
        }
        public static int id { get; set; } = 0;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime shiftStartTime { get; set; }

        void shiftStart()
        {
            shiftStartTime = DateTime.Now;
        }

    }
}
