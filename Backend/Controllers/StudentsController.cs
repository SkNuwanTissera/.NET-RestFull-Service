using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Backend.Models;

namespace Backend.Controllers
{
    public class StudentsController : ApiController
    {
        Student[] students = new Student[]
            {
                new Student { id =1 , GuardianName="Nuwan Tissera", Name="Rasika Tissera", School="Visaka" },
                new Student { id =2 , GuardianName="Hello Tissera", Name="Hello Tissera", School="Visaka" },
                new Student { id =3 , GuardianName="Prasanna Tissera", Name="Nuwan Tissera", School="Ananda" },
                new Student { id =4 , GuardianName="Nuwan Tissera", Name="Prasanna Tissera", School="Ananda" }
            };

        [HttpGet]
        public IEnumerable<Student> GetAllStudents() {
            return students;
        }

        [HttpGet]
        public IHttpActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault((s) => s.id == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public void myPostmethod() { System.Diagnostics.Debug.WriteLine("My Post Method is called"); }
    }
}
