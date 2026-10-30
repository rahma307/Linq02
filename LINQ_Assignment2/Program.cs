using LINQ_Assignment2.Models;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Text.RegularExpressions;
using static LINQ_Assignment2.DataSources.Source;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LINQ_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.

            //var sortingDescByCategoryAndPrice = ProductList.OrderByDescending(p => p.Category)
            //                                     .ThenByDescending(p => p.UnitPrice);

            //foreach (var item in sortingDescByCategoryAndPrice)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region task2
            //Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

            //var beverageProductsSortedByUnitsInStockDesc = ProductList.Where(p => p.Category == "Beverages")
            //                                                         .OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in beverageProductsSortedByUnitsInStockDesc)
            //{
            //    Console.WriteLine($"productName:{item.ProductName} , Stock: {item.UnitsInStock}");  
            //}
            #endregion

            #region task3
            //Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.
            //var result = from c in CustomerList
            //             from order in c.Orders
            //             where order.OrderDate.Year >= 1997
            //             orderby order.OrderDate
            //             select new
            //             {
            //                 CustomerId = c.CustomerID,
            //                 orderDate = order.OrderDate
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region task4

            //Show position number alongside ProductName

            //var result = ProductList.Select((p, i) => new
            //{
            //    PositionNumber = i + 1,
            //    ProductName = p.ProductName
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region task5


            //Sort first by - word length and then by a case -insensitive sort of the words in an array. String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region task6

            // Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "one", "six", "five", "two", "nine", "eight" };

            //var result = Arr.Where(w => w[1] == 'i')
            //                .Reverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region task7
            // Get top 3 most expensive products

            //var top3Expensve = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var item in top3Expensve)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region task8

            //show page 2 of products, with page size = 5
            //var result = ProductList.Skip(1 * 5).Take(5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region task9
            //Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var result = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
            //foreach (var item in result)

            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region task10 
            // Check if ALL products in the"Seafood" category are in stock
            //var result = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //if(result)
            //    Console.WriteLine("all seafod category in stock");
            //else
            //    Console.WriteLine("there is product or some products or all products out of stock");
            #endregion

            #region task11

            // Check if the ID list contains 9 int[] ids = { 3, 9, 13, 18 };
            //int[] ids = { 3, 9, 13, 18 };
            //if(ids.Any(i=>i==9))
            //    Console.WriteLine("id 9 found");
            //else
            //    Console.WriteLine("not found");


            #endregion

            #region task12

            //Group all products by Category and print each group with its product count.

            //var groups = ProductList.GroupBy(p => p.Category);
            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"Group : {group.Key} : count :{group.Count()}");   
            //}
            #endregion

            #region task13
            //Group products by Category and project only product names per group
            //var re = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    group = g.Key,
            //    productName = g.Select(g => g.ProductName)
            //});

            //foreach (var item in re)
            //{
            //    Console.WriteLine("Group"+item.group);
            //    foreach (var item1 in item.productName)
            //    {
            //        Console.WriteLine(item1);
            //    }

            //    Console.WriteLine("==========================");
            //}



            #endregion

            #region task14
            //Find all categories that have MORE THAN 3 products
            //var res = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);
            //foreach (var item in res)
            //{
            //    Console.WriteLine("group: "+item.Key);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);   
            //    }
            //    Console.WriteLine("===========================");
            //}



            #endregion

            #region task15

            //Using QUERY SYNTAX, group customers by Country, and for each group select{ Country, Count, TotalOrderValue}.

            //var res = from c in CustomerList
            //          group c by c.Country
            //         into grouping
            //          select new
            //          {
            //              country = grouping.Key,
            //              count = grouping.Count(),
            //              totalordervalue = grouping.Sum(g=>g.Orders.Sum(o=>o.Total))
            //          };
            //foreach (var item in res)
            //{
            //    Console.WriteLine("group : "+item.country);
            //    Console.WriteLine("count :"+item.count);
            //    Console.WriteLine("total order value : "+item.totalordervalue);
            //}

            #endregion


            #region task16

            // Calculate the total number of units in stock across all products

            //var res = ProductList.Where(p => p.UnitsInStock > 0).Count();
            //Console.WriteLine(res);



            #endregion

            #region task17

            //Find the CHEAPEST and MOST EXPENSIVE product prices
            //var cheapest = ProductList.Min(p => p.UnitPrice);
            //var expe = ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine($"cheapest : {cheapest} , expensive : {expe}");



            #endregion



            #region task18
            //  Get a distinct list of all product categories

            //var r = ProductList.DistinctBy(p => p.Category);
            //foreach (var item in r)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region task19

            // find product IDs that are in setA but NOT in setB int[] setA = { 1, 3, 5, 7, 9, 11, 13 }; int[] setB = { 3, 6, 9, 12, 15, 13 };


            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var res = setA.Except(setB);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region task20
            //Find countries that appear in list1 but NOT in list2(case -insensitive).

            //     string[] list1 = { "Germany", "France", "UK", "Spain" }; 
            //    string[] list2 = { "france", "SPAIN", "Italy" };
            //var res = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region task21
            //Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.

            //var res = ProductList.ToDictionary(p => p.ProductID);
            //Console.WriteLine(res[18]);
            #endregion


            #region task22

            // Get the first product whose price is greater than$50.

            //var res = ProductList.FirstOrDefault(p => p.UnitPrice > 50);
            //Console.WriteLine(res);



            #endregion


            #region task23
            //Try to get the first product with a price >$500.it returns null instead of throwing.

            //var r = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(r);
            #endregion

            #region task24

            //Generate a multiplication table row for 7
            //var result = Enumerable.Range(1, 10)
            //            .Select(n => new
            //            {
            //                Number = n,
            //                Result = n * 7
            //            });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"7 * {item.Number} = {item.Result}");
            //}


            #endregion


            #region task25
            //Generate even numbers between 1 and 30.

            //var res = Enumerable.Range(1, 30)
            //            .Where(n => n % 2 == 0);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
        }
    }
}
