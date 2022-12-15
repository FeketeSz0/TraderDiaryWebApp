using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderApp.Model
{
    public class Securities
    {
        public Securities(int id, string shortName, string fullName,  double boughtPrice, double soldPrice)
        {
            this.id = id;
            ShortName = shortName;
            FullName = fullName;
            
            BoughtPrice = boughtPrice;
   
            SoldPrice = soldPrice;
        }
        public Securities()
        {

        }
        public int id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        
        public double BoughtPrice { get; set; }

        public double SoldPrice { get; set; }
    }
}
