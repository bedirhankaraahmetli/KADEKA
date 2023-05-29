using Kadeka.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Controller
{
    internal class MenuIteractions
    {
        public static List<Product> loadProducts(String txtPath)
        {
            FileStream file = new FileStream(txtPath, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            String str = reader.ReadLine();
            List<Product> products = new List<Product>();
            while (str != null)
            {
                String[] info = str.Split(",");
                String name = info[0];
                float price = float.Parse(info[1]);
                String mainType = info[2];
                String subType = info[3];
                Product product = new Product(name, price, mainType, subType);
                str = reader.ReadLine();

            }
            reader.Close();
            file.Close();
            return products;
        }
    }
}
