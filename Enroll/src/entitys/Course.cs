using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enroll.src.entitys
{


    public class Course
    {

        public string Name { get; set; }
        public string Code { get; set; }
        public string Area { get; set; }


        public string courseFile = @"../../../data_file/course.csv";
    


  

        public string toString() => Code + "," + Name + "," + Area;

        
       

    }

}
