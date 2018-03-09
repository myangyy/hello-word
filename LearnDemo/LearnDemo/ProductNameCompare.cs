 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDemo
{
    public class ProductNameCompare : IComparable<Product3>
    {
        public int CompareTo(Product3 other)
        {
            return other.Name.CompareTo(other.Name);
        }
        public int CompareTo(Product3 x, Product3 y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
