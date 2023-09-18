using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsTry
{
    public class Student
    {
        public int Id { get; set; }
        public static int Counter { get; set; } = 0;
        public string FirstName { get; set; } = null!;
        public string LasttName { get; set; }=null!;
        public string Class { get; set; }=null!;
        public Student(String firstName , string lastName , string _Class)
        {
            Id = ++Counter;
            FirstName = firstName;
            LasttName = lastName;
            Class = _Class;
        }

        public override string ToString()
        {
            return $"ID : {Id}" +
                $"\nName : {FirstName} {LasttName}" +
                $"\nClass: {Class}";
        }
    }
}
