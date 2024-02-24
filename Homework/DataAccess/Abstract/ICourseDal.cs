using Homework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
        List<Course> GetAll();
        
    }
}
