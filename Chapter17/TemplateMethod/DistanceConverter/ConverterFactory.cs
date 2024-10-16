﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    static class ConverterFactory {

        private static ConverterBase[] _converters = new ConverterBase[] {
            new MeterConverter(),
            new FeetConverter(),
            new YardConverter(),
            new InchConverter(),
            new MileConverter(),
            new KilometerConverter(),
        };

        public static ConverterBase getInstance(string name) {
            return _converters.FirstOrDefault(x => x.IsMyUnit(name));
        }
    }
}
