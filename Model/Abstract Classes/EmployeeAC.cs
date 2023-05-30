using Kadeka.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Kadeka.Model
{
    public abstract class EmployeeAC
    {
        int Id;
        string Name;
        string LastName;
        string Username;
        string Password;
        DateTime shiftStartTime { get; set; }

        public EmployeeAC(int ıd, string name, string lastName, string password)
        {
            Id = ıd;
            Name = name;
            LastName = lastName;
            Username = (name + lastName).ToLower();
            Password = password;
        }

        public void shiftStart()
        {
            this.shiftStartTime = DateTime.Now;
        }

        public int getId() { return Id; }
        public void setId(int id) { this.Id = id; }
        public String getName() { return Name; }
        public String getLastName() { return LastName; }
        public String getUsername() { return Username; }
        public string getPassword() { return Password; }
        public DateTime getShiftStartTime() { return shiftStartTime; }

    }
}
