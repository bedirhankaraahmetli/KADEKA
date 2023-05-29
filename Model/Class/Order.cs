using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model.Class
{
    internal class Order : OrderAC<Product>
    {
        public Order()
        {
            id++;
        }
        public static int id { get; set; } = 0;
        public int totalPrice { get; set; }
        public string orderNote { get; set; } = "";
        public DateTime orderDate { get; set; } = DateTime.Now;
        public List<Product> productList { get; set; } = new List<Product>();
    }
}
