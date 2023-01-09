using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba2.Datos;
using Prueba2.Models;

namespace Prueba2.Controllers
{
    public class SedeController : Controller
    {

        public readonly ApplicationDbContext _context;
        public SedeController(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        // GET: SedeController
        public IActionResult Index()
        {
            List<Sede> ListaSedes = _context.Sede.ToList();
            return View(ListaSedes);
        }

        //// GET: SedeController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: SedeController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SedeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sede sede)
        {
            if (ModelState.IsValid)
            {
                _context.Sede.Add(sede);
                _context.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        // GET: SedeController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return View();

            }

            var sede = _context.Sede.FirstOrDefault(c => c.SedeId == id);
            if (sede == null)
            {
                return NotFound();
            }
            return View(sede);
        }

        // POST: SedeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sede sede)
        {
            if (sede.SedeId == 0)
            {
                return View(sede);

            }
            else
            { 
              _context.Sede.Update(sede);
                _context.SaveChanges();
                return RedirectToAction("Index");
            
            }

            
        }


        // POST: SedeController/Delete/5
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var sede = _context.Sede.FirstOrDefault(c => c.SedeId == id);
            _context.Sede.Remove(sede);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
