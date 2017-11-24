using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMConfiguration.DateLevel
{
    class DiscountRateDate : List<DiscountRateItem>
    {
        static DiscountRateDate discountRateDate;
        public static DiscountRateDate Instance
        {
            get
            {
                if (discountRateDate == null)
                {
                    discountRateDate = new DiscountRateDate();
                    discountRateDate.initialize();
                }
                return discountRateDate;
            }
        }

        private void initialize()
        {
            this.Add("OKO_HW1", 0.30);
            this.Add("OKO_HW2", 0.35);
            this.Add("OKO_HW3", 0.40);
            this.Add("SHF_HW1", 0.30);
            this.Add("SHF_HW2", 0.35);
            this.Add("SHF_HW3", 0.40);
            this.Add("OKO_SW", 0.45);
            this.Add("G3D", 0.20);
            this.Add("GFS", 0.20);
            this.Add("LPD", 0.45);
            this.Add("LAP", 0.10);
            this.Add("LPM", 0.10);
            this.Add("GSV", 0.20);
            this.Add("LSV", 0.10);
        }

        private void Add(string v1, double v2)
        {
            this.Add(new DiscountRateItem()
            {
                Name = v1,
                DiscountRate = v2
            });
        }

        public double? this[string name]
        {
            get
            {
                var query = this.Where(n => n.Name == name);
                if(query.Count() ==0)
                {
                    return null;
                }
                return query.First().DiscountRate;
            }
            set
            {
                var query = this.Where(n => n.Name == name);
                if(query.Count() == 0)
                {
                    this.Add(new DiscountRateItem()
                    {
                        Name = name,
                        DiscountRate = value
                    });
                }
                else
                {
                    query.First().DiscountRate = value;
                }
            }
        }
    }
    public class DiscountRateItem
    {
        public string Name
        {
            get;
            set;
        }
        public double? DiscountRate
        {
            get;
            set;
        }
    }
}
