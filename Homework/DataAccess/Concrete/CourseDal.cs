using Homework.Business.Abstract;
using Homework.DataAccess.Abstract;
using Homework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DataAccess.Concrete
{
    public class CourseDal:ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            courses = new List<Course>
            {
                new Course {CourseId=1,Name="",Price=10.1,InstructorId=1},
                new Course {CourseId=2,Name="",Price=20.1,InstructorId=1}

            };
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
         courses.Remove(course);
        }

        public List<Course> GetAll()
        {
          return courses;
        }

        public void Update(Course course)
        {
            Course updateCourse=courses.SingleOrDefault(a=>a.CourseId==course.CourseId);
           updateCourse.Name = course.Name;
        }
    }

}
