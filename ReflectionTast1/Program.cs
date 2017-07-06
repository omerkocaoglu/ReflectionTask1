using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTast1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<MethodInfo> ahmetinMetotlari = new List<MethodInfo>();
            List<MethodInfo> omerinMetotlari = new List<MethodInfo>();
            Type productType = typeof(Product);
            MethodInfo[] productAllMethods = productType.GetMethods();
            MethodInfo[] developerAttributeMethods = productAllMethods.Where(x => x.GetCustomAttributes(typeof(DeveloperAttribute), true).Length > 0)
                .ToArray();
            foreach (var item in developerAttributeMethods)
            {
                if (((DeveloperAttribute)item.GetCustomAttribute(typeof(DeveloperAttribute))).Name.Contains('A'))
                {
                    ahmetinMetotlari.Add(item);
                }
                else if (((DeveloperAttribute)item.GetCustomAttribute(typeof(DeveloperAttribute))).Name.Contains('Ö'))
                {
                    omerinMetotlari.Add(item);
                }
            }
            while (true)
            {
                Console.WriteLine("Ahmet ve Ömerin oluşturduğu metotlara ulaşmak için seçim yapınız...");
                Console.WriteLine("Ahmet için (A) / Ömer için (Ö)");
                string selection = Console.ReadLine().ToUpper();
                if (selection == "A")
                {
                    count = 0;
                    
                    Console.WriteLine("Ahmet'in oluşturduğu metotların sayısı: " + ahmetinMetotlari.Count);
                    Console.WriteLine("-------------------");
                    foreach (var item in ahmetinMetotlari)
                    {
                        count++;
                        Console.Write("{0}.Metot: ", count);
                        item.Invoke(new Product(), null);
                    }
                }
                else if (selection == "Ö")
                {
                    count = 0;
                    Console.WriteLine("Ömer'in oluşturduğu metotların sayısı: " + omerinMetotlari.Count);
                    Console.WriteLine("-------------------");
                    foreach (var item in omerinMetotlari)
                    {
                        count++;
                        Console.Write("{0}.Metot: ", count);
                        item.Invoke(new Product(), null);
                    }
                }
            }
        }
    }
}
