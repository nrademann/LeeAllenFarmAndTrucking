using LeeAllenFarmAndTrucking.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LeeAllenFarmAndTrucking.Controllers
{
    public class ClientController : Controller
    {
            LeeDbContext db;
            public ClientController(LeeDbContext db)
            {
                this.db = db;
            }
            public IActionResult AllClient()
            {
                return View(db.Clients);
            }
            public IActionResult AddClient()
            {
                return View();
            }
            [HttpPost]
            public IActionResult AddClient(Client client)
            {
                db.Add(client);
                db.SaveChanges();
                return RedirectToAction("AllClient");
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
            public IActionResult EditClient(Client client)
            {
                db.Update(client);
                db.SaveChanges();
                return RedirectToAction("AllClient");
            }

            [HttpPost]
            public IActionResult DeleteClient(Client client)
            {
                db.Remove(client);
                db.SaveChanges();
                return RedirectToAction("AllClient");
            }
            /*        public IActionResult Index()
                    {
                        return View();
                    }
             */
        }
    }

