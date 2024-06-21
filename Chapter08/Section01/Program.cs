using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("生年月日を入力");
            Console.Write("年：");
            var year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            var month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            var day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);

            //あなたは平成○○年〇月〇日〇曜日に生まれました
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = birthday.ToString("ggyy年M月d日(dddd)", culture);
            Console.WriteLine(str);

            //あなたは生まれてから今日で〇〇〇〇日目です
            var today = DateTime.Today;
            TimeSpan diff = today.Date - birthday.Date;
            Console.WriteLine("{0}日間", diff.Days);
        }
    }
}

