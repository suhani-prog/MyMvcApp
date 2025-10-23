using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Data;
using MyMvcApp.Models;
using System.Linq;

namespace MyMvcApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;
        public EmployeeController(AppDbContext context) => _context = context;

        // READ - list
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

        // CREATE - GET
        public IActionResult Create() => View();

        // CREATE - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(emp);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(emp);
        }

        // EDIT - GET
        public IActionResult Edit(int id)
        {
            var emp = _context.Employees.Find(id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        // EDIT - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Update(emp);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(emp);
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var emp = _context.Employees.Find(id);
            if (emp != null)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
