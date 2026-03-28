
using ECommerceOrder.Data;
using ECommerceOrder.Data;
using ECommerceOrder.Models;
using ECommerceOrder.Models;
using ECommerceOrder.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class OrdersController : Controller
{
    private readonly ApplicationDbContext _context;

    public OrdersController(ApplicationDbContext context)
    {
        _context = context;
    }

    
    public IActionResult Index()
    {
        var orders = _context.Orders
            .Include(o => o.Customer)
            .Include(o => o.ShippingDetail)
            .ToList();

        return View(orders);
    }

    
    public IActionResult Create()
    {
        ViewBag.CustomerId = new SelectList(_context.Customers, "CustomerId", "Name");
        ViewBag.Products = _context.Products.ToList();
        return View();
    }

    // POST: Orders/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Order order, List<int> productIds, List<int> quantities)
    {
        
        ModelState.Remove("OrderItems");
        ModelState.Remove("Customer");
        ModelState.Remove("ShippingDetail");
        ModelState.Remove("ShippingDetail.Order");   

        if (ModelState.IsValid)
        {
            
            _context.Orders.Add(order);
            _context.SaveChanges();

            
            if (productIds != null && quantities != null)
            {
                for (int i = 0; i < productIds.Count; i++)
                {
                    var item = new OrderItem
                    {
                        OrderId = order.OrderId,
                        ProductId = productIds[i],
                        Quantity = quantities[i]
                    };

                    _context.OrderItems.Add(item);
                }
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        // Reload dropdowns if validation fails
        ViewBag.CustomerId = new SelectList(_context.Customers, "CustomerId", "Name", order.CustomerId);
        ViewBag.Products = _context.Products.ToList();

        return View(order);
    }
    //GET: Orders/Edit/5
            public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var order = await _context.Orders.FindAsync(id);
        if (order == null)
        {
            return NotFound();
        }
        ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", order.CustomerId);
        return View(order);
    }

    // POST: Orders/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("OrderId,OrderDate,CustomerId")] Order order)
    {
        if (id != order.OrderId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(order);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(order.OrderId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", order.CustomerId);
        return View(order);
    }

    // GET: Orders/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var order = await _context.Orders
            .Include(o => o.Customer)
            .FirstOrDefaultAsync(m => m.OrderId == id);
        if (order == null)
        {
            return NotFound();
        }

        return View(order);
    }

    // POST: Orders/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var order = await _context.Orders.FindAsync(id);
        if (order != null)
        {
            _context.Orders.Remove(order);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool OrderExists(int id)
    {
        return _context.Orders.Any(e => e.OrderId == id);
    }
    public IActionResult Details(int id)
    {
        var order = _context.Orders
            .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
            .Include(o => o.ShippingDetail)
            .FirstOrDefault(o => o.OrderId == id);

        if (order == null) return NotFound();

        var vm = new OrderDetailsViewModel
        {
            Order = order,
            OrderItems = order.OrderItems.ToList(),
            ShippingDetail = order.ShippingDetail
        };

        return View(vm);
    }

}