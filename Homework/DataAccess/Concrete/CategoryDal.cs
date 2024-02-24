using Homework.DataAccess.Abstract;
using Homework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            categories = new List<Category>
            {
                new Category {Id=1,Name=""},
                new Category {Id=2,Name=""}

            };
        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            Category uptadeCategory=categories.SingleOrDefault(a=>a.Id==category.Id);   
            uptadeCategory.Name = category.Name;
        }
    }
}
