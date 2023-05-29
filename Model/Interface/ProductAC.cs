using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Model
{
    abstract class ProductAC
    {
        int ID;
        string Name;
        float Price;
        string MainType;
        string SubType;

        public ProductAC(int id, string name, float price, string mainType, string subType)
        {
            ID = id;
            Name = name;
            Price = price;
            MainType = mainType;
            SubType = subType;
        }

        public int getID() { return ID; }
        public string getName() { return Name; }
        public float getPrice() { return Price; }
        public string getMainType() { return MainType; }
        public string getSubType() { return SubType; }
        public void setID(int id) { ID = id; }
        public void setName(string name) { Name = name; }
        public void setPrice(float price) { Price = price; }
        public void setMainType(string mainType) { MainType = mainType; }
        public void setSubType(string subType) { SubType = subType; }

    }
}