using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enroll.src.entitys
{

    
    internal class Student: User
    {
        public string Id { get; set; }
        public string studentFile = @"../../../data_file/student.csv";
        public Student() { }

        public string toString()
            => Id + "," + FirtsName + "," + Surname + "," + Address + "," + Mail + "," + Gender + "," + PhoneNumber;
    }
}
