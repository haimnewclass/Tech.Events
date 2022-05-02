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
            System.Collections.Generic.Queue<int> q = new Queue<int>();
            q.Enqueue(123);
            int a = q.Dequeue();

            string str = "[123]";
            str = str.Replace("[", "");
            str = str.Replace("]", "");


            SendStopSale();
        }
    }
}
