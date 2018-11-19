using ParcialFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ParcialFinal.Controllers
{
    public class LibrosController : Controller
    {

        private ApplicationDbContext _context;
        public LibrosController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Clientes
        public ViewResult Lista()
        {
            // var clientes =GetClientes();
            var lib = _context.LIBROS.ToList();
            return View(lib);
        }

        public ActionResult Details(int id)
        {
            // var cliente= GetClientes().SingleOrDefault(c=> c.ID==id);
            var lib = _context.LIBROS.SingleOrDefault(c => c.ID_Libro == id);
            if (lib == null)

                return HttpNotFound();
            return View(lib);
        }

        //Crear vista para crear clientes
        public ActionResult Nueva()
        {
            var lib = _context.LIBROS.ToList();
            var viewModel = new LIBROS
            {

            };

            return View(viewModel);
        }


        //Metodo para encadenar la base de datos
        [HttpPost]

        public ActionResult Create(LIBROS lib)
        {
            if (lib.ID_Libro == 0)
                _context.LIBROS.Add(lib);

            else
            {
                var libEnBd = _context.LIBROS.Single(c => c.ID_Libro ==lib.ID_Libro);
                libEnBd.Titulo_Libro = lib.Titulo_Libro;
                libEnBd.Autor_Libro = lib.Autor_Libro;
                libEnBd.ISBN_Libro = lib.ISBN_Libro;

            }

            // _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return RedirectToAction("Lista", "LIBROS");
        }
        public ActionResult Edit(int? ID)
        {
            if (ID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIBROS lib = _context.LIBROS.Find(ID);
            if (lib == null)
            {
                return HttpNotFound();
            }
            return View(lib);
        }
        [HttpPost]
        public ActionResult Edit(LIBROS lib)
        {
            _context.Entry(lib).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Lista", "LIBROS");
        }
        public ActionResult Eliminar(int id)
        {
            var lib = _context.LIBROS.SingleOrDefault(c => c.ID_Libro == id);
            if (lib == null)
                return HttpNotFound();

            else
            {
                _context.LIBROS.Remove(lib);

                _context.SaveChanges();


            }
            return RedirectToAction("Lista", "LIBROS");
        }
        private IEnumerable<LIBROS> Getlib()
        {
            return new List<LIBROS>
            {
             
            };
        }
    }
}

