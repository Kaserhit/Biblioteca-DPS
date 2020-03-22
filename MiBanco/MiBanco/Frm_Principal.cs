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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            /*this.Hide();*/

            frm_MClientes frm = new frm_MClientes();

            frm.Show();


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cuenta_Click(object sender, EventArgs e)
        {

            frm_MClientes frm = new frm_MClientes();

            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Frm_IngresarLibro frm = new Frm_IngresarLibro();

            frm.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Retirar frm = new Frm_Retirar();

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_ConsultarLibro frm = new Frm_ConsultarLibro();

            frm.Show();

        }
    }
}
