using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product4> pros = Product4.GetSampleProduct();
            for (int i = 0; i < pros.Count; i++)
            {
                Console.WriteLine(pros[i].ToString());
            }
            Console.ReadKey();
        }
    }

    #region c#4 命名实参初始化
    public class Product4
    {
        readonly string name;
        public string Name { get { return name; } }
        decimal price;
        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public Product4(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product4> GetSampleProduct()
        {
            return new List<Product4>()
            {
                new Product4(name:"West side  story",price: 19.99m),
                new Product4(name:"Assianss",price:14.99m),
                new Product4(name:"Forgs",price:13.99m),
                new Product4(name:"Swinne",price:10.99m)
            };
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", name, price);
        }
    }
    #endregion
}
