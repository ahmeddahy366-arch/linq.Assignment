using LINQ.DataSources;
using LINQ.Models;
using System.Drawing;

namespace linq.Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //            1.Get all products from the "Seafood" category.Print each
            //product's name and price.

            //var rasualt = Source.ProductList.Where(p => p.Category == "Seafood")
            //                               .Select(p => new { p.ProductName, p.UnitPrice });
            //foreach(var item in rasualt)
            //    Console.WriteLine(item);

            #endregion
            #region question2
            //            2.Get a list of only the product names from ProductList.Print
            //each name.

            //var rasualt2 = Source.ProductList.Select(p => p.ProductName);
            //foreach(var item in rasualt2)
            //    Console.WriteLine(item);
            #endregion
            #region question3
            //            3.Sort all products by UnitPrice(ascending). Print each
            //product's name and price.
            //var resualt3 = Source.ProductList.OrderBy(p => p.UnitPrice)
            //                                .Select(p => new{ p.ProductName, p.UnitPrice });
            //            foreach(var item in resualt3)
            //                Console.WriteLine(item);


            #endregion

            #region question4
            //4.Get all products where UnitPrice is between 10 and 30

            //var resualt4=Source.ProductList.Where(p=>p.UnitPrice>10 && p.UnitPrice<30);
            //foreach(var item in resualt4)
            //    Console.WriteLine(item);
            #endregion
            #region question5
            //            5.Get all products that are in stock(UnitsInStock > 0) and
            //belong to the "Condiments" category.


            //var resualt5 = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments")
            //                              .Select(p => p);
            //foreach(var item in resualt5)
            //    Console.WriteLine(item);
            #endregion







        }
    }
}
