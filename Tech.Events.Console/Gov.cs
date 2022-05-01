using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Events.Console
{
    internal class Gov
    {
        public event Item.delRecall SendStopSale;
        public void SendRecall()
        {
            SendStopSale();
        }
    }
}
