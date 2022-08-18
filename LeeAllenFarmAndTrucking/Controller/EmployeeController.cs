using LeeAllenFarmAndTrucking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LeeAllenFarmAndTrucking.Controllers
{
    public class EmployeeController : Controller
    {
        LeeDbContext db;
        public EmployeeController(LeeDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> AllEmployee()
        {
            var employee = await db.Employees.ToListAsync();
            return View(db.Employees);
        }
        public IActionResult AddEmployee()
        {
            return View();
        }

        public IActionResult EditEmployee(int id)
        {
            Employee employee;
            employee = db.Employees.Find(id);
            return View(employee);
        }
        public IActionResult DeleteEmployee(int id)
        {
            Employee employee;
            employee = db.Employees.Find(id);
            return View(employee);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            db.Add(employee);
            await db.SaveChangesAsync();
            return RedirectToAction("AllEmployee");
        }
        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employee employee)
        {
            db.Update(employee);
            await db.SaveChangesAsync();
            return RedirectToAction("AllEmployee");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEmployee(Employee employee)
        {
            db.Remove(employee);
            await db.SaveChangesAsync();
            return RedirectToAction("AllEmployee");
        }
    }
}
/*
namespace LeeAllenFarmAndTrucking.Controller
{
    public class EmployeeController
    {
    }
}
*/
/*namespace LeeAllenFarmAndTrucking.Controller
{
    public class EmployeeController
    {
    }
}
*/
