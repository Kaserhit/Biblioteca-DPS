using Proyecto_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_ASP.Controllers
{
    public class LibrosDañadosController : Controller
    {
        // GET: LibrosDañados
        // Libros Dañados
        public ActionResult IndexDañados()
        {
            try
            {
                using (LibrosContext db = new LibrosContext())
                {
                    List<CAT_LIBROS_DAÑADOS> lista = db.CAT_LIBROS_DAÑADOS.ToList();
                    return View(lista);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Editar Libros

        public ActionResult Editar(int id)
        {
            try
            {

                if (!ModelState.IsValid)
                    return View();
                using (var db = new LibrosContext())
                {

                    CAT_LIBROS_DAÑADOS Blibro = db.CAT_LIBROS_DAÑADOS.Find(id);

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
        public ActionResult Editar(CAT_LIBROS_DAÑADOS Libro)
        {
            try
            {
                using (var db = new LibrosContext())
                {

                    CAT_LIBROS_DAÑADOS Blibro = db.CAT_LIBROS_DAÑADOS.Find(Libro.isbn);
                    Blibro.isbn = Libro.isbn;
                    Blibro.nombre = Libro.nombre;
                    Blibro.autor = Libro.autor;
                    Blibro.editorial = Libro.editorial;
                    Blibro.edicion = Libro.edicion;
                    Blibro.escuela = Libro.escuela;
                    Blibro.unidades = Libro.unidades;
                    Blibro.tematica = Libro.tematica;
                    Blibro.asignatura = Libro.asignatura;
                    Blibro.costo_reparacion = Libro.costo_reparacion;
                    Blibro.descripcion = Libro.descripcion;
                    db.SaveChanges();
                    return RedirectToAction("IndexDañados");



                }

            }
            catch (Exception)
            {

                throw;
            }

        }



        // Detalles Libros
        public ActionResult Detalles(int id)
        {
            try
            {

                using (var db = new LibrosContext())
                {

                    CAT_LIBROS_DAÑADOS Blibro = db.CAT_LIBROS_DAÑADOS.Find(id);

                    return View(Blibro);
                }
            }

            catch (Exception)
            {

                throw;
            }
        }


        // Eliminar libros
        public ActionResult Eliminar(int id)
        {
            try
            {

                using (var db = new LibrosContext())
                {

                    CAT_LIBROS_DAÑADOS Blibro = db.CAT_LIBROS_DAÑADOS.Find(id);
                    db.CAT_LIBROS_DAÑADOS.Remove(Blibro);
                    db.SaveChanges();
                    return RedirectToAction("IndexDañados");
                }
            }

            catch (Exception)
            {

                throw;
            }
        }


        public ActionResult Back()
        {
            Response.Redirect("http://localhost:53651/Libros");
            return View();
        }


        }

    }
