using Students.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.model;

namespace Students.entities
{
    public class Students : BaseEntity
    {
        public void LoadStudents()
        {
            SQLQuery.RunCommandResult("select * from StudentInfo", insertToHashTableFromDB);
        }
        public object insertToHashTableFromDB(SqlDataReader reader)
        {
            MainManager.Instance.studentList.Clear();
            while (reader.Read())
            {
                string Name = reader.GetString(0);
                int Age = reader.GetInt32(1);
                string Address = reader.GetString(2);
                int ID = reader.GetInt32(3);
                Student student = new Student(Name, Age, ID, Address);
                MainManager.Instance.studentList.Add(ID, student);
            }
            return MainManager.Instance.studentList;
        }
        public void addStudent(Student tempStd)
        {
            string Query = string.Format("insert into StudentInfo (Name,Age,Address,ID) values ('{0}','{1}','{2}','{3}')", tempStd.Name, tempStd.age, tempStd.Address, tempStd.ID);
            SQLQuery.RunNonQuery(Query);
        }
    }
}
