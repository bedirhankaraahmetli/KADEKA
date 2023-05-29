using Kadeka.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadeka.Controller
{
    internal class MenuInteractions
    {
        public static List<Product> loadProducts(String txtPath)
        {
            FileStream file = new FileStream(txtPath, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            String str = reader.ReadLine();
            List<Product> products = new List<Product>();
            int id = 3000;
            while (str != null)
            {
                String[] info = str.Split(",");
                String name = info[0];
                float price = float.Parse(info[1]);
                String mainType = info[2];
                String subType = info[3];
                Product product = new Product(++id, name, price, mainType, subType);
                products.Add(product);
                str = reader.ReadLine();

            }
            reader.Close();
            file.Close();
            return products;
        }
    }
}
