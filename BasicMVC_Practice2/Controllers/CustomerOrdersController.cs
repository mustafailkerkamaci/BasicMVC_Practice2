using Microsoft.AspNetCore.Mvc;
using BasicMVC_Practice2.Models;

namespace BasicMVC_Practice2.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var model = new CustomerViewModel(); // customerviewmodel nesnesi olusturuyouz
            model.Customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john@doe.com"
            };
            model.Orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    ProductName = "Laptop",
                    Price = 1200.00m,
                    Quantity = 1
                },
                new Order
                {
                    Id = 2,
                    ProductName = "Smartphone",
                    Price = 800.00m,
                    Quantity = 2
                }
            };

            return View(model);// modeli view'e gonderiyoruz
        }
    }
}
