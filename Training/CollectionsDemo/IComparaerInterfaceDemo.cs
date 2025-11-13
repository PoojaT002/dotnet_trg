using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsDemo
{
    public class ProductInfo
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; }
    }
    public class SortByPriceAscending:IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
    public class SortByPriceDscending : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return y.Price.CompareTo(x.Price);
        }
    }
    public class SortByName : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.ProductName.CompareTo(y.ProductName);
        }
    }
    public class SortByRating : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            return x.Rating.CompareTo(y.Rating);
        }
    }

    internal class IComparaerInterfaceDemo
    {
        static void Main(string[] args)
        {
            List<ProductInfo> list = new List<ProductInfo>()
            { new ProductInfo { ProductId = 1, ProductName = "Laptop", Price = 45000, Rating = 4.5 },
                       new ProductInfo { ProductId = 2, ProductName = "Mobile", Price = 80000, Rating = 4.9 },
                       new ProductInfo { ProductId = 3, ProductName = "Monitor", Price = 70000, Rating = 4.7 },
                       new ProductInfo { ProductId = 4, ProductName = "Tablet", Price = 55000, Rating = 4.5 },
                       new ProductInfo { ProductId = 5, ProductName = "Keyboard", Price = 20000, Rating = 4.0 }
             };

            Console.WriteLine("1.Sort by Price");
            list.Sort(new SortByPriceAscending());
            DisplayProducts(list);

            Console.WriteLine("2.Sort by Price descending");
            list.Sort(new SortByPriceDscending());
            DisplayProducts(list);

            Console.WriteLine("3.Sort by Name");
            list.Sort(new SortByName());
            DisplayProducts(list);

            Console.WriteLine("4.Sort by Rating");
            list.Sort(new SortByRating());
            DisplayProducts(list);

        }

        static void DisplayProducts(List<ProductInfo> products)
        {
            foreach(var product in products)
            {
                Console.WriteLine($"ProductId: {product.ProductId}, ProductNAme: {product.ProductName}, Product Price: {product.Price}, ProductRating: {product.Rating}");
            }
        }



        }
    }

