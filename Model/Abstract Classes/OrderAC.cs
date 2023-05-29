using Kadeka.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model
{
    abstract class OrderAC<T>
    {
        private static int id { get; set; }
        private int totalPrice { get; set; }
        private string orderNote { get; set; }
        private DateTime orderDate { get; set; }
        private List<T> productList { get; set; }
    }
}
