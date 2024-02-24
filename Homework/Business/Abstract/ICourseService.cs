using Homework.Business.Abstract;
using Homework.DataAccess.Abstract;
using Homework.DataAccess.Concrete;
using Homework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Business.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
        List<Course> GetAll();
    }
}
