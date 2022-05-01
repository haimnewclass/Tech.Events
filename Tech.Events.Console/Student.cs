using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Events.Console
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string   Mosad { get; set; }

        public delegate void ChangeStatus(int studentId,bool IsStudent);

        public event ChangeStatus ChangeStatusEventHandler;
        public void Register(string MosadName)
        {
            Mosad = MosadName;
            // IDF
            // CityHall
            // BTL
            // RavKav

            ChangeStatusEventHandler(Id, true);

        }

        public void LeftUniversity()
        {
            ChangeStatusEventHandler(Id, false);
        }
    }
}
