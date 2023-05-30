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
        int ID;
        float TotalPrice;
        DateTime OrderDate;
        List<T> ProductList;

        public OrderAC(int ID, float totalPrice)
        {
            this.ID = ID;
            TotalPrice = totalPrice;
            OrderDate = DateTime.Now;
            ProductList = new List<T> { };
        }


        public int getID() { return ID; }
        public float getTotalPrice() { return TotalPrice; }
        public DateTime getOrderDate() { return OrderDate; }
        public List<T> getProductList() { return ProductList; }

        public void setID(int ID) { this.ID = ID; }
        public void setTotalPrice(float totalPrice) { TotalPrice = totalPrice; }
        public void setOrderDate(DateTime orderDate) { OrderDate = orderDate; }
    }
}