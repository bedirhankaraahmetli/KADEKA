﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model.Class
{
    internal class Order : OrderAC<Product>
    {
        public Order(int ID, int totalPrice, string orderNote) : base(ID, totalPrice, orderNote) { }

    }
}