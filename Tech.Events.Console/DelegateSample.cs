using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Events.Console
{
    public class DelegateSample
    {
        public delegate int delChange(int num);

        
        public int size = 0;
        public string name = "";

        public int ChangeNo(int a)
        {
            return a;
        }
        public int ChangeMinus(int a)
        {
            return a - 1;
        }
        public int ChangePlus(int a)
        {
            return a + 1;
        }
        public void PrintDetails(delChange func)
        {
            if(func !=null)
                 size = func(size);

            System.Console.WriteLine(name+" " + size);
        }
        public delChange func2;
        public void Run()
        {

            func2(345);// exception null

            func2 = ChangePlus;
            func2(1234);
            func2(1234);
            func2(1234);
            func2(1234);
            func2 = ChangeMinus;
            func2(1234);
            func2(1234);
            func2(1234);

            PrintDetails(null);
            PrintDetails(ChangeMinus);
            PrintDetails(ChangePlus);
        }
    }
}
