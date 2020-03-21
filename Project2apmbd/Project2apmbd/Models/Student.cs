using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Project2apmbd.Models
{
    class Student
    {

        public Student() { }

        public Student(string name, string last,string studiesname,string mode,string sindexnumber,string birthdate, string email,string imiematki,string imieojca)
        {

            this.email = email;
            this.firstname = name;
            this.lastname = last;
            new Studies(studiesname, mode);
            this.indexnumber = sindexnumber;
            this.birthdate = birthdate;
            this.email = email;
            this.mothersname = imiematki;
            this.fathersname = imieojca;
        }


        public string firstname { get; set; }

        public string lastname { get; set; }
        public string birthdate { get; set; }
        public string email { get; set; }

        [XmlAttribute]
        public string indexnumber { get; set; }

        public string mothersname { get; set; }

        public string fathersname { get; set; }


        public Studies studies { get; set; }


    }
}
