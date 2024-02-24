using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Entities.Concrete
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InstructorId { get; set; }

    }
}
