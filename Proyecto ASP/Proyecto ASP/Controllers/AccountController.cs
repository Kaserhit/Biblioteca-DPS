using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_ASP.Models;
using System.Data.SqlClient;

namespace Proyecto_ASP.Controllers
{
    public class AccountController : Controller
    {

        // establece la conexion con la base de datos
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        // GET: Account
        [HttpGet]

        public ActionResult Login()
        {

            // ingresa a la vista
            return View();

        }

        void connectionString() {

           // Inicia lo conexion a la base de datos
            con.ConnectionString = "data source=DESKTOP-0V51JUM\\MSSQLSERVER01; database=LATVIABANK; integrated security = SSPI";

        }


        [HttpPost]
        public ActionResult Verify(Account acc) {

            // Establece conexion con la tabla de usuarios para comprobar los datos
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from CAT_USERS where USERNAME='"+acc.Name+"' and PASSWORD='"+acc.Password+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                // Si todo corresponde envia al Menu
                con.Close();
                Response.Redirect("http://localhost:53651/Home/Index/22");
                return View("Create");
            }
            else
            {
                // Si no corresponde vuelve a enviar al login
                con.Close();
                Response.Redirect("http://localhost:53651/Account/Login");
               
                return View("Error");
               


            }

           
        }


        }
    }
  
