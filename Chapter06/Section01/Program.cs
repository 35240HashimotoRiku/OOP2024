using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

           var pages = Books.GetBooks().OrderByDescending(x => x.Price).ToList();
            foreach (var books in pages) {
                Console.WriteLine(books.Price);
            }
        }
    }
}
