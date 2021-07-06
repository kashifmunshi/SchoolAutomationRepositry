using AppEntity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AppContract.Interfaces;
using WebApp.VModels;

namespace WebApp.Controllers
{
    [Route("order")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _order;
        private readonly IDepartmentRepository _department;

        public OrderController(IOrderRepository order, IDepartmentRepository department)
        {
            _order = order;
            _department = department;
        }

        [HttpGet]
        [Route("/")]
        [Route("order-list")]
        public async Task<IActionResult> GetOrders()
        {
            return View(await _order.GetOrders());
        }

        [HttpGet]
        [Route("add-order")]
        public async Task<IActionResult> AddOrder()
        {
            return View(await CreateForm());
        }

        [HttpPost]
        [Route("add-order")]
        public async Task<IActionResult> AddOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return View(await CreateForm());
            }

            var status = await _order.SaveOrder(order);
            if (status > 0)
            {
                return RedirectToAction("GetOrders", "Order");
            }

            return View(await CreateForm());
        }

        private async Task<VOrder> CreateForm()
        {
            return new()
            {
                Departments = await _department.GetDepartments()
            };
        }
    }
}