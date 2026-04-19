using G_NET_12_LINQ02.Models;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static G_NET_12_LINQ02.DataSources.Source;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace G_NET_12_LINQ02

{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01

            ////1. Get top 3 most expensive products
            //var result1 = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Question02

            ////2. show page 2 of products, with page size = 5
            //var result2 = ProductList.Skip(5).Take(5);
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Question03

            ////3.Take products from the list as long as Their UnitPrice is less than
            ////$25(list is ordered by price).

            //var result = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question04

            //4.Check if ALL products in the "Seafood" category are in stock

            //var result = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result);

            #endregion

            #region Question05

            //5. Check if the ID list contains 9
            //var result = ProductList.Select(p => p.ProductID).Contains(9);
            //Console.WriteLine(result);


            #endregion

            #region Question06

            //6.Group all products by Category and print each group with its
            //product count.

            //var result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, Count = g.Count() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Question07

            //7.Group products by Category and project only product names per
            //group

            //var result = ProductList.GroupBy(p => p.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Key}");
            //    foreach (var product in item)
            //    {
            //        Console.WriteLine($" - {product.ProductName}");
            //    }
            //}


            #endregion

            #region Question08

            //8.Find all categories that have MORE THAN 3 products

            //var result = ProductList.GroupBy(p => p.Category).Where(G => G.Count() > 3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Key} : Count: {item.Count()}");

            //}

            #endregion

            #region Question09

            //9.Using QUERY SYNTAX, group customers by Country, and for each
            //group select { Country, Count, TotalOrderValue }.

            //var result = from c in CustomerList
            //             group c by c.Country 
            //             into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question10

            ////10.Calculate the total number of units in stock across all products
            //var result = ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);

            #endregion

            #region Question11

            ////11.Find the CHEAPEST and MOST EXPENSIVE product prices
            //var minPrice = ProductList.Min(p => p.UnitPrice);
            //var maxPrice = ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine($"Min Price: {minPrice}  ,  Max Price: {maxPrice} ");

            #endregion

            #region Question12

            //12. Get a distinct list of all product categories
            //var result = ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question13

            //13.find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question14

            ////14.Find countries that appear in list1 but NOT in list2
            ////(case -insensitive).
            //    string[] list1 = { "Germany", "France", "UK", "Spain" };
            //    string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question15

            //15.Build a Dictionary<int, Product> keyed by ProductID. Then
            //retrieve and print the product with ID = 18.

            //var productDictionary = ProductList.ToDictionary(p => p.ProductID);
            //var product18 = productDictionary[18];
            //Console.WriteLine(product18);
            #endregion

            #region Question16

            ////16. Get the first product whose price is greater than $50.
            //var firstExpensiveProduct = ProductList.FirstOrDefault(p => p.UnitPrice > 50);
            //Console.WriteLine(firstExpensiveProduct);

            #endregion

            #region Question17

            ////17.Try to get the first product with a price > $500.it returns null
            ////instead of throwing.
            //var firstVeryExpensiveProduct = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(firstVeryExpensiveProduct);

            #endregion

            #region Question18

            ////18. Generate a multiplication table row for 7
            //var multiplicationTableRow = Enumerable.Range(1, 10).Select(i => $"7 x {i} = {7 * i}");
            //foreach (var item in multiplicationTableRow)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
}
