using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enroll.src.entitys
{
    public class Enrolled
    {

        public string Studentname { get; set; }
        public string CourseName { get; set; }

        public string enrolledFile = @"../../../data_file/enrolled.csv";
        public Enrolled() { }

        public string toString()
            => Studentname + "," + CourseName;


    }
}
