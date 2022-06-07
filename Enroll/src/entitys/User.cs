using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enroll.src.entitys
{
    public class User
    {

        public string FirtsName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string PathDataBase { get; set; }
        public string courseFile = @"../../../data_file/student.csv";
        public User() { }



    }
}
