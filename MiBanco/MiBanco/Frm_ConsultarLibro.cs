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
    public partial class Frm_ConsultarLibro : Form
    {
        string text;

        public Frm_ConsultarLibro()
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
            ds= DevCom.GetDataLibros();

            dataGridView1.DataSource = ds.Tables[0];


        }


        private void button1_Click(object sender, EventArgs e)
        {
            DevCom x = new DevCom();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            DataSet ds = new DataSet();
            ds = DevCom.GetDataLibros(text);

            dataGridView1.DataSource = ds.Tables[0];

        }




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = Convert.ToString(Busqueda);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
