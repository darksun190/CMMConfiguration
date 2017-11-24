using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMConfiguration.DateLevel
{
    /// <summary>
    /// 订单号是三组数字，以横线连接
    /// 例如600342-1234-000
    /// </summary>
    class OrderNumber
    {
        string ostr;
        public OrderNumber(string a)
        {
            ostr = Parse(a);
        }

        private string Parse(string a)
        {
            if(a.Length == 13)
            {
                foreach(var c in a)
                {
                    if(!char.IsDigit(c))
                    {
                        throw new FormatException("string should contain 13 digits");
                    }
                    return a;
                }
            }

            if(a.Length == 15)
            {
                if(a[6]=='-' && a[11] == '-')
                {
                    string alterstr = a.Remove(11, 1);
                    alterstr = alterstr.Remove(6, 1);
                    return Parse(alterstr);
                }
                else
                {
                    throw new FormatException("string should contain 15 digits seperate by 2 '-'");
                }
            }

            throw new FormatException("string lengh should be 13 or 15");
        }

        public override string ToString()
        {
            return ostr;
        }
    }
}
