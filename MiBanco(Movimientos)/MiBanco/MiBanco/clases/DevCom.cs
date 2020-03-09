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

        public static DataSet GetDataCuenta()
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TRA_CUENTAS", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet GetDataCuenta(String codigo)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TRA_CUENTAS " +
                " where ID_CUENTA = '" + codigo + "'", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet GetDataUSERS()
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CAT_USERS", conx);
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

        public static Boolean ExisteCodigo(String ID_USER)
        {
            String Resultado = "";
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();

            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(ID_USER) as DATA FROM CAT_USERS WHERE ID_USER='"
                + ID_USER + "' ", conx);

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



        public void IngresaUSR(String ID_USER, String USERNAME, String PASSWORD)
        {
            /*string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;*/

            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();


            using (SqlCommand cmd = new SqlCommand("INSERT INTO CAT_USERS (ID_USER, USERNAME, PASSWORD) " +
                " VALUES (@ID_USER, @USERNAME, @PASSWORD)"))

            {
                cmd.Parameters.AddWithValue("@ID_USER", ID_USER);
                cmd.Parameters.AddWithValue("@USERNAME", USERNAME);
                cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD);

                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }

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

        public void ActualizarUSR(String ID_USER, String USERNAME, String PASSWORD)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("UPDATE CAT_USERS SET ID_USER=@ID_USER,  " +
                " USERNAME=@USERNAME, PASSWORD=@PASSWORD " +
                " WHERE ID_USER=@ID_USER"))
            {
                cmd.Parameters.AddWithValue("@ID_USER", ID_USER);
                cmd.Parameters.AddWithValue("@USERNAME", USERNAME);
                cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD);
                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }


        public void BorrarUSR(String ID_USER)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            using (SqlCommand cmd = new SqlCommand("DELETE CAT_USERS   " +
                " WHERE ID_USER=@ID_USER"))
            {
                cmd.Parameters.AddWithValue("@ID_USER", ID_USER);

                cmd.Connection = conx;
                conx.Open();
                cmd.ExecuteNonQuery();
                conx.Close();
            }
        }




        public static SqlConnection RetornaAcceso() {

            SqlConnection conecta = new SqlConnection();
            conecta.ConnectionString = "Data Source=403-04; Initial Catalog='LATVIABANK';Trusted_Connection = True;";

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
