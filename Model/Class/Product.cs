using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model.Class
{
    internal class Product : ProductAC
    {
        public Product(int id, string name, float price, string mainType, string subType) : base(id, name, price, mainType, subType) { }

    }
}