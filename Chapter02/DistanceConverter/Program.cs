using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintInchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからフィートへの対応表を出力
                PrintMeterToInchList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }

        private static void PrintMeterToInchList(int start, int stop) {
            InchConverter fc = new InchConverter();
            for (int meter = start; meter <= stop; meter++) {
                double Inch = fc.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.000} ft", meter, Inch);
            }
        }

        private static void PrintInchToMeterList(int start, int stop) {
            InchConverter fc = new InchConverter();
            for (int inch = start; inch <= stop; inch++) {
                double meter = fc.FromMeter(inch);
                Console.WriteLine("{0} ic = {1:0.000} m", inch, meter);
            }
        }


    }
}
