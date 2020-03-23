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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DevCom x = new DevCom();

            String Nombre = txtNombre.Text;
            String Pwd = txtPwd.Text;

            if (!( DevCom.claveValida(Nombre, Pwd)  )) {

                MessageBox.Show("Error, Datos incorrectos");
            }

            

            Frm_Principal frm = new Frm_Principal();

            frm.Show();

            this.Close();




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
