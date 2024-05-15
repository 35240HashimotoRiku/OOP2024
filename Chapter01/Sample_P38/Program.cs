using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_P38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                IDictionary = 100,
                nameof = "山田太郎";
                Birthday = new DateTime(1992, 4, 5),
                DivisonName = "第一営業部",
            };
            Console.WriteLine("{0}({1})は、{2}に所属しています。",
            employee.Name, employee.GetAge(), employee.DivisionName);

        }
    }
}
