using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model.Class
{
    internal class Product : ProductAC
    {
        public Product(string name, float price, string mainType, string subType) 
        {
            id++;
            this.name = name;
            this.price = price;
            this.mainType = mainType;
            this.subType = subType;
        }

        public static int id { get; set; } = 0;
        public string name { get; set; }
        public float price { get; set; }
        public string mainType { get; set; }
        public string subType { get; set; }
    }
}
