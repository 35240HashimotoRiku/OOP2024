using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter.Model {
    internal class GramUnit : WeightUnit {
        private static List<GramUnit> units = new List<GramUnit> {
            new GramUnit{  Name = "g",Coefficient = 1,},
            new GramUnit{  Name = "kg",Coefficient = 1000,},
        };
        public static ICollection<GramUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromMetricUnit(PoundUnit unit, double value) {
            return (value * unit.Coefficient) / 25.4 / this.Coefficient;
        }
    }
}
