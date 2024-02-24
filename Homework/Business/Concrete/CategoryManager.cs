using Homework.Business.Abstract;
using Homework.DataAccess.Abstract;
using Homework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryService;

        public CategoryManager()
        {
        }

        public CategoryManager(ICategoryDal categoryService)
        {
            _categoryService = categoryService;
        }

        public void Add(Category category)
        {
            _categoryService.Add(category);
        }

        public void Delete(Category category)
        {
           _categoryService.Delete(category);
        }

        public List<Category> GetAll()
        {
           return _categoryService.GetAll();
        }

        public void Update(Category category)
        {
           _categoryService.Update(category);
        }
    }
}
