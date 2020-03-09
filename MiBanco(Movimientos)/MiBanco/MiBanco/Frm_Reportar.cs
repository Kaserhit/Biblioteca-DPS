using MiBanco.clases;
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
    public partial class Frm_Reportar : Form
    {
        public Frm_Reportar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Reportar_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {

            DevCom x = new DevCom();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            DataSet ds = new DataSet();
            ds= DevCom.GetDataMovtos();

            dataGridView1.DataSource = ds.Tables[0];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DevCom x = new DevCom();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            DataSet ds = new DataSet();
            ds = DevCom.GetDataUSERS();

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DevCom x = new DevCom();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            DataSet ds = new DataSet();

            if (textBox1.Text == "")
            {
                ds = DevCom.GetDataCuenta();
            }
            else
            {
                ds = DevCom.GetDataCuenta(textBox1.Text);
            }

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
