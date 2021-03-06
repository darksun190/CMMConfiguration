﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMConfiguration.DateLevel
{
    /// <summary>
    /// 配置的数据层，通常包含多个组
    /// </summary>
    class ConfigurationDate : List<GroupDate>
    {
        public string Name
        {
            get;
            set;
        }
        public string comment
        {
            get;
            set;
        }
        public Unit.Currency QuotationCurrency
        {
            get;
            set;
        }
        public double PriceWithoutDiscount
        {
            get;
        }
        public double PriceWithDiscount
        {
            get;
        }
        
    }
}
