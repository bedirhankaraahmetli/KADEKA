using Kadeka.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model
{
    internal interface OrderInterface<T>
    {
        static int id { get; set; }
        int totalPrice { get; set; }
        string orderNote { get; set; }
        DateTime orderDate { get; set; }
        List<T> productList { get; set; }
    }
}
