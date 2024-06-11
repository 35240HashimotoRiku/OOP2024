using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//模範解答
namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var prefOfficeDict = new Dictionary<string, string>();
            //入力処理
            Console.WriteLine("県庁所在地の登録");
            for (int i = 0; i < 5; i++) {
                //都道府県の入力
                Console.Write("都道府県:");
                String pref = Console.ReadLine();

                //県庁所在地の入力
                Console.Write("県庁所在地:");
                String prefCaptalLocation = Console.ReadLine();

                //既に都道府県が登録されているか？
                if (prefOfficeDict.ContainsKey(pref)) {
                    //登録済み
                    Console.WriteLine("上書きしますか？(Y/N)");
                    if (Console.ReadLine() == "N") {
                        continue;
                    }
                }
                prefOfficeDict[pref] = prefCaptalLocation;
            }
            Console.WriteLine();//改行

            Boolean endFlag = false;    //終了フラグ（無限ループを抜け出す用）
            while (true) {
                Console.WriteLine("**** メニュー ****");
                Console.WriteLine("1：一覧表示");
                Console.WriteLine("2：検索");
                Console.WriteLine("9：終了");
                Console.Write(">");
                String menuSelect = Console.ReadLine();
                switch (menuSelect) {
                    case "1":
                        //一覧出力処理
                        foreach (var item in prefOfficeDict) {
                            Console.WriteLine("{0}の県庁所在地は{1}です。", item.Key, item.Value);
                        }
                        break;

                    case "2":
                        //都道府県の入力
                        Console.Write("都道府県:");
                        String searchPref = Console.ReadLine();
                        Console.WriteLine(searchPref + "の県庁所在地は" + prefOfficeDict[searchPref] + "です");
                        break;

                    case "9":
                        endFlag = true; //終了フラグＯＮ
                        break;
                }
                if (endFlag) {
                    break;
                }
            }
        }
    }
}
