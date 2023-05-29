using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model.Class
{
    internal class Waiter : EmployeeAC
    {
        public Waiter(int ıd, string name, string lastName, string password) : base(ıd, name, lastName,  password)
        {
        }

        public DateTime shiftStartTime { get; set; }

        void shiftStart()
        {
            shiftStartTime = DateTime.Now;
        }
    }
}
