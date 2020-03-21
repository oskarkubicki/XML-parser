using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Project2apmbd.Models
{
    public class University
    {


        public University()
        {

            Students = new HashSet<Student>();
            CreatedAt = DateTime.Now.ToString();
            Author = "Oskar Kubicki";
        }
        [XmlAttribute]

        public string Author { get; set; }

        [XmlAttribute(AttributeName = "createdAt")]
        public string CreatedAt { get; set; }

        public HashSet<Student> Students { get; set; }
    }
}
