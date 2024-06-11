using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1_2 {
    internal class Program {
        static void Main(string[] args) {

            var kentyou = new Dictionary<string, string>();
            Console.WriteLine("県庁所在地の登録");
            for (int i = 0; i < 5; i++) {
                Console.Write("都道府県：");
                var n1 = Console.ReadLine();
                Console.Write("県庁所在地：");
                var n2 = Console.ReadLine();
                kentyou.Add(n1, n2);

                //すでに都道府県が登録されているか？
                if (kentyou.ContainsKey(n1)) {
                    //登録済み
                    Console.WriteLine("上書きしますか？(Y/N)");
                    if (Console.ReadLine() == "Y") {
                        //上書きする
                    } else {
                        //上書きしない
                    }
                }
            }
            foreach (var n in kentyou) {
                Console.WriteLine("{0}の県庁所在地は{1}です。", n.Key, n.Value);
            }

        }
    }
}

