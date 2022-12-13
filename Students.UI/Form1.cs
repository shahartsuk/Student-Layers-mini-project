using Students.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Students.model;

namespace Students.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainManager.Instance.Init();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Student tempStd = new Student(textName.Text,Convert.ToInt32(textAge.Text),  Convert.ToInt32(textID.Text), textAddress.Text);
            MainManager.Instance.studentList.Add(Convert.ToInt32(textID.Text), tempStd);
            MainManager.Instance.addStudentFromDB(tempStd);
            textName.Text = "";
            textAge.Text = "";
            textID.Text = "";
            textAddress.Text = "";
        }

        private void getStudentbutton_Click(object sender, EventArgs e)
        {
            int check = Convert.ToInt32(textID.Text);
            Student std = (Student)MainManager.Instance.studentList[check];
            textName.Text = std.Name;
            textAddress.Text = std.Address;
            textAge.Text = std.age.ToString();
        }

        private void buttonIniDB_Click(object sender, EventArgs e)
        {
            MainManager.Instance.Init();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textAge.Text = "";
            textID.Text = "";
            textAddress.Text = "";
        }
    }
}
