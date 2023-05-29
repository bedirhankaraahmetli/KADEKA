using Kadeka.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Controller
{
    internal class EmployeeManagment
    {
        public static List<Waiter> retrieveWaiters(String txtPath)
        {
            FileStream file = new FileStream(txtPath, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            String str = reader.ReadLine();
            List<Waiter> waiters = new List<Waiter>();
            int waiterID = 1200;
            while (str != null)
            {
                String[] info = str.Split(",");
                String name = info[0];
                String lastName = info[1];
                String password = info[2];
                Waiter waiter = new Waiter(++waiterID, name, lastName, password);
                waiters.Add(waiter);
                str = reader.ReadLine();

            }
            reader.Close();
            file.Close();
            return waiters;
        }
        public static List<Manager> retrieveManagers(String txtPath)
        {
            FileStream file = new FileStream(txtPath, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            String str = reader.ReadLine();
            List<Manager> managers = new List<Manager>();
            int managerID = 1100;
            while (str != null)
            {
                String[] info = str.Split(",");
                String name = info[0];
                String lastName = info[1];
                String password = info[2];
                Manager manager = new Manager(++managerID, name, lastName, password);
                managers.Add(manager);
                str = reader.ReadLine();

            }
            reader.Close();
            file.Close();
            return managers;
        }
    }
}
