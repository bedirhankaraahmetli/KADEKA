using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model.Class
{
    internal class Table : TableInterface
    {
        public Table() 
        {
            id++;
            state = State.available;
            order = new Order();
        }
        public static int id { get; set; }
        public State state { get; set; }
        public Order order { get; set; }

    }
}
