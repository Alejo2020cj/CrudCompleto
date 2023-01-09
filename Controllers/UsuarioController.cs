using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba2.Datos;
using Prueba2.Models;

namespace Prueba2.Controllers
{



    public class UsuarioController : Controller
    {
        public readonly ApplicationDbContext _context;
        public UsuarioController(ApplicationDbContext contexto)
        {
            _context = contexto;
        }
        // GET: UsuarioController
        public ActionResult Index()
        {
            List<Usuarios> ListaUsuarios = _context.Usuarios.ToList();
            return View(ListaUsuarios);
        }

        //// GET: UsuarioController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuarios usaurios)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usaurios);
                _context.SaveChanges();
               
            }
            return View();
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
