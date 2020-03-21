using System;
using System.Collections.Generic;
using System.Text;

namespace Project2apmbd.Models
{
    class Student
    {

        public Student() { }

        public Student(string name, string last, string email)
        {

            this.email = email;
            this.firstname = name;
            this.lastname = last;
        }


        public string firstname { get; set; }

        public string lastname { get; set; }
        public string birthdate { get; set; }
        public string email { get; set; }

        public string mothersname { get; set; }
    }
}
