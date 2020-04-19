using Proyecto_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_ASP.Controllers
{
    public class RetiroController : Controller
    {
        // Consultar libro para retirar

        public ActionResult Index()
        {
            try
            {
                using (LibrosContext db = new LibrosContext())
                {
                    List<CAT_LIBROS> lista = db.CAT_LIBROS.ToList();
                    return View(lista);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Retirar Libros

        public ActionResult Retirar(int id)
        {
            try
            {

                if (!ModelState.IsValid)
                    return View();
                using (var db = new LibrosContext())
                {

                    CAT_LIBROS Blibro = db.CAT_LIBROS.Find(id);

                    return View(Blibro);

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Retirar(CAT_LIBROS Libro)
        {
            try
            {
                using (var db = new LibrosContext())
                {

                    CAT_LIBROS Blibro = db.CAT_LIBROS.Find(Libro.isbn);
                    Blibro.isbn = Libro.isbn;
                    Blibro.nombre = Libro.nombre;
                    Blibro.unidades = Blibro.unidades - Libro.cantidad;
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}