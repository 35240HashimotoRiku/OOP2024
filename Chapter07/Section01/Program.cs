using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var employeeDict = new Dictionary<int, Employee> {
   { 100, new Employee(100, "清水遼久") },
   { 112, new Employee(112, "芹沢洋和") },
   { 125, new Employee(125, "岩瀬奈央子") },
};

            employeeDict.Add(126, new Employee(126, "庄野遥"));


            foreach (var item in employeeDict.Values) { 
              //  Console.WriteLine($"{item.Key}{item.Name}");
            }

        }
    }
}
