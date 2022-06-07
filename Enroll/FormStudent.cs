using Enroll.src;
using Enroll.src.entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enroll
{
    public partial class FormStudent : Form
    {
        Student student = new Student();


        public FormStudent()
        {
            InitializeComponent();
            txtGender.MaxLength = 1;
            Services.LoadDataToGridView(student.studentFile, dataGridStudents);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if ( Regex.IsMatch(txtPhoneNumber.Text.ToString(), @"^[0-9]+$") )
            {

                student.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
                student.Id = txtStudenId.Text.ToString();
                student.FirtsName = txtFirstName.Text.ToLowerInvariant().ToString();
                student.Surname = txtSurname.Text.ToLowerInvariant().ToString();
                student.Address = txtAddress.Text.ToLower().ToString();
                student.Mail = txtMail.Text.ToLower().ToString();
                student.Gender = txtGender.Text.ToUpper().ToString();

                if (Services.IsEmpty(student.Id) || Services.IsEmpty(student.FirtsName)
                      || Services.IsEmpty(student.Surname) || Services.IsEmpty(student.Address)
                      || Services.IsEmpty(student.Mail) || Services.IsEmpty(student.Gender))
                {

                    Services.InsertValuesToDataBase(student.studentFile, student.toString());

                    txtAddress.Clear();
                    txtFirstName.Clear();
                    txtGender.Clear();
                    txtMail.Clear();
                    txtPhoneNumber.Clear();
                    txtSurname.Clear();
                    txtStudenId.Clear();

                    Services.LoadDataToGridView(student.studentFile, dataGridStudents);

                }
                else {

                    MessageBox.Show("You must complete all fields");

                }






            }
            else
            {
                MessageBox.Show("The Given is Not a Number.");
            }



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }


}
