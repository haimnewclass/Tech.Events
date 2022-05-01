using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Events.Console
{
    internal class Program
    {
        static void TestDelegate()
        {
            Item item = new Item()
            {
                name = "CocaCola",
                price = 10
            };


            Item item2 = new Item()
            {
                name = "Car",
                price = 200000
            };
            Item item3 = new Item()
            {
                name = "Chocolad",
                price = 30
            };


            System.Console.WriteLine(item.calculatePrice(item.add_Regular));
            System.Console.WriteLine(item2.calculatePrice(item2.add_Eilat));
            System.Console.WriteLine(item3.calculatePrice(item3.add_AyaroyPituach));

            Item.delCalcPrice myFunc = (y) => { return y * 0.11; };
            System.Console.WriteLine(myFunc(111));
            item2.calculatePrice(myFunc);



            DelegateSample delegateSample = new DelegateSample();
            delegateSample.size = 10;
            delegateSample.name = "Fifa";
            delegateSample.Run();



        }

        static void TestEvent()
        {

            Student student = new Student()
            {
                Name = "Shlomi",
                Id = 123
            };

            CityHall hall = new CityHall()
            {
                id = 123

            };

            IDF idf = new IDF()
            {
                age = 25

            };
            int g = 10;
            g += 1; // g=g+1
            g += 10;

            student.ChangeStatusEventHandler += idf.SoldierChangeStatus;
            student.ChangeStatusEventHandler += hall.CitizenChangeStatus;
            student.ChangeStatusEventHandler += hall.CitizenChangeStatus;

            // student.ChangeStatusEventHandler -= hall.CitizenChangeStatus;

            student.Register("BarIlan");
        }

        private static void Student_ChangeStatusEventHandler(int studentId, bool IsStudent)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {

            TestEvent();



        }



    }
}
