﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    public class Sale {
        //店舗名
        public string Name { get; set; }
        //商品カテゴリ
        public string subject { get; set; }
        //売上高
        public int Score { get; set; }
    }
}
