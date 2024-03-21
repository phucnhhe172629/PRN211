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
        public ActionResult Index([FromForm] int? tableid, [FromForm] int? numberofpeople, [FromForm] decimal? minprice, [FromForm] string timein, [FromForm] string timeout)
        {
            var list = billRepository.GetBills();
            if (tableid != null)
            {
                list = list.ToList()
                    .FindAll(b => b.TableId == tableid);
            }
            if (numberofpeople != null)
            {
                list = list.ToList()
                    .FindAll(b => b.NumberOfPeople == numberofpeople);
            }
            if (minprice != null)
            {
                list = list.ToList()
                    .FindAll(b => b.Total >= minprice);
            }
            if (timein != null)
            {
                list = list.ToList()
                    .FindAll(b => b.TimeIn >= DateTime.Parse(timein));
            }
            if (timeout != null)
            {
                list = list.ToList()
                    .FindAll(b => b.TimeOut <= DateTime.Parse(timeout));
            }
            decimal? total = 0;
            foreach (var item in list)
            {
                total += item.Total;
            }
            ViewBag.total = total;
            return View(list.OrderByDescending(b => b.BillId));
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

        public ActionResult Completed(int id)
        {
            Bill bill = billRepository.GetBillByID(id);
            bill.Status = 2;

            orderRepository.Completed(id);
            billRepository.UpdateBill(bill);
            return RedirectToAction(nameof(Index));
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
