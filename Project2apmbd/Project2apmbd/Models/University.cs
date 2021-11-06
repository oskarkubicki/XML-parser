using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
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
        [JsonPropertyName("Author")]

        public string Author { get; set; }

        [XmlAttribute(AttributeName = "createdAt")]
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }

        public HashSet<Student> Students { get; set; }
    }
}