using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using ECommerceOrder.Data;
using ECommerceOrder.ViewModel;

namespace ECommerceOrder.Controllers
{ 
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            // 🔹 Top 5 Selling Products
            var topProducts = _context.OrderItems
                .Include(o => o.Product)
                .GroupBy(o => o.Product)
                .Select(g => new
                {
                    Product = g.Key,
                    Count = g.Sum(x => x.Quantity)
                })
                .OrderByDescending(x => x.Count)
                .Take(5)
                .Select(x => x.Product)
                .ToList();

            // 🔹 Pending Orders
            var pendingOrders = _context.Orders
                .Include(o => o.ShippingDetail)
                .Where(o => o.ShippingDetail.Status == "Pending")
                .ToList();

            // 🔹 Customer Order Summary
            var summary = _context.Orders
                .Include(o => o.Customer)
                .GroupBy(o => o.Customer.Name)
                .Select(g => new
                {
                    Customer = g.Key,
                    Count = g.Count()
                })
                .ToDictionary(x => x.Customer, x => x.Count);

            var vm = new DashboardViewModel
            {
                TopProducts = topProducts,
                PendingOrders = pendingOrders,
                CustomerOrderSummary = summary
            };

            return View(vm);
        }
    }
}
