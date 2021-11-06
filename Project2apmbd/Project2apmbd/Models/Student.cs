using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Project2apmbd.Models
{
    public class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Birthdate { get; set; }
        public string Email { get; set; }

        [XmlAttribute]
        [JsonPropertyName("index nr")]
        public string IndexNumber { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public Studies Studies { get; set; }
        public Student()
        {
        }

        public Student(string name, string last, string studiesName, string mode, string sIndexNumber, string birthdate,
            string email, string imieMatki, string imieOjca)
        {
            this.Email = email;
            Firstname = name;
            Lastname = last;
            Studies = new Studies(studiesName, mode);
            IndexNumber = sIndexNumber;
            this.Birthdate = birthdate;
            this.Email = email;
            MothersName = imieMatki;
            FathersName = imieOjca;
        }
    }
}