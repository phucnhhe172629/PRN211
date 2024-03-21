using BusinessObject;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace OrderApp.Controllers
{
    public class MenuController : Controller
    {
        IProductRepository productRepository = new ProductRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        IBillRepository billRepository = new BillRepository();
        IOrderRepository orderRepository = new OrderRepository();
        public IUserRepository userRepository = new UserRepository();
        private readonly ILogger<MenuController> _logger;
        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
        }
        // GET: LoginController
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([FromForm] string username, [FromForm] string password)
        {
            User user = userRepository.GetUserByAccount(username, password);
            if (user != null)
            {
                if (user.Role.Equals("admin"))
                {
                    return RedirectToAction("Index", "User");
                }

                if (user.Role.Equals("customer"))
                {
                    SessionExtensions.SetString(HttpContext.Session, "id", user.UserId.ToString());
                    Bill bill = new Bill()
                    {
                        TableId = 1,
                        NumberOfPeople = 4,
                        Total = 0,
                        TimeIn = DateTime.Now,
                        TimeOut = DateTime.Now,
                        Status = 1,
                    };
                    billRepository.InsertBill(bill);
                    TempData["bid"] = bill.BillId;
                    return RedirectToAction(nameof(Menu), new { bid = bill.BillId });
                }
            }
            else
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Login));
        }
        public bool checkSession()
        {
            if (SessionExtensions.GetString(HttpContext.Session, "id") != null)
            {
                return true;
            }
            return false;
        }
        public ActionResult About()
        {
            ViewBag.BillId = TempData["bid"];
            return View();
        }
        public ActionResult Menu(int bid)
        {
            if (checkSession())
            {
                List<Category> categories = categoryRepository.GetCategorys().ToList();
                List<Product> products = productRepository.GetProducts().ToList();

                ViewBag.BillId = bid;

                ViewBag.Categories = categories;
                ViewBag.Products = products;
                return View();
            }
            ViewBag.Error = "Hãy thông báo cho quản lí hoặc nhân viên của nhà hàng";
            return RedirectToAction(nameof(Login));
        }
        public ActionResult Order(int bid)
        {
            if (checkSession())
            {
                List<Order> orders = orderRepository.GetOrdersByBillID(bid);

                ViewBag.BillId = bid;
                ViewBag.Orders = orders;
                return View();
            }
            ViewBag.Error = "Hãy thông báo cho quản lí hoặc nhân viên của nhà hàng";
            return RedirectToAction(nameof(Login));
        }

        public ActionResult PlaceOrder(int pid, int bid)
        {
            if (checkSession())
            {
                Order order = new Order()
                {
                    BillId = bid,
                    ProductId = pid,
                    Quantity = 1,
                    Status = "Thêm mới",
                };
                orderRepository.InsertOrder(order);

                Bill bill = billRepository.GetBillByID(bid);
                Product product = productRepository.GetProductByID(pid);
                bill.Total += product.Price;

                billRepository.UpdateBill(bill);
                return RedirectToAction(nameof(Menu), new { bid = bid });
            }
            ViewBag.Error = "Hãy thông báo cho quản lí hoặc nhân viên của nhà hàng";
            return RedirectToAction(nameof(Login));
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int? bid, int? pid)
        {
            if (checkSession())
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
            ViewBag.Error = "Hãy thông báo cho quản lí hoặc nhân viên của nhà hàng";
            return RedirectToAction(nameof(Login));
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int bid, int pid, Order order)
        {
            if (checkSession())
            {
                if (bid != order.BillId || pid != order.ProductId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    orderRepository.UpdateOrder(order);
                    return RedirectToAction(nameof(Order), new { bid = bid });
                }
                return View(order);
            }
            ViewBag.Error = "Hãy thông báo cho quản lí hoặc nhân viên của nhà hàng";
            return RedirectToAction(nameof(Login));
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int bid, int pid)
        {
            if (checkSession())
            {
                var order = orderRepository.GetOrderByID(bid, pid);
                if (order == null)
                {
                    return NotFound();
                }
                if (order.Status.Equals("Thêm mới"))
                {
                    orderRepository.DeleteOrder(bid, pid);
                }
                else
                {
                    ViewBag.Error = "Tạm thời không thể hủy, thông báo tới quán lí hoặc nhân viên của nhà hàng để biết thêm chi tiết";
                }
                return RedirectToAction(nameof(Order), new { bid = bid });
            }
            ViewBag.Error = "Hãy thông báo cho quản lí hoặc nhân viên của nhà hàng";
            return RedirectToAction(nameof(Login));
        }

    }
}
