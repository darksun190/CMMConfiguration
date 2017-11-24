using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMConfiguration.DateLevel
{
    /// <summary>
    /// 报价中每一项产品的具体信息
    /// </summary>
    class ItemDate
    {
        string Onumber
        {
            get
            {
                return onumber.ToString();
            }
            set
            {
                onumber = new OrderNumber(value);
            }
        }
        OrderNumber onumber;
        string Name
        {
            get;
            set;
        }
        double UnitPrice
        {
            get;
            set;
        }
        int Quantity
        {
            get;
            set;
        }
        public Unit.Currency PriceCurrency
        {
            get;
            set;
        }
        public Unit.PurchaseChannel Channel
        {
            get;
            set;
        }
        public bool IncludeCustomFee
        {
            get;
            set;
        }
        public bool IncludeVAT
        {
            get;
            set;
        }
        public bool SpecifiedDiscount
        {
            set;
            get;
        }
        public double DiscountRate
        {
            get;
            set;
        }
        public bool WarrantyItem
        {
            get;
            set;
        }
        public string comment
        {
            get;
            set;
        }
    }
}
