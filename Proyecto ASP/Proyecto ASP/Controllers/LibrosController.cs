using Proyecto_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_ASP.Controllers
{
    public class LibrosController : Controller
    {


        // GET: Libros

        public ActionResult Index()
        {
            try
            {
                // Recupera la base de datos y la ingresa en la vista (index) en formato de tabla
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

        // Busqueda

        public ActionResult Buscar(FormCollection item)
        {
            try
            {
                // Metodo de busqueda especifica atraves del isbn 
                string libro = item["id"];
                LibrosContext db = new LibrosContext();
                int id_isbn = Convert.ToInt32(libro);

                var datos = db.CAT_LIBROS.Where(x => x.isbn == id_isbn).Select(x => x).ToList();
                // una vez encontrado actualiza la vista (index) y el formato tabla
                return View("~/Views/Libros/Index.cshtml", datos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Agregar Libros

        public ActionResult Agregar()
        {
         // Metodo para mostrar la vista agregar
            return View();
        }


        // Metodo encargado de procesosar la respuesta de la vista de agregar y asignar a la base de datos el nuevo libro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Agregar(CAT_LIBROS Libro)
        {

            // Verificamo el modelo
            if (!ModelState.IsValid)
                return View();

            try
            {
                using (var db = new LibrosContext())
                {
                    // Añadimos los datos a la base de datos
                    db.CAT_LIBROS.Add(Libro);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                // En caso de que el modelo este incorrecto mostrara un fallo
                ModelState.AddModelError("", "Fallo al ingresar libro -" + ex.Message);
                return View();
            }
        }



        // Editar Libros

        public ActionResult Editar(int id)
        {
            // Metodo para mostrar la vista Editar atravez de la busqueda del isbn del libro 
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


        // Metodo encargado de procesar la respuesta de la vista de Editar y re-asignar a la base de datos el libro
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(CAT_LIBROS Libro)
        {
            try
            {
                using (var db = new LibrosContext())
                {
                    // Cambiamos los datos que se encuentran en  la base de datos
                    CAT_LIBROS Blibro = db.CAT_LIBROS.Find(Libro.isbn);
                    Blibro.isbn = Libro.isbn;
                    Blibro.nombre = Libro.nombre;
                    Blibro.autor = Libro.autor;
                    Blibro.editorial = Libro.editorial;
                    Blibro.edicion = Libro.edicion;
                    Blibro.escuela = Libro.escuela;
                    Blibro.unidades = Libro.unidades;
                    Blibro.tematica = Libro.tematica;
                    Blibro.asignatura = Libro.asignatura;
                    db.SaveChanges();
                    return RedirectToAction("Index");



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
                // muestra la vista detalles con los datos encontrados en la base de datos
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


        // Eliminar libros
        public ActionResult Eliminar(int id)
        {
            try
            {
                // El metodo busca atravez del isbn el libro y procede a removerlo de la base de datos
                using (var db = new LibrosContext())
                {

                    CAT_LIBROS Blibro = db.CAT_LIBROS.Find(id);
                    db.CAT_LIBROS.Remove(Blibro);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            catch (Exception)
            {

                throw;
            }
        }



        public ActionResult Librosdañados()
        {
            // Redirecionamiento a la base de datos de los libros dañados
            Response.Redirect("http://localhost:53651/LibrosDa%C3%B1ados/IndexDa%C3%B1ados");
            return View();
        }


        public ActionResult Back()
        {
            // Redirecionamiento al Menu
            Response.Redirect("http://localhost:53651/Home/Index/22");
            return View();
        }



     

        public ActionResult IndexDañados()
        {
            // Metodo para mostrar la base  de datos que contiene los libros dañados
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
        //Programación para agregar libros dañados mostrando la vista para asignar el daño
        public ActionResult AgregarDañados(int id)
        {
            using (var db = new LibrosContext())
            {

                CAT_LIBROS Blibro = db.CAT_LIBROS.Find(id);
                return View(Blibro);
            }
        }


        // Metodo que escucha la vista y asigna los datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AgregarDañados(CAT_LIBROS_DAÑADOS Libro)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                using (var db = new LibrosContext())
                {
                    db.CAT_LIBROS_DAÑADOS.Add(Libro);

                    db.SaveChanges();
                    return RedirectToAction("IndexDañados");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Fallo al reportar libro dañado - " + ex.Message);
                return View();
            }
        }


        // Metodo para obtener detalles del libro dañado en una vista exclusiva
        public ActionResult DetallesDañados(int id)
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


        // Eliminar Libros Dañados

        public ActionResult EliminarDañados(int id)
        {
            try
            {
                // Metodo para eliminar un libro que se encuentre dañado en la base de datos
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
    }
}