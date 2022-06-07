using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enroll.src.entitys
{
    public class User
    {

        string FirtsName { get; set; }
        string Surname { get; set; }
        string Address { get; set; }
        string Mail { get; set; }
        string Gender { get; set; }
        int PhoneNumber { get; set; }
        string PathDataBase { get; set; }
        public User() { }


        public void InsertData(String data)
        {

            StreamWriter saveData = File.AppendText(PathDataBase);

            saveData.WriteLine(data);
            saveData.Close();


        }



    }
}
