using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMConfiguration.DateLevel
{
    /// <summary>
    /// 整个文件的数据层，通常包括一个或多个配置，整合为汇总页
    /// </summary>
    static class WorkbookDate
    {
        static WorkbookDate()
        {
            firstRun = true;
        }
        /// <summary>
        /// how much RMB which 1 EUR changed, like 7.85
        /// </summary>
        static public double EURrate
        {
            get;
            set;
        }
        /// <summary>
        /// how much RMB which 1 USD changed, like 6.60
        /// </summary>
        static public double USDrate
        {
            get;
            set;
        }
        private static double customFeeRate = 0.05;
        public static double CustomFeeRate
        {
            get
            {
                return customFeeRate;
            }
            set
            {
                customFeeRate = value;
            }
        }
        private static double vatRate = 0.17;
        public static double VATRate
        {
            get
            {
                return vatRate;
            }
            set
            {
                vatRate = value;
            }
        }
        public static double GPRate
        {
            get;
            set;
        }
        public static DiscountRateDate Discount
        {
            get
            {
                return DiscountRateDate.Instance;
            }
        }
        public static bool firstRun
        {
            get;
            set;
        }
    }
}
