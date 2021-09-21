using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_First_ManyToMany.Models
{
    public class StudentCourse
    {
        public int ID { get; set; }
        public Student Student { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
