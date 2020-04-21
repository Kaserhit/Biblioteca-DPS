using Proyecto_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_ASP.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Solicitud


            // mostrar vista de los tickets emitidos
        public ActionResult Index()
        {
            using (LibrosContext db = new LibrosContext())
            {
                List<CAT_SOLICITUD> lista = db.CAT_SOLICITUD.ToList();
                return View(lista);
            }
        }

        // Busqueda de los tickets emitidos atraves de la base de datos y se actualiza la vista
        public ActionResult Buscar(FormCollection item)
        {
            try
            {
                string libro = item["id"];
                LibrosContext db = new LibrosContext();
                int id_cedula = Convert.ToInt32(libro);

                var datos = db.CAT_SOLICITUD.Where(x => x.cedula == id_cedula).Select(x => x).ToList();

                return View("~/Views/Solicitud/Index.cshtml", datos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Eliminar  el ticket emitido y volver a la base de datos el libro
        public ActionResult Agregar(CAT_SOLICITUD Libro)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                using (var db = new LibrosContext())
                {
                    db.CAT_SOLICITUD.Add(Libro);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                return View();
            }
        }
        // Eliminar  los tickets emitidos
        public ActionResult Eliminar(int id)
        {
            try
            {
                using (var db = new LibrosContext())
                {

                    CAT_SOLICITUD Blibro = db.CAT_SOLICITUD.Find(id);
                    db.CAT_SOLICITUD.Remove(Blibro);
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