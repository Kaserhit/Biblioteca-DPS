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

        
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();

        }

        void connectionString() {

            con.ConnectionString = "data source=DESKTOP-0V51JUM\\MSSQLSERVER01; database=LATVIABANK; integrated security = SSPI";

        }


        [HttpPost]
        public ActionResult Verify(Account acc) {

            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from CAT_USERS where USERNAME='"+acc.Name+"' and PASSWORD='"+acc.Password+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                Response.Redirect("http://localhost:53651/Home/Index/22");
                return View("Create");
            }
            else
            {
                con.Close();
                Response.Redirect("http://localhost:53651/Account/Login");
               
                return View("Error");
               


            }

           
        }


        }
    }
  
