
using Day2.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static Day2.ListGenerators;
using static System.Net.Mime.MediaTypeNames;
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
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var q3 = Arr.Select((n, index) => new { n, index }).Where(d => d.n.Length < d.index).Select(d => d.index);


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

            var q14 = ListGenerators.ProductList.GroupBy(product => product.Category, (key, products) => new { CategoryName = key, Count = products.Count() });

            //4.Get the total of the numbers in an array.
            int[] Arr4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var q15 = Arr4.Sum();
            //Console.WriteLine(q15);


            //5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array
            //of String First).
            using var reader = new StreamReader(@"C:\Users\adminstrator\Documents\ITI_9Months\C#\Entity Framework\Day2\Lab\dictionary_english.txt");
            string[] content = reader.ReadToEnd().Split("\r\n");
           
            var q16 = content.SelectMany(n => n).Count();
            var q16_v2 = content.Select(n => n.Length).Sum();

            //6.Get the total units in stock for each product category.
            var q17 = ProductList.GroupBy(p => p.Category).Select(grp => new { CategoryName = grp.Key, TotalAmountInStock = grp.Sum(p=>p.UnitsInStock)});


            //7.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            var q18 = content.Min(word=>word.Length);

            //8.Get the cheapest price among each category's products
            var q19 = ProductList.GroupBy(p => p.Category).Select(grp => new { CategoryName = grp.Key, CheapestPrice=grp.Min(p => p.UnitPrice)});
            

            //9.Get the products with the cheapest price in each category(Use Let)
            var q20 = from p in ProductList
                      group p by p.Category
                      into PrdGrp
                      let cheapProduct = (from pd in PrdGrp
                                          orderby pd.UnitPrice 
                                          select pd).FirstOrDefault()
                      select cheapProduct;

            //10.Get the length of the longest word in dictionary_english.txt
            var q21 = content.Max(word=>word.Length);

            //11.Get the most expensive price among each category's products.
            var q22 = ProductList.GroupBy(p => p.Category).Select(grp => new { CategoryName = grp.Key, CheapestPrice = grp.Max(p => p.UnitPrice) });

            //12.Get the products with the most expensive price in each category.
            var q23 = from p in ProductList
                      group p by p.Category
                      into PrdGrp
                      let cheapProduct = (from pd in PrdGrp
                                          orderby pd.UnitPrice descending
                                          select pd).FirstOrDefault()
                      select cheapProduct;

            //13.Get the average length of the words in dictionary_english.txt
            var q24 = content.Average(word => word.Length);

            //14.Get the average price of each category's products.
            var q25 = ProductList.GroupBy(p => p.Category).Select(grp => new {CategoryName =grp.Key, AveragePrice=grp.Average(p=>p.UnitPrice)});

            //1.Sort a list of products by name
            var q26 = ProductList.OrderBy(p => p.ProductName);

            //2.Uses a custom comparer to do a case -insensitive sort of the words in an array.
            string[] Arr5 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var q27 = Arr5.Order(new models.ComparerCaseInsensitive());

            //3.Sort a list of products by units in stock from highest to lowest.
            var q28 = ProductList.OrderByDescending(p => p.UnitsInStock);

            //4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr6 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var q29 = Arr6.OrderBy(n => n.Length).ThenBy(number=>number);

            //5.Sort first by word length and then by a case -insensitive sort of the words in an array.
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var q30 = words.OrderBy(word => word.Length).ThenBy(word =>word.ToLower());

            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            var q31 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //7.Sort first by word length and then by a case -insensitive descending sort of the words in an array.
            string[] Arr7 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var q32 = Arr7.OrderBy(word => word.Length).ThenByDescending(word => word.ToLower());

            //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] Arr8 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var q33 = Arr8.Where(digit => digit[1] == 'i').Reverse();

            //1.Get the first 3 orders from customers in Washington
            var q34 = CustomerList.Where(c => c.City== "Washington").Take(3);

            //2.Get all but the first 2 orders from customers in Washington.
            var q35 = CustomerList.Where(c => c.City == "Washington").Skip(2);


            //3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var q36 = numbers.TakeWhile((digit,index) => digit >= index);

            //4.Get the elements of the array starting from the first element divisible by 3.
            var q37 = numbers.SkipWhile(digit => digit % 3 != 0);

            //5.Get the elements of the array starting from the first element less than its position.
            var q38 = numbers.SkipWhile((digit, index) => digit >= index);

            //1.Return a sequence of just the names of a list of products.
            var q39 = ProductList.Select(p => p.ProductName);

            //2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            string[] words2 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var q40 = words2.Select(word => new { UpperCase = word.ToUpper(), LowerCase = word.ToLower() });

            //3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            var q41 = ProductList.Select(p => new {Name = p.ProductName, Price = p.UnitPrice, ID = p.ProductID });

            //4.Determine if the value of ints in an array match their position in the array.
            int[] Arr9 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var q42 = Arr9.Select((number, index) => number == index);

            //5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var q43 = numbersA.Select(A => new { A, Collection = numbersB }).SelectMany(n => n.Collection, (left, right) =>
            new
            {
                A = left.A,
                B = right
            }
            ).Where(pair => pair.A < pair.B).Select(p => $"{p.A} is less than {p.B}");


            //6.Select all orders where the order total is less than 500.00.
            var q44 = CustomerList.SelectMany(customer => customer.Orders.Where(o => o.Total < 500));

            //7.Select all orders where the order was made in 1998 or later.
            var q45 = CustomerList.SelectMany(customer => customer.Orders.Where(o => o.OrderDate.Year >= 1998));


            //1.Determine if any of the words in dictionary_english.txt contain the substring 'ei'.
            var q46 = content.Any(word => word.Contains("ei"));

            //2.Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var q47 = ProductList.GroupBy(p => p.Category).Where(grp => grp.Any(p => p.UnitsInStock == 0));

            //3.Return a grouped a list of products only for categories that have all of their products in stock.
            var q48 = ProductList.GroupBy(p => p.Category).Where(grp => grp.All(p => p.UnitsInStock != 0));

            //1.Use group by to partition a list of numbers by their remainder when divided by 5

            var numbers3 = Enumerable.Range(0,16);
            var q499 = numbers3.GroupBy(number => number%5);

            //2.Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
            var q50 = content.GroupBy(word => word[0]); ;

            //3.Consider this Array, Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            string[] Arr10 = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            var q51 = Arr10.GroupBy(word => word ,new CompareSameCharacters());
            foreach (var group in q51)
            {
                Console.WriteLine("...");
                foreach (var word in group)
                {
                    Console.WriteLine(word.Trim());
                }
            }





























        }
        //class compareit : IComparer<string>
        //{
        //    public int Compare(string? x, string? y)
        //    {
        //        if(x == null)
        //        {
        //            return -1;
        //        }
        //        else if(y == null)
        //        {
        //            return 1;
        //        }

        //        x = x.ToLower();
        //        y = y.ToLower();

        //        for (int i=0;i<Math.Min(x.Length, y.Length); i++)
        //        {
        //            if (x[0] > y[0]) return 1;
        //            else if (x[0] < y[0]) { return -1; }
        //        }
        //        return 0;
        //    }
        //}

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
