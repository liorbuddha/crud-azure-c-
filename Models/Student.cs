using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Student
    {
        public string id { get; set; }
        public string firstName { get; set; }

        public string  lastName { get; set; }
        public Course[] courses { get; set; }

        public Address[] adresses { get; set; }
        public static List<Student> convertStringIntoStudentData(string studentsAsString)
        {
            if (String.IsNullOrEmpty(studentsAsString))
            {
                return new List<Student>();
            }
            //get the students out of the string
            return System.Text.Json.JsonSerializer.Deserialize<List<Student>>(studentsAsString);
        }
    }
}
