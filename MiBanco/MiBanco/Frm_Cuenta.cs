using MiBanco.clases;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBanco
{
    public partial class frm_MClientes : Form
    {
        public frm_MClientes()
        {
            InitializeComponent();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {



            DevCom DC = new DevCom();
            short data = 0;
            data = short.Parse (txt_saldo.Text);

            if (checkBox1.Checked == true)
            {
                DC.ActualizarCuenta(txt_cuenta.Text, txt_nombre.Text, "0");
            }
            else
            {
                DC.IngresaCuenta(txt_cuenta.Text, txt_nombre.Text, "0");
                
            }

            checkBox1.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clases.DevCom DC = new DevCom();
            DataSet ds = new DataSet();
            ds =   DC.GetCuenta("00001");

            txt_cuenta.Text = ds.Tables[0].Rows[0][0].ToString();

            txt_nombre.Text =ds.Tables[0].Rows[0][1].ToString() ;
            txt_saldo.Text = ds.Tables[0].Rows[0][2].ToString();

            ds.Dispose();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_saldo_TextChanged(object sender, EventArgs e)
        {


            if (   txt_saldo.Text.Length != 0  ) {
                checkBox1.Checked = true;
            }


        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
