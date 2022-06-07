using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enroll.src.entitys;

namespace Enroll
{
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();

            BundData(@"../../../data_file/course.csv");
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
            Course createCourse = new Course();
            createCourse.Name = txtCourseName.Text.ToString();
            createCourse.Code = txtCourseCode.Text.ToString();
            createCourse.Area = txtCourseArea.Text.ToString();

            if (isEmpty(createCourse.Name) 
                || isEmpty(createCourse.Code) 
                || isEmpty(createCourse.Area))
            {
                MessageBox.Show("You must complete all fields");
            }
            else {

                createCourse.InsertData();

                txtCourseName.Clear();
                txtCourseCode.Clear();
                txtCourseArea.Clear();

                BundData(@"../../../data_file/course.csv");

                MessageBox.Show("Done !");                
            
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BundData( String filePath ) {


            DataTable data = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0) {

                // first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    data.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = data.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    data.Rows.Add(dr);
                }

            }

            if (data.Rows.Count > 0) {

                dataGridView1.DataSource = data;
            
            }

        }


        private bool isEmpty(String obj) => String.IsNullOrEmpty(obj);
    }
}
