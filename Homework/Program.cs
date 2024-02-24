using Business.Concrete;
using Homework.Entities.Concrete;
using Homework.Business.Concrete;
using Homework.DataAccess.Abstract;
using Homework.DataAccess.Concrete;

namespace Homework
{
    public class Program
    {
        static void Main(string[] args)
        {



            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            categoryManager.Add(new Category() { Id = 3, Name = "New Category" });
            Console.WriteLine(categoryManager);


            CourseManager courseManager = new CourseManager(new CourseDal());
            courseManager.Add(new Course() {Name = "New Course" });
            Console.WriteLine(courseManager);


            InstructorManager instructorManager=new InstructorManager(new InstructorDal());
            instructorManager.Add(new Instructor() { Id = 3, Name = "New Instructor" });
            Console.WriteLine(instructorManager);


        }
    }
}