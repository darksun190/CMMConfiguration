using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMConfiguration.DateLevel
{
    /// <summary>
    /// 每份配置分为几个组，例如机器硬件，软件，上下料，现场服务等
    /// 每个组可能有共同点，例如相同的折扣等
    /// </summary>
    class GroupDate : List<ItemDate>
    {
        public string Name
        {
            get;
            set;
        }
        public Unit.Currency QuotationCurrency
        {
            get;
            set;
        }
        public double PriceBeforeDiscount
        {
            get;
            set;
        }
        public double PriceAfterDiscount
        {
            get;
            set;
        }
    }
}
