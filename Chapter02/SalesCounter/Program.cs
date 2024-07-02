using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    public class Test {
        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public Test(string filePass) {
            _sales = ReadSales(filePass);
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    Name = items[0],
                    subject = items[1],
                    Score = int.Parse(items[2]),
                };
                sales.Add(sale);
            }
            return sales;
        }

        //店舗別の売り上げを求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.Name)) {
                    dict[sale.Name] += sale.Score;
                } else {
                    dict[sale.Name] = sale.Score;
                }
            }
            return dict;
        }
    }
}
