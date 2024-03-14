using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace eStore.Controllers
{
    public class OrderDetailsController : Controller
    {
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        // GET: OrderDetailsController
        public ActionResult Index(int oid)
        {
            var orderDetailList = orderDetailRepository.GetOrderDetailListByID(oid);
            return View(orderDetailList);
        }
        // GET: OrderDetailsController/Details/5
        public ActionResult Details(int? oid, int? pid)
        {
            if (oid == null || pid == null)
            {
                return NotFound();
            }
            var orderDetail = orderDetailRepository.GetOrderDetailByID(oid.Value, pid.Value);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // GET: OrderDetailsController/Create
        public ActionResult Create(int oid)
        {
            ViewBag.oid = oid;
            return View();
        }

        // POST: OrderDetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderDetail orderDetail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    orderDetailRepository.InsertOrderDetail(orderDetail);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderDetailsController/Edit/5
        public ActionResult Edit(int? oid, int? pid)
        {
            if (oid == null || pid == null)
            {
                return NotFound();
            }
            var orderDetail = orderDetailRepository.GetOrderDetailByID(oid.Value, pid.Value);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int oid, int pid, OrderDetail orderDetail)
        {
            try
            {
                if (oid != orderDetail.OrderId || pid != orderDetail.ProductId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    orderDetailRepository.UpdateOrderDetail(orderDetail);
                }
                OrdersController ordersController = new OrdersController();
                return RedirectToAction(nameof(ordersController.Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: OrderDetailsController/Delete/5
        public ActionResult Delete(int? oid, int? pid)
        {
            if (oid == null || pid == null)
            {
                return NotFound();
            }
            var orderDetail = orderDetailRepository.GetOrderDetailByID(oid.Value, pid.Value);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int oid, int pid)
        {
            try
            {
                orderDetailRepository.DeleteOrderDetail(oid, pid);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
