using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b =>b.Price == max);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var query = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Select(g => new { PublishedYear = g.Key, Count = g.Count() })
                .OrderBy(g => g.PublishedYear);

            foreach(var item in query) {
                Console.WriteLine("{0}年 {1}冊",item.PublishedYear,item.Count);
            }
        }

        private static void Exercise1_4() {
            var query = Library.Books
                .Join(Library.Categories,  //結合する２番目のシーケンス
                        book => book.CategoryId,//対象シーケンスの結合キー
                        Category => Category.Id,//２番目のシーケンスの結合キー
                        (book, Category) => new {
                            book.Title,
                            book.PublishedYear,
                            book.Price,
                            CategoryName = Category.Name,
                        }).OrderByDescending(x => x.PublishedYear)
                    .ThenByDescending(x => x.Price);

            foreach (var item in query)
                Console.WriteLine("{0}年 {1}円 {2}({3})",
                             item.PublishedYear,
                             item.Price,
                             item.Title,
                             item.CategoryName
                    );
        }

        private static void Exercise1_5() {
        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
