using iTextSharp.text;
using iTextSharp.text.pdf;
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
            // Metodo para mostrar la tabla de los libros disponibles a solicitar
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

        // Metodo para realizar la solicitud, rellenar el formulario y generar el pdf
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
                    Blibro.cedula = Libro.cedula;
                    Blibro.name = Libro.name;
                    Blibro.apellido1 = Libro.apellido1;
                    Blibro.apellido2 = Libro.apellido2;
                    Blibro.telefono = Libro.telefono;
                    Blibro.fecha_solic = DateTime.Now;
                    Blibro.fecha_ent = Libro.fecha_ent;
                    Blibro.isbn = Libro.isbn;
                    Blibro.nombre = Libro.nombre;

                    // Lógica para retirar libros que tengan más de una unidad

                    if (Libro.cantidad > 0)
                    {
                        if (Blibro.unidades > 1)
                        {
                            if (Blibro.unidades <= Libro.cantidad)
                            {
                                ModelState.AddModelError("", "No hay suficientes unidades de este libro");
                                return View();
                            }
                            else
                            {
                                Blibro.unidades = Blibro.unidades - Libro.cantidad;
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("", "No hay suficientes unidades de este libro");
                            return View();
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Digite un número mayor a 0");
                        return View();
                    }



                    db.SaveChanges();


                }

            }
            catch (Exception)
            {

                throw;
            }

            // Programacion correspondiente para crear un pdf
            Document pdfDoc = new Document(PageSize.LETTER, 0, 0, 0, 0);

            PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);

            pdfDoc.Open();




            //imagen

            string path = Server.MapPath("/images/ulacit.png");
            Image logo = Image.GetInstance(path);
            logo.SetAbsolutePosition(210f, 150f);
            logo.ScaleAbsolute(204f, 53f);
            pdfDoc.Add(logo);

            // texto

            pdfDoc.Add(new Paragraph("                                                                 ---------------Ticker Solicitar--------------"));
            pdfDoc.Add(new Paragraph("                                    "));
            pdfDoc.Add(new Paragraph("                                     "));
            pdfDoc.Add(new Paragraph("                                                                 ...............Datos del Solicitante..............."));
            pdfDoc.Add(new Paragraph("                                    "));
            pdfDoc.Add(new Paragraph("                                     "));
            pdfDoc.Add(new Paragraph("                                                          Nombre:                              " + (Libro.name)));
            pdfDoc.Add(new Paragraph("                                                          Apellidos:                           " + (Libro.apellido1 + " " + Libro.apellido2)));
            pdfDoc.Add(new Paragraph("                                                          Cedula:                              " + (Libro.cedula)));
            pdfDoc.Add(new Paragraph("                                                          Telefono:                            " + (Libro.telefono)));
            pdfDoc.Add(new Paragraph("                                    "));
            pdfDoc.Add(new Paragraph("                                     "));
            pdfDoc.Add(new Paragraph("                                                                  ...............Datos del Libro..............."));
            pdfDoc.Add(new Paragraph("                                    "));
            pdfDoc.Add(new Paragraph("                                     "));
            pdfDoc.Add(new Paragraph("                                                          Nombre de Libro:                          " + (Libro.nombre)));
            pdfDoc.Add(new Paragraph("                                                          ISBN del Libro:                             " + (Libro.isbn)));
            pdfDoc.Add(new Paragraph("                                                          Cantidad de Libros Solicitados:    " + (Libro.cantidad)));

            pdfDoc.Add(new Paragraph("                                    "));
            pdfDoc.Add(new Paragraph("                                     "));
            pdfDoc.Add(new Paragraph("                                                                  .................Datos del Prestamo................."));
            pdfDoc.Add(new Paragraph("                                    "));
            pdfDoc.Add(new Paragraph("                                     "));
            pdfDoc.Add(new Paragraph("                                                        Fecha de Entrega:                   " + (Libro.fecha_ent.ToString())));
            pdfDoc.Add(new Paragraph("                                                        Fecha de Solicitud:                  " + (Libro.fecha_solic.ToString())));
            pdfDoc.Add(new Paragraph("                                     "));
            pdfDoc.Add(new Paragraph("                                     "));
            pdfDoc.Add(new Paragraph("                                                                                  Biblioteca Ulacit         "));
            pdfDoc.Add(new Paragraph("                                                                            ___________________         "));

            pdfDoc.Close();

            Response.ContentType = "application/pdf";

            Response.AddHeader("content-disposition", "attatchment; filename=Reporte.pdf");
            System.Web.HttpContext.Current.Response.Write(pdfDoc);
            Response.Flush();
            Response.End();

            return RedirectToAction("~/Views/Libros/Index.cshtml");
        }


        public ActionResult Back()
        {
            // Redirecionamiento al Menu
            Response.Redirect("http://localhost:53651/Home/Index/22");
            return View();
        }

    }
}
      
