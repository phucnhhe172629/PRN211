using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderApp.Controllers
{
    public class BillController : Controller
    {
        IOrderRepository orderRepository = new OrderRepository();
        IBillRepository billRepository = new BillRepository();
        // GET: billController
        public ActionResult Index()
        {
            var list = billRepository.GetBills();
            return View(list);
        }

        // GET: billController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var bill = billRepository.GetBillByID(id.Value);
            if (bill == null)
            {
                return NotFound();
            }
            return View(bill);
        }

        // GET: billController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: billController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Bill bill)
        {
            if (ModelState.IsValid)
            {
                billRepository.InsertBill(bill);
                return RedirectToAction(nameof(Index));
            }
            return View(bill);
        }

        // GET: billController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var bill = billRepository.GetBillByID(id.Value);
            if (bill == null)
            {
                return NotFound();
            }
            return View(bill);
        }

        // POST: billController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Bill bill)
        {
            if (id != bill.BillId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                billRepository.UpdateBill(bill);
                return RedirectToAction(nameof(Index));
            }
            return View(bill);
        }

        // GET: billController/Delete/5
        public ActionResult Delete(int id)
        {
            var bill = billRepository.GetBillByID(id);
            if (bill == null)
            {
                return NotFound();
            }
            orderRepository.DeleOrdersByBill(id);
            billRepository.DeleteBill(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
