﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize1 {
    internal class Exrsize2 {
        //private const double ratio = 0.254;//定数
        public static readonly double ratio = 0.0254; //定数（外部にも公開する場合）
        //メートルからインチを求める
        public static double MeterToInch(double meter) {
            return meter * ratio;
        }
        //インチからメートルを求める
        public static double InchToMeter(double inch) {
            return inch * ratio;
        }

        internal double FromMeter(int meter) {
            throw new NotImplementedException();
        }

    }
}
