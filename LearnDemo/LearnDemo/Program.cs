using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace LearnDemo
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    List<Product3> arry = Product3.GetSampleProduct();
        //    //arry.Sort(new ProductNameCompare());
        //    //foreach (Product3 arr in arry)
        //    //{
        //    //    Console.WriteLine(arr.Name);
        //    //}
        //    //arry.Sort((x,y)=>x.Name.CompareTo(y.Name));
        //    //foreach (Product3 pro in arry)
        //    //{
        //    //    Console.WriteLine(pro.Name);
        //    //}
        //    //foreach (Product3 pro in arry.OrderBy(a=>a.Name).ToList())
        //    //{
        //    //    Console.WriteLine(pro.Name);
        //    //}
        //    //c#1
        //    //List<Product3> pros = Product3.GetSampleProduct();
        //    //foreach (Product3 pro in pros)
        //    //{
        //    //    if (pro.Price>10m)
        //    //    {
        //    //        Console.WriteLine(pro.Name+": "+pro.Price);
        //    //    }
        //    //}

        //    //C#2 可以非常轻松地更改测试条件
        //    //List<Product3> products = Product3.GetSampleProduct();
        //    //Predicate<Product3> test = delegate (Product3 p) { return p.Price > 10m; };
        //    //List<Product3> matchs = products.FindAll(test);
        //    //Action<Product3> print = Console.WriteLine;
        //    //matchs.ForEach(print);
        //    //products.FindAll(delegate(Product3 p) { return p.Price > 10m; })
        //    //    .ForEach(Console.WriteLine);

        //    //c#3
        //    //List<Product3> products = Product3.GetSampleProduct();
        //    //foreach (Product3 pro in products.Where(p=>p.Price>10m))
        //    //{
        //    //    Console.WriteLine(pro.Name);
        //    //}
        //List<Product4> products = Product4.GetSampleProduct();
        ////价格未知的产品
        //foreach (Product4 pro in products.Where(p => p.Price == null))
        //{
        //    Console.WriteLine(pro.Name);
        //}

        //    //Product4 pro4 = new Product4("十万个为什么");

        //    //linq
        //    //List<Product3> pros = Product3.GetSampleProduct();
        //    //var query = from Product3 p in pros
        //    //            where p.Price > 10m
        //    //            select p;
        //    //foreach (Product3 p in query)
        //    //{
        //    //    Console.WriteLine(p.Name);
        //    //}
        //    //List<Product3> product = Product3.GetSampleProduct();
        //    //List<Supplier> supp = Supplier.GetSampleProduct();
        //    //var query = from p in product
        //    //            join s in supp
        //    //            on p.ProductId equals s.SupplierID
        //    //            where p.Price > 13
        //    //            orderby s.Name, p.Name
        //    //            select new { supplierName = s.Name, productName = p.Name };
        //    //foreach (var v in query)
        //    //{
        //    //    Console.WriteLine(v.supplierName + " "+ v.productName);
        //    //}
        //    //XDocument doc = XDocument.Load("c://XMLFile1.xml");
        //    //var query = from p in doc.Descendants("product")
        //    //            join s in doc.Descendants("supplier")
        //    //            on (int)p.Attribute("SupplierID")
        //    //            equals (int)s.Attribute("SupplierID")
        //    //            where (decimal)p.Attribute("Price") > 10
        //    //            orderby (string)p.Attribute("Name"),
        //    //            (string)s.Attribute("Name")
        //    //            select new
        //    //            {
        //    //                ProductName = (string)p.Attribute("Name"),
        //    //                SupplierName = (string)s.Attribute("Name")
        //    //            };
        //    //foreach (var p in query)
        //    //{
        //    //    Console.WriteLine(p.ProductName+" "+p.SupplierName);
        //    //}

        //    //保存到Excel中

        //    //var app = new Application { Visible = false };
        //    //Workbook work = app.Workbooks.Add();
        //    //Worksheet sheet = app.ActiveSheet;
        //    //int row = 1;
        //    //foreach (Product3 p in Product3.GetSampleProduct())
        //    //{
        //    //    sheet.Cells[row, 1].Value = p.Name;
        //    //    sheet.Cells[row, 2].Value = p.Price;
        //    //    row++;
        //    //}
        //    //work.SaveAs(Filename:"product.xls",
        //    //          FileFormat: XlFileFormat.xlWorkbookNormal);
        //    //app.Application.Quit();

        //    Console.WriteLine(Reverse("dlrow olleh"));
        //    Console.ReadKey();
        //}

        //字符反转
        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        //[STAThread]
        static void main()
        {
            //Console.WriteLine(Reverse("dlrow olleh"));
            List<Product4> pros = Product4.GetSampleProduct();
            for (int i=0;i<pros.Count;i++)
            {
                Console.WriteLine(pros.ToString());
            }
            Console.ReadKey();
        }
    }

    public class Snippet
    {
        static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        [STAThread]
        static void Main()
        {
            Console.WriteLine(Reverse("dlrow olleh"));
            Console.ReadKey();
        }

    }

    //c#2
    public class Product
    {
        string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        decimal price;
        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }
        public Product(string name,decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product> GetSampleProduct()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("West side  story",9.9m));
            list.Add(new Product("Assianss",14.99m));
            list.Add(new Product("Forgs",13.99m));
            list.Add(new Product("Swinne",10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}",name,price);
        }
    }

    //c#3
    public class Product3
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int ProductId { get; private set; }
        public Product3(string name,decimal price, int id)
        {
            Name = name;
            Price = price;
            ProductId = id;
        }
        public Product3()
        {

        }

        public static List<Product3> GetSampleProduct()
        {
            return new List<Product3>(){
                new Product3() { Name= "West side  story",Price=19.9m,ProductId=1 },
                new Product3() { Name="Assianss",Price=14.99m,ProductId=2},
                new Product3() { Name="Forgs", Price=13.99m , ProductId=3},
                new Product3() { Name="Swinne",Price=10.99m , ProductId=4}
            };
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", Name, Price);
        }
    }

    public class Supplier
    {
        public string Name { get; private set; }
        public int SupplierID { get; private set; }
        public Supplier(string name, int id)
        {
            Name = name;
            SupplierID = id;
        }
        public Supplier()
        {

        }

        public static List<Supplier> GetSampleProduct()
        {
            return new List<Supplier>(){
                new Supplier() { Name= "West side  story",SupplierID=1 },
                new Supplier() { Name="Assianss",SupplierID=2},
                new Supplier() { Name="Forgs", SupplierID=3 },
                new Supplier() { Name="Swinne",SupplierID=4 }
            };
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", Name, SupplierID);
        }
    }

    #region c#4 命名实参初始化
    public class Product4
    {
        readonly string name;
        public string Name { get { return name; } }
        decimal? price;
        public decimal? Price
        {
            get { return price; }
            private set { price = value; }
        }

        public Product4(string name,decimal? price = null)
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
