using System;
using System.Data;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MiBanco.clases
{
    class DevCom
    {




        public static DataSet GetData()
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CAT_USERS", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public  DataSet GetCuenta(String XData)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CAT_CUENTAS WHERE ID='" + XData +  "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet GetDataMovtos()
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

           
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CAT_CUENTAS", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public static DataSet GetDataLibros()
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();


            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CAT_LIBROS", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet GetDataLibros(String text)
        {

            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CAT_LIBROS " + "where nombre = '" + text + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public static String ConsultarClave(String Usr, String Pwd)
        {
            String abc = "";
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(USERNAME) as DATA FROM CAT_USERS WHERE USERNAME='"
                + Usr + "' AND PASSWORD='" + Pwd + "'", conx);

            DataSet ds = new DataSet();

            da.Fill(ds);
            abc = ds.Tables[0].Rows[0]["DATA"].ToString();
            return abc;
        }


        public static Boolean claveValida(String Usr, String Pwd)
        {
            String Resultado = "";
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(USERNAME) as DATA FROM CAT_USERS WHERE USERNAME='"
                + Usr + "' AND PASSWORD='" + Pwd + "'", conx);

            DataSet ds = new DataSet();

            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            ds.Dispose();

            if (Resultado == "1") return true;
            else return false;

            
        }

        public static DataSet consultaGeneral( String Sql)
        {
            String Resultado = "";
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

            SqlDataAdapter da = new SqlDataAdapter(Sql, conx);

            DataSet ds = new DataSet();

            da.Fill(ds);
            Resultado = ds.Tables[0].Rows[0]["DATA"].ToString();
            //ds.Dispose();

            //if (Resultado == "1") return true;
            //else return false;

            return ds;


        }


        public  void IngresaCuenta(String ID, String Nombre_Cliente, String SALDO_ACTUAL)
        {
            /*string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;*/

            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();


            using (SqlCommand cmd = new SqlCommand("INSERT INTO CAT_CUENTAS (ID, NOMBRE_CLIENTE, SALDO_ACTUAL) " +
                " VALUES (@ID, @NOMBRE_CLIENTE, @SALDO_ACTUAL)"))

            {
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@NOMBRE_CLIENTE", Nombre_Cliente);
                cmd.Parameters.AddWithValue("@SALDO_ACTUAL", SALDO_ACTUAL);

                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }




        }





        public void ActualizarCuenta(String ID, String Nombre_Cliente, String SALDO_ACTUAL) {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("UPDATE CAT_CUENTAS SET ID=@ID,  " +
                " NOMBRE_CLIENTE=@NOMBRE_CLIENTE, SALDO_ACTUAL=@SALDO_ACTUAL " +
                " WHERE ID=@ID"))

            {
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@NOMBRE_CLIENTE", Nombre_Cliente);
                cmd.Parameters.AddWithValue("@SALDO_ACTUAL", SALDO_ACTUAL);

                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }



        }

        public static void IngresaLibro(string nombre, string autor, string editorial, int edicion, string escuela, string tematica, string asignatura)
        {
            /*string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;*/

            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();


            using (SqlCommand cmd = new SqlCommand("INSERT INTO CAT_LIBROS (nombre, autor, editorial, edicion, escuela, tematica, asignatura) " +
                " VALUES (@nombre, @autor, @editorial, @edicion,  @escuela , @tematica , @asignatura )"))

            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@autor", autor);
                cmd.Parameters.AddWithValue("@editorial", editorial);
                cmd.Parameters.AddWithValue("@edicion", edicion);
                cmd.Parameters.AddWithValue("@escuela", escuela);
                cmd.Parameters.AddWithValue("@tematica", tematica);
                cmd.Parameters.AddWithValue("@asignatura", asignatura);
 

                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }




        }



        public static SqlConnection RetornaAcceso() {

            SqlConnection conecta = new SqlConnection();
            conecta.ConnectionString = "Data Source = DESKTOP-5OB2EK1; Initial Catalog = 'LATVIABANK'; Trusted_Connection = True; ";

            return conecta;
        }



        public void IngresaMovimiento(String ID_CUENTA, String ID_MOVTO, Double MONTO_MOVTO)
        {
            /*string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;*/
            
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();


            using (SqlCommand cmd = new SqlCommand("INSERT INTO TRA_CUENTAS (ID_CUENTA, ID_MOVTO, MONTO_MOVTO) " +
                " VALUES (@ID_CUENTA, @ID_MOVTO, @MONTO_MOVTO)"))

            {
                cmd.Parameters.AddWithValue("@ID_CUENTA", ID_CUENTA);
                cmd.Parameters.AddWithValue("@ID_MOVTO", ID_MOVTO);
                cmd.Parameters.AddWithValue("@MONTO_MOVTO", MONTO_MOVTO);

                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }

        }







    }
}
