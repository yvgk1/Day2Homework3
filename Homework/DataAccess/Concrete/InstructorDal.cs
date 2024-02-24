using Homework.DataAccess.Abstract;
using Homework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal() 
        {
            instructors = new List<Instructor>
            {
                new Instructor {Id=1,Name="Engin",LastName="Demiroğ"},
                new Instructor {Id=2,Name="Halit Enes",LastName="Kalaycı"}
            };

        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor instructor)
        {
           Instructor uptadeInstructor= instructors.SingleOrDefault(b=>b.Name==instructor.Name);
            instructor.Name = uptadeInstructor.Name;
            instructor.LastName = uptadeInstructor.LastName;
        }
    }
}
