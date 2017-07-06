using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTast1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int SupplierId { get; set; }


        [Developer("Ahmet")]
        public void AddProduct()
        {
            Console.WriteLine("Ürün eklendi.");
            Console.WriteLine("\n");
        }


        [Developer("Ahmet")]
        public void DeleteProduct()
        {
            Console.WriteLine("Ürün silindi.");
            Console.WriteLine("\n");
        }

        [Developer("Ahmet")]
        public void UpdateProduct()
        {
            Console.WriteLine("Ürün güncellendi.");
            Console.WriteLine("\n");
        }

        [Developer("Ahmet")]
        public void GetProductById()
        {
            Console.WriteLine("Id bazında ürünler getirildi.");
            Console.WriteLine("\n");
        }

        [Developer("Ömer")]
        public void GetProductByAll()
        {
            Console.WriteLine("Tüm ürünler getirildi.");
            Console.WriteLine("\n");
        }

        [Developer("Ömer")]
        public void GetProductBySupplierId()
        {
            Console.WriteLine("Tedarikçi bazında ürünler getirildi.");
            Console.WriteLine("\n");
        }
    }
}
