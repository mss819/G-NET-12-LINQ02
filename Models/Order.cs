using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_LINQ02.Models
{
    internal class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public override string ToString() => $"{OrderID}: {OrderDate:d} for {Total:C2}";
    }
}
