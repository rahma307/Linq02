using LINQ_Assignment2.Models;
using System.Drawing;
using System.Globalization;
using static LINQ_Assignment2.DataSources.Source;
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


            #endregion

        }
    }
}
