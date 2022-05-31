using System;
using System.Collections.Generic;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public interface IDrink
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Invoice { get; set; }
            public decimal GetPrice();
            
        }
        public class Water : IDrink
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Invoice { get; set; }
            public decimal GetPrice()
            {
                return Price * Invoice;
            }
        }

        public class Alcohol : IDrink
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Invoice { get; set; }

            public decimal Promo { get; set; }
            public decimal GetPrice()
            {
                return (Price * Invoice) - Promo;
            }
        }
        public class Invoice
        {
            public decimal GetTotal(IEnumerable<IDrink> lstDrink)
            {
                decimal total = 0;
                foreach (var drink in lstDrink)
                {
                    total += drink.GetPrice();
                }
                return total; 
            }
        }
    }
}
