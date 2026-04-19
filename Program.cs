using G_NET_12_LINQ02.Models;
using static G_NET_12_LINQ02.DataSources.Source;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;
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


        }
    }
}
