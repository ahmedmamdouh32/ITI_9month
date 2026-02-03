

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks.Sources;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day2
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            //-------------------------------------Restriction Operators-------------------------------------
            //1. Find all products that are out of stock.
            var q1 = ListGenerators.ProductList.Where(n => n.UnitsInStock == 0);

            //2. Find all products that are in stock and cost more than 3.00 per unit.
            var q2 = ListGenerators.ProductList.Where(n => n.UnitsInStock > 0 && n.UnitPrice > 3);

            //3. Returns digits whose name is shorter than their value.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            var q3 = Arr.Select((n,index) => new { n , index}).Where(d => d.n.Length < d.index).Select(d => d.index);


            //---------------------------------------Element Operators---------------------------------------
            //1. Get first Product out of Stock
            var q4 = ListGenerators.ProductList.Where(product => product.UnitsInStock == 0).FirstOrDefault();

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            var q5 = ListGenerators.ProductList.Where(product => product.UnitPrice > 1000).FirstOrDefault();

            //3.Retrieve the second number greater than 5
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var q6 = Arr2.Where(number => number > 5).ElementAt(1);


            //---------------------------------------Set Operators---------------------------------------
            //1.Find the unique Category names from Product List
            var q7 = ListGenerators.ProductList.Select(product => product.Category).Distinct();

            //2.Produce a Sequence containing the unique first letter from both product and customer names.
            var q8 = ListGenerators.ProductList.Select(product => product.ProductName[0])
                .Union(ListGenerators.CustomerList.Select(customer => customer.CompanyName[0]));

            //3.Create one sequence that contains the common first letter from both product and customer names.
            var q9 = ListGenerators.ProductList.Select(product => product.ProductName[0])
               .Intersect(ListGenerators.CustomerList.Select(customer => customer.CompanyName[0]));

            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            var q10 = ListGenerators.ProductList.Select(product => product.ProductName[0])
               .Except(ListGenerators.CustomerList.Select(customer => customer.CompanyName[0]));

            //5.Create one sequence that contains the last Three Characters in each names of all customers and products,
            //including any duplicates
            var q11 = ListGenerators.ProductList.Select(product => product.ProductName.Substring(product.ProductName.Length - 3)).
                Concat(ListGenerators.CustomerList.Select(customer => customer.CompanyName.Substring(customer.CompanyName.Length - 3)));


            //---------------------------------------Aggregate Operators---------------------------------------
            //1. Uses Count to get the number of odd numbers in the array
            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var q12 = Arr3.Where(number => number % 2 == 0).Count();

            //2. Return a list of customers and how many orders each has.
            var q13 = ListGenerators.CustomerList.Select(customer => new { customer, NumberOfOrders = customer.Orders.Length });

            //3. Return a list of categories and how many products each has

            var q14 = ListGenerators.ProductList.GroupBy(product => product.Category, (key, products) => new {CategoryName = key, Count = products.Count()});

            //4.Get the total of the numbers in an array.
            int[] Arr4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var q15 = Arr4.Sum();
            Console.WriteLine(q15);


            foreach (var q in q14)
            {
                Console.WriteLine(q);
            }



        }

        static void print(object e)
        {
            Console.WriteLine(e);
        }

        static void print(IEnumerable<int> e)
        {
            foreach (var p in e)
            {
                Console.WriteLine(p);
            }
        }

        static void print(IEnumerable<object> e)
        {
            foreach (var p in e)
            {
                Console.WriteLine(p);
            }
        }
        static void print()
        {
            var q = ListGenerators.ProductList.Select(n=>n);


            foreach (var p in q) {
                Console.WriteLine(p);
            }
        }
    }
}
