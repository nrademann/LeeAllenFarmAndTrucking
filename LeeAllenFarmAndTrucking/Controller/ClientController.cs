using LeeAllenFarmAndTrucking.Models;
using LeeAllenFarmAndTrucking.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LeeAllenFarmAndTrucking.Controllers
{
    public class ClientController : Controller
    {
            LeeDbContext db;
            public ClientController(LeeDbContext db)
            {
                this.db = db;
            }
            public async Task<IActionResult> AllClient()
            { 
                var client = await db.Clients.ToListAsync();
                return View(db.Clients);
            }
            public IActionResult AddClient()
            {
                return View();
            }

            public IActionResult EditClient(int id)
            {
                Client client;
                client = db.Clients.Find(id);
                return View(client);
            }
            public IActionResult DeleteClient(int id)
            {
                Client client;
                client = db.Clients.Find(id);
                return View(client);
            }
            [HttpPost]
            public async Task<IActionResult> AddClient(Client client)
            {
                db.Add(client);
                await db.SaveChangesAsync();
                return RedirectToAction("AllClient");
            }
            [HttpPost]
            public async Task<IActionResult> EditClient(Client client)
            {
                db.Update(client);
                await db.SaveChangesAsync();
                return RedirectToAction("AllClient");
            }

            [HttpPost]
            public async Task<IActionResult> DeleteClient(Client client)
            {
                db.Remove(client);
                await db.SaveChangesAsync();
                return RedirectToAction("AllClient");
            }
            /*        public IActionResult Index()
                    {
                        return View();
                    }
             */
        }
    }

