using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace M10_Collections
{
    public class DictionaryLab
    {

        public static void Main (string[] args)
        {
            Dictionary<int, string> products = BuildProductDictionary();
            DisplayProductDictionary(products);
        }

        private static void DisplayProductDictionary(Dictionary<int, string> products)
        {
            foreach (KeyValuePair<int, string> product in products)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Product id={product.Key} and name={product.Value}");
            }
            Console.WriteLine();
        }

        private static Dictionary<int, string> BuildProductDictionary()
        {
            string answer = "";

            var productDic = new Dictionary<int, string>();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter product id and name: ");
                answer = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(answer))
                    return productDic;

                answer = answer.Trim();

                if (!ValidInput(answer))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input");
                    continue;
                }

                int productId = int.Parse(answer.Split(',')[0]);
                string productName = answer.Split(',')[1];

                if (productDic.ContainsKey(productId))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The product list already contains the id {productId}");
                }
                else
                    productDic.Add(productId, productName);
            }
        }

        private static bool ValidInput(string answer)
        {
            return Regex.IsMatch(answer, @"^\d+,[a-z ]+$", RegexOptions.IgnoreCase);
        }
    }
}