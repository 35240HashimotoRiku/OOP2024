﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public abstract class ConverterBase {

        public abstract bool IsMyUnit(string name);

        //メートルとの比率（この比率を掛けるとメートルに変換できる）
        protected abstract double Ratio {  get; }
        
        //距離の単位名（たとえば、"メートル"、"フィート"など）
        public abstract string UnitName { get; }

        //メートルからの変換
        public double FromMeter(double meter) {
            return meter / Ratio;
        }

        //メートルへの変換
        public double ToMeter(double feet) { 
        return feet * Ratio;
        }
    }
}
