using Kadeka.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model
{
    internal interface TableInterface
    {
        static int id { get; set; }
        State state { get; set; }
        Order order { get; set; }
    }

    enum State
    {
        available,
        occupied,
        reserved
    }
}
