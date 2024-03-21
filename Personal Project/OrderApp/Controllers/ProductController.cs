using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderApp.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository productRepository = new ProductRepository();
        // GET: productController
        public ActionResult Index([FromForm] string productname)
        {
            var list = productRepository.GetProducts();
            if (productname != null)
            {
                list = list.ToList()
                    .FindAll(p => p.ProductName.ToLower().Contains(productname.ToLower()));
            }
            return View(list);
        }

        // GET: productController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProductByID(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: productController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: productController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productRepository.InsertProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: productController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = productRepository.GetProductByID(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: productController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                productRepository.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: productController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = productRepository.GetProductByID(id);
            if (product == null)
            {
                return NotFound();
            }
            productRepository.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: productController/Delete/5
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
