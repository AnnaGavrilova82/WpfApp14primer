using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14primer
{
    public enum ProductTypes
    {
        Food,
        Technics
    }
    public class Product
    {
        public string ProductName { get; set; }
        public string Сategory { get; set; }
        public int Price { get; set; }
        public int Priority { get; set; }
        public ProductTypes ProductType { get; set; }

        public override string ToString()
        {
            return Сategory;
        }
    }
    
}
