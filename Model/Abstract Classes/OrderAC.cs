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
        string OrderNote;
        DateTime OrderDate;
        List<T> ProductList;

        public OrderAC(int ID, float totalPrice, string orderNote)
        {
            this.ID = ID;
            TotalPrice = totalPrice;
            OrderNote = orderNote;
            OrderDate = DateTime.Now;
            ProductList = new List<T> { };
        }

        public int getID() { return ID; }
        public float getTotalPrice() { return TotalPrice; }
        public string getOrderNote() { return OrderNote; }
        public DateTime getOrderDate() { return OrderDate; }
        public List<T> getProductList() { return ProductList; }

        public void setID(int ID) { this.ID = ID; }
        public void setTotalPrice(float totalPrice) { TotalPrice = totalPrice; }
        public void setOrderNote(String note) { OrderNote = note; }

    }
}