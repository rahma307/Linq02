using static LINQ_Assignment2.DataSources.Source;
namespace LINQ_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.

            var sortingDescByCategoryAndPrice = ProductList.OrderByDescending(p => p.Category)
                                                 .ThenByDescending(p => p.UnitPrice);

            foreach (var item in sortingDescByCategoryAndPrice)
            {
                Console.WriteLine(item);
            }

            #endregion

        }
    }
}
