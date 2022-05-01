using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Events.Console
{
    internal class IDF
    {
        public int id;
        public int age;
        public bool IsStudent = false;
        public int HowManyDaysMiluim()
        {
            int ret =  26;

            if (age > 50)
                ret = 0;

            if (IsStudent)
            {
                ret = ret - 15;
            }

            return ret;
        }

        public void SoldierChangeStatus(int studentId, bool Student)
        {
            IsStudent = Student;
        }
    }
}
