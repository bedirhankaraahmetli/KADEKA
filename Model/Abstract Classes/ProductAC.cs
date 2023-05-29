using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model
{
    abstract class ProductAC
    {
        private static int id { get; set; }
        private string name { get; set; }
        private float price { get; set; }
        private string mainType { get; set; }
        private string subType { get; set; }
    }
}
