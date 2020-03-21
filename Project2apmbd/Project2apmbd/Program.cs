using System;
using System.IO;
using System.Xml.Linq;
using System.Web;
using System.Xml.Serialization;
using System.Collections.Generic;

using System.Text.Json;
using Project2apmbd.Models;

namespace Project2apmbd
{
    class Program
    {
        static void Main(string[] args)
        {

            var output = args.Length > 1 ? args[1] : @"Files\result";
            var outputtype = args.Length > 2 ? args[2] : "xml";
 University university = new University();
         
            List<Student> studentlist = new List<Student>();

            var lines = System.IO.File.ReadAllLines(@"Files\data.csv");
            foreach (string line in lines)
            {

                String[] array = line.Split(",");

                university.Students.Add(new Student(array[0], array[1],array[2],array[3],array[4],array[5], array[6],array[7],array[8]));



            }

            using var writer = new FileStream($"{output}", FileMode.Create);
            var serializer = new XmlSerializer(typeof(University));


           
            serializer.Serialize(writer, university);




            var jsonString = JsonSerializer.Serialize( university);

            File.WriteAllText(@"Files:\dataj.json",jsonString);
     

        }
    }
}
