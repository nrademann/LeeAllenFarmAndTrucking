using LeeAllenFarmAndTrucking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LeeAllenFarmAndTrucking.Controllers
{
    public class OrderController : Controller
    {
        LeeDbContext db;
        public OrderController(LeeDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> AllOrder()
        {
            var order = await db.Orders
                .Include(c => c.client).ToListAsync();
            return View(order);
        }
        public IActionResult AddOrder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            db.Add(order);
            db.SaveChanges();
            return RedirectToAction("AllOrder");
        }
        public IActionResult EditOrder(int id)
        {
             Order order;
             order = db.Orders.Find(id);
             return View(order);
         }

         public IActionResult DeleteOrder(int id)
         {
             Order order;
             order = db.Orders.Find(id);
             return View(order);
         }
         [HttpPost]
         public IActionResult EditOrder(Order order)
         {
             db.Update(order);
             db.SaveChanges();
            return RedirectToAction("AllOrder");
         }
         [HttpPost]    
          public IActionResult DeleteOrder(Order order)
          {
              db.Remove(order);
              db.SaveChanges();
              return RedirectToAction("AllOrder");
          }
/*
        public async Task<IActionResult> AddOrder()
        {
            var ClientDisplay = await db.Clients.Select(x => new
            {
                Id = x.ClientId,
                Value = x.ClientName
            }).ToListAsync();
            OrderAddOrderViewModel vm = new OrderAddOrderViewModel();
            vm.ClientList = new SelectList(ClientDisplay, "Id", "Value");
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderAddOrderViewModel vm)
        {
            var client = await db.Clients.SingleOrDefaultAsync(i =>
                i.ClientId == vm.Client.ClientId);
            vm.Order.client = client;
            db.Add(vm.Order);
            await db.SaveChangesAsync();
            return RedirectToAction("AllOrder");
        }
//<<<<<<< HEAD
*/
               



/*        [HttpPost]
        public IActionResult EditOrder(int orderId)
        {
            Order order;
            order = db.Orders.Find(orderId);
            return View(orderId);
        }
        public async Task<IActionResult> EditOrder()
        {
            var ClientDisplay = await db.Clients.Select(x => new
            {
                Id = x.ClientId,
                Value = x.ClientName
            }).ToListAsync();
            OrderEditOrderViewModel vm = new OrderEditOrderViewModel();
            vm.ClientList = new SelectList(ClientDisplay, "Id", "Value");
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> EditOrder(OrderEditOrderViewModel vm)
        {
            var client = await db.Clients.SingleOrDefaultAsync(i =>
                i.ClientId == vm.Client.ClientId);
            vm.Order.client = client;
            db.Update(vm.Order);
            await db.SaveChangesAsync();
            return RedirectToAction("AllOrder");
        }
        public async Task<IActionResult> DeleteOrder()
        {
            var ClientDisplay = await db.Clients.Select(x => new
            {
                Id = x.ClientId,
                Value = x.ClientName
            }).ToListAsync();
            OrderDeleteOrderViewModel vm = new OrderDeleteOrderViewModel();
            vm.ClientList = new SelectList(ClientDisplay, "Id", "Value");
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteOrder(OrderDeleteOrderViewModel vm){
            var client = await db.Clients.SingleOrDefaultAsync(i =>
                i.ClientId == vm.Client.ClientId);
            vm.Order.client = client;
            db.Remove(vm.Order);
            await db.SaveChangesAsync();
            return RedirectToAction("AllOrder");
        }
 /*      [HttpPost]
        public IActionResult EditOrder(int id)
        {
            Order order;
            order = db.Orders.Find(id);
            return View(order);
=======
>>>>>>> 0c4f16d60bd744404f1e2d95ffd513b9ceeeda32
        }
        [HttpPost]
        public IActionResult DeleteOrder(int id)
        {
            Order order;
            order = db.Orders.Find(id);
            return View(order);
        }
<<<<<<< HEAD
*//*        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderEditOrderViewModel vm)
        {
            var client = await db.Clients.SingleOrDefaultAsync(i =>
            i.ClientId == vm.Client.ClientId);
            vm.Order.client = client;
            db.Update(vm.Order);
            await db.SaveChangesAsync();
            return RedirectToAction("AllOrder");
        }
*/

        /*       
                [HttpPost]
        =======
                [HttpPost]
        >>>>>>> 0c4f16d60bd744404f1e2d95ffd513b9ceeeda32
        */

        /*       public IActionResult Index()
               {
                   return View();
               }
        */
    }
}
