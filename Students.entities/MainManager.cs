using Students.DAL;
using Students.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Students.entities
{
    public class MainManager
    {
        public Hashtable studentList = new Hashtable();
        private MainManager() { }

        private static readonly MainManager _Instance = new MainManager();
        public static MainManager Instance { get { return _Instance; } }

        private Students studentsData = new Students();
        public void Init() {
            studentsData.LoadStudents();
        }
        public void addStudentFromDB(Student std)
        {
            studentsData.addStudent(std);
        }
    }
}
