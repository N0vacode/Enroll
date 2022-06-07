using Enroll.src;
using Enroll.src.entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enroll
{
    public partial class FormEnrolled : Form
    {

        Student student = new Student();
        Course course = new Course();
        Enrolled enrolled = new Enrolled();
        public FormEnrolled()
        {
            InitializeComponent();
            Services.LoadDataToComboBox(student.studentFile, comboBoxStudent, 1);
            Services.LoadDataToComboBox(course.courseFile, comboBoxCourse, 0);
            Services.LoadDataToGridView(enrolled.enrolledFile, dataGridViewEnrolled);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
        
            enrolled.CourseName = comboBoxCourse.Text.ToString();
            enrolled.Studentname = comboBoxStudent.Text.ToString();

            Services.InsertValuesToDataBase(enrolled.enrolledFile, enrolled.toString());
            Services.LoadDataToGridView(enrolled.enrolledFile, dataGridViewEnrolled);
        }





    }
}
