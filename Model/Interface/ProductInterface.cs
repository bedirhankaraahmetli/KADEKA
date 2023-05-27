﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model
{
    internal interface ProductInterface
    {
        static int id { get; set; }
        string name { get; set; }
        float price { get; set; }
        string mainType { get; set; }
        string subType { get; set; }
    }
}
