using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using BusinessObject;
using System.Security.Cryptography;

namespace OrderApp.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepository orderRepository = new OrderRepository();
        // GET: OrderController
        public ActionResult Index(int? id)
        {
            List<Order> list = null;
            if (id != null)
            {

                list = orderRepository.GetOrdersByBillID(id.Value);
            }
            else
            {
                list = orderRepository.GetNewOrders();
            }
            return View(list);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int? bid, int? pid)
        {
            if (bid == null || pid == null)
            {
                return NotFound();
            }
            var order = orderRepository.GetOrderByID(bid.Value, pid.Value);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                orderRepository.InsertOrder(order);
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int? bid, int? pid)
        {
            if (bid == null || pid == null)
            {
                return NotFound();
            }
            var order = orderRepository.GetOrderByID(bid.Value, pid.Value);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int bid, int pid, Order order)
        {
            if (bid != order.BillId || pid != order.ProductId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                orderRepository.UpdateOrder(order);
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int bid, int pid)
        {
            var order = orderRepository.GetOrderByID(bid, pid);
            if (order == null)
            {
                return NotFound();
            }
            orderRepository.DeleteOrder(bid, pid);
            return RedirectToAction(nameof(Index));
        }

        // POST: OrderController/Delete/5
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
