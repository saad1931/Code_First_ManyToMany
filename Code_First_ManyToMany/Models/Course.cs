using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_First_ManyToMany.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Course_Name { get; set; }
        public int Description { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
