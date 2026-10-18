using LINQ.DataSources;
using LINQ.Models;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;

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
            #region question6

            //            6.Create a new anonymous type with three properties:
            //● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0,
            //otherwise "Out of Stock"
            //● Print the result.

            //var resualt6= Source.ProductList.Select(p => new {name=p.ProductName,price=p.UnitPrice, StockStatus =p.UnitsInStock>0?"Available":"Out of Stock"});
            // foreach (var item in resualt6)
            //     Console.WriteLine(item);
            #endregion

            #region question7
            //            7.Print each product's name along with its position (1-based)
            //in the list. Expected format: 1.Chai, 2.Chang, etc.

            //var resualt7 = Source.ProductList.Select(((p, i) => $"{i + 1} {p.ProductName}"));
            //foreach (var item in resualt7)
            //    Console.WriteLine(item);
            #endregion

            #region question8
            //            8.Sort ProductList by Category ascending, then within each
            //category, sort by UnitPrice descending.
            //var resault8= Source.ProductList.OrderBy(p=>p.Category).ThenByDescending(p => p.UnitPrice);
            //            foreach (var item in resault8)
            //                Console.WriteLine(item);

            #endregion
            #region question9

//            9.Get all products from the "Beverages" category, sorted by
//UnitsInStock descending. Print name and stock.

            //var resualt9=Source.ProductList.Where(p=>p.Category== "Beverages")
            //                               .OrderByDescending(p=>p.UnitsInStock)
            //                               .Select(p => new {p.ProductName, p.UnitsInStock });

            //foreach (var item in resualt9)
            //    Console.WriteLine(item);
            #endregion







        }
    }
}
