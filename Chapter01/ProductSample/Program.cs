using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product karinto = new Product(123,"かりんとう",180);
            Product daihuku = new Product(100,"大福",150);

            int price = karinto.Price;//税抜きの金額
            int taxIncluded = karinto.GetPriceInvludingTax();//税込みの金額
            Console.WriteLine(karinto.Name + "の税込み金額" + taxIncluded+"【税抜き" + price + "円】"); 
        }
    }
}
