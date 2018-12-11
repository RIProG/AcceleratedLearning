using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module11_CustomerList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = CreateListOfCustomers(@"C:\Project\AcceleratedLearning\C#\CsharpExercises\Module11 CustomerList\Module11 CustomerList\PersonShort.txt");
            DisplayCustomerList(list);
        }

        private static void DisplayCustomerList(List<Customer> list)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sorted list by age:");

            foreach (Customer customer in list.OrderBy(x => x.Age))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{customer.FirstName} {customer.Age} {customer.Sex}");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sorted list by first name:");

            foreach (Customer customer in list.OrderBy(x => x.FirstName))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{customer.FirstName} {customer.Age} {customer.Sex}");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Men older than 35:");

            foreach (Customer customer in list.Where(x => x.Age > 35 && x.Sex == "Male"))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{customer.FirstName} {customer.Age} {customer.Sex}");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Manipulated:");

            foreach (Customer customer in list.Where(x => x.Age > 35))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{customer.FirstName.ToUpper()} {customer.Age+1000} {customer.Sex}");
            }
            Console.WriteLine();

        }

        public static List<Customer> CreateListOfCustomers(string customerFile)
        {
            var customerList = new List<Customer>();
            string[] customerArray = File.ReadAllLines(customerFile);
            customerArray = customerArray.Skip(1).ToArray();

            foreach (string line in customerArray)
            {
                    customerList.Add(ParseCustomerFromRow(line));
            }
            
            return customerList;
        }

        public static Customer ParseCustomerFromRow(string row)
        {
            Customer newCustomer = new Customer();
            newCustomer.FirstName = row.Split(',')[1];
            newCustomer.Sex = row.Split(',')[4];
            newCustomer.Age = int.Parse(row.Split(',')[5]);

            return newCustomer;
        }
        
    }
}
