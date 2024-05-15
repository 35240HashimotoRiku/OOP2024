using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 0, 10, 1, 5, };

            double num = numbers.Where(n => n > 5).Average();
            Console.WriteLine(num);

        }
    }
}
