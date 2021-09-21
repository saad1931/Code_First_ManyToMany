using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_First_ManyToMany.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }

    }
}
