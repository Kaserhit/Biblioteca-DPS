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
            if (comboBox1.SelectedItem.ToString() == "Usuarios")
            {
                DevCom x = new DevCom();

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                DataSet ds = new DataSet();
                ds = DevCom.GetData(textBox1.Text);

                dataGridView1.DataSource = ds.Tables[0];

            }

            if (comboBox1.SelectedItem.ToString() == "Libros")
            {
                DevCom x = new DevCom();

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                DataSet ds = new DataSet();
                ds = DevCom.GetDataLibros(textBox1.Text);

                dataGridView1.DataSource = ds.Tables[0];
            }


            if (comboBox1.SelectedItem.ToString() == "Mantenimiento")
            {
                DevCom x = new DevCom();

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                DataSet ds = new DataSet();
                ds = DevCom.GetMantenimiento(textBox1.Text);

                dataGridView1.DataSource = ds.Tables[0];
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
  
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (comboBox1.SelectedItem.ToString() == "Usuarios" )
            {
                clases.DevCom x = new clases.DevCom();

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                DataSet ds = new DataSet();
                ds = clases.DevCom.GetData();

                dataGridView1.DataSource = ds.Tables[0];

                button1.Show();
                button2.Show();
                button3.Show();
                button4.Hide();
                button5.Hide();
                button6.Hide();
            }

            if (comboBox1.SelectedItem.ToString() == "Libros")
            {
                DevCom x = new DevCom();

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                DataSet ds = new DataSet();
                ds = DevCom.GetDataLibros();

                dataGridView1.DataSource = ds.Tables[0];

                button1.Hide();
                button2.Hide();
                button3.Hide();
                button4.Show();
                button5.Show();
                button6.Hide();
            }

            if (comboBox1.SelectedItem.ToString() == "Mantenimiento")
            {
                DevCom x = new DevCom();

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                DataSet ds = new DataSet();
                ds = DevCom.GetMantenimiento();

                dataGridView1.DataSource = ds.Tables[0];

                button1.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Show();
                button6.Show();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
