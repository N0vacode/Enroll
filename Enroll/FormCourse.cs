using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enroll.src;
using Enroll.src.entitys;

namespace Enroll
{
    public partial class FormCourse : Form
    {
        Course createCourse = new Course();

        public FormCourse()
        {
            InitializeComponent();

            Services.LoadDataToGridView(createCourse.courseFile, dataGridCourses);
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            createCourse.Name = txtCourseName.Text.ToString();
            createCourse.Code = txtCourseCode.Text.ToString();
            createCourse.Area = txtCourseArea.Text.ToString();

            if (Services.IsEmpty(createCourse.Name) 
                || Services.IsEmpty(createCourse.Code) 
                || Services.IsEmpty(createCourse.Area))
            {
                MessageBox.Show("You must complete all fields");
            }
            else {

                Services.InsertValuesToDataBase(createCourse.courseFile, createCourse.toString());

                txtCourseName.Clear();
                txtCourseCode.Clear();
                txtCourseArea.Clear();

                Services.LoadDataToGridView(createCourse.courseFile, dataGridCourses);
                

                MessageBox.Show("Done !");                
            
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        
    }
}
