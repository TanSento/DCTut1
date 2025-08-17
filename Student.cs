using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Person
    {
        private int id;
        private string university;

        public int Id { 
            get { return id; }  //get the value of the id field
            set { id = value; }  //set the value of the id field
        }
        public string University { 
            get { return university; }
            set { university = value; }
        }

        public override string ToString()  //override the ToString method in the Person class
        {
            string info = "The student's name is " + Name + "\n";
            info += "The student's id is " + Id + "\n";
            info += "The student's university is " + University + "\n";
            return info;
        }
    }

}