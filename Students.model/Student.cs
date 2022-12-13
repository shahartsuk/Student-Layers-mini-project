using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.model
{
    public class Student
    {
        public string Name { get; set; }
        private int _Age;
        private int _ID;
        public string Address { get; set; }
        public int ID { get { return _ID; } }
        public int age { get { return _Age; } }

        public Student(string name, int age, int iD, string address)
        {
            this.Name = name;
            this._ID = iD;
            this.Address = address;
            this._Age = age;
        }
    }
}
