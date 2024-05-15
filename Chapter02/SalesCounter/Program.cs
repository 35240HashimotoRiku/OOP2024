﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sales = new SalesCounter(( ("date/sales.csv")));
            var amountPerStore = (SortedDictionary<string, int>)sales.GetPerStoreSales();
            foreach(KeyValuePair<string,int>obj in amountPerStore){
                Console.WriteLine("{0} {1}",obj.Key,obj.Value);
            }
        }

      

    }
}
