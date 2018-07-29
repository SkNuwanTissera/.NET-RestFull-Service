using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Student
    {
        public int id { get; set; }
        public String Name { get; set; }
        public String School { get; set; }
        public String Grade { get; set; }
        public String GuardianName { get; set; }
    }
}