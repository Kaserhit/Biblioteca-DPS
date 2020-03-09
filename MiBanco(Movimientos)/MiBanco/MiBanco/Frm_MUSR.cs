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
    public partial class Frm_MUSR : Form
    {
        public Frm_MUSR()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DevCom DC = new DevCom();

            if (textBox1.Text == "") return;
            if (textBox2.Text == "") return;
            if (textBox3.Text == "") return;


            if ( DevCom.ExisteCodigo(textBox1.Text)  )
            { DC.ActualizarUSR(textBox1.Text, textBox2.Text, textBox3.Text); }
            else { DC.IngresaUSR(textBox1.Text, textBox2.Text, textBox3.Text);
            }

           






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_MUSR_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "") return;
            DevCom DC = new DevCom();

            if (  MessageBox.Show("Desea borrar el dato?","Atención",MessageBoxButtons.YesNo) == DialogResult.No )
            { return; }


            DC.BorrarUSR(textBox1.Text);
            MessageBox.Show("Borrado con éxito");


        }
    }
}
