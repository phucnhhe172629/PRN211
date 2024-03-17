using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Category> GetCategoryList()
        {
            var categorys = new List<Category>();
            try
            {
                using var context = new PRNProjectContext();
                categorys = context.Categorys.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return categorys;
        }

        public Category GetCategoryByID(int categoryID)
        {
            Category category = null;
            try
            {
                using var context = new PRNProjectContext();
                category = context.Categorys.SingleOrDefault(c => c.CategoryId == categoryID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return category;
        }

        // Add new a Category
        public void AddNew(Category category)
        {
            try
            {
                Category _category = GetCategoryByID(category.CategoryId);
                if (_category == null)
                {
                    using var context = new PRNProjectContext();
                    context.Categorys.Add(category);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Category is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Update a Category
        public void Update(Category category)
        {
            try
            {
                Category _category = GetCategoryByID(category.CategoryId);
                if (_category != null)
                {
                    using var context = new PRNProjectContext();
                    context.Categorys.Update(category);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Category does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Remove a Category
        public void Remove(int categoryId)
        {
            try
            {
                Category category = GetCategoryByID(categoryId);
                if (category != null)
                {
                    using var context = new PRNProjectContext();
                    context.Categorys.Remove(category);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Category does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
