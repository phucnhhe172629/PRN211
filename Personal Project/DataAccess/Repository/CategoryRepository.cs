using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category GetCategoryByID(int categoryID) => CategoryDAO.Instance.GetCategoryByID(categoryID);

        public IEnumerable<Category> GetCategorys() => CategoryDAO.Instance.GetCategoryList();

        public void InsertCategory(Category category) => CategoryDAO.Instance.AddNew(category);

        public void DeleteCategory(int categoryID) => CategoryDAO.Instance.Remove(categoryID);

        public void UpdateCategory(Category category) => CategoryDAO.Instance.Update(category);
    }
}
