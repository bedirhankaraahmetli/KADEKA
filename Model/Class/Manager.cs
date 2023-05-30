using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model.Class
{
    internal class Manager : EmployeeAC
    {
        public Manager(int ıd, string name, string lastName, string password) : base(ıd, name, lastName, password)
        {
        }

        public override DateTime getShiftStartTime()
        {
            throw new NotImplementedException();
        }
    }
}
