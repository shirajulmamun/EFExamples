using Ecommerce.Models.EntityModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Ecommerce.BLL;

namespace Ecommerce.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var product = new Product()
            {
                Name = "Acer Laptop",
                Code = "ACER001",
                ProductType = "Computer & Computer Equipment",
                SalesPrice = 10000
            };

            ProductManager manager = new ProductManager();
            bool isAdded = manager.Add(product);
            if(isAdded)
            {
                System.Console.WriteLine("Succesfull!");
            }
            else
            {
                System.Console.WriteLine("Failed!");
            }

            


            System.Console.ReadKey();

        }
    }
}
