using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Events.Console
{
    internal class CityHall
    {
        public int id;
        public int age;
        public bool IsStudent = false;
        public int CalculateArnona()
        {
            int ret =  200;

            if (age > 65)
                ret = 50;

            if (IsStudent)
            {
                ret = ret - 20;
            }

            return ret;
        }

        public void CitizenChangeStatus(int studentId, bool Student)
        {
            IsStudent = Student;
        }
    }
}
