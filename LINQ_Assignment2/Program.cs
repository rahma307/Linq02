using LINQ_Assignment2.Models;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Numerics;
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

        }
    }
}
