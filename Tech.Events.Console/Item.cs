using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Events.Console
{
    internal class Item
    {
        public delegate double delCalcPrice(double itemPrice);
        public delegate void delRecall();
        private bool StopSale = false;
        public double price    { get; set; }
        public string name { get; set; }

        public void StopRecallSwitch()
        {
            StopSale = true;
        }
        public double calculatePrice(delCalcPrice func)
        {
            double ret = func(price)+price;

            if (StopSale) ret = -1;

            return ret;
        }

        public double add_Eilat(double itemPrice)
        {
            return 0;
        }

        public double add_AyaroyPituach(double itemPrice)
        {
            return itemPrice*0.05;
        }

        public double add_Regular(double itemPrice)
        {
            return itemPrice * 0.17;
        }

    }
}
