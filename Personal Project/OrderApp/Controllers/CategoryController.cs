using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderApp.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepository categoryRepository = new CategoryRepository();
        // GET: categoryController
        public ActionResult Index()
        {
            var list = categoryRepository.GetCategorys();
            return View(list);
        }

        // GET: categoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: categoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryRepository.InsertCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: categoryController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = categoryRepository.GetCategoryByID(id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: categoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                categoryRepository.UpdateCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: categoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = categoryRepository.GetCategoryByID(id);
            if (category == null)
            {
                return NotFound();
            }
            categoryRepository.DeleteCategory(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: categoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
