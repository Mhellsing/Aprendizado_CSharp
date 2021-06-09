using System;
using System.Globalization;
using System.Collections.Generic;
using ExFixacaoHeranca_Polimorfismo.Entities;

namespace ExFixacaoHeranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listOfProduct = new List<Product>();
            
            Console.Write("Enter the number of products: ");
            var numberOfProduct = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfProduct; i++)
            {
                Console.WriteLine($"\nProduct #{i} data");
                Console.Write("Common, imported or used (C/I/U)? ");
                var commonImportedOrUsed = Console.ReadLine().ToUpper();

                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Price: $");
                var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (commonImportedOrUsed == "I")
                {
                    Console.Write("Custom Fee: $");
                    var customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfProduct.Add(new ImportedProduct(name, price, customFee));
                }
                else if (commonImportedOrUsed == "U")
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    var manufactureDate = DateTime.Parse(Console.ReadLine());
                    listOfProduct.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                    listOfProduct.Add(new Product(name, price));

            }
            Console.WriteLine("\nPrice Tags");
            foreach (Product product in listOfProduct)
            {
                Console.WriteLine(product.PriceTag());//me esqueci de chamar a função pricetag() para retornar a string dos preços.
            }
        }
    }
}
