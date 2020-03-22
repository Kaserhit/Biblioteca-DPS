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
    public partial class Frm_IngresarLibro : Form
    {
         String Nombre;
         String Autor;
         String Editorial;
         int Edicion;
         String Escuela;
         String Tematica;
         String Asignatura;



        public Frm_IngresarLibro()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Frm_IngresarLibro_Load(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {

          clases.Libros NL = new clases.Libros(Nombre,Autor,Editorial,Edicion,Escuela,Tematica,Asignatura);

          clases.DevCom x = new clases.DevCom();

          clases.DevCom.IngresaLibro(Nombre, Autor, Editorial, Edicion, Escuela, Tematica, Asignatura);

            MessageBox.Show("Libro ingresado al sistema con exito");

            this.Close();
   
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Santerior_TextChanged(object sender, EventArgs e)
        {
           
            Nombre = Convert.ToString(txt_nombre.Text);
        }

        private void txt_autor_TextChanged(object sender, EventArgs e)
        {
            
            Autor = Convert.ToString(txt_autor.Text);
        }

        private void txt_Editorial_TextChanged(object sender, EventArgs e)
        {
     
            Editorial = Convert.ToString(txt_Editorial.Text);
        }

        private void txt_Edicion_TextChanged(object sender, EventArgs e)
        {
           
            Edicion = Convert.ToInt32(txt_Edicion.Text);
        }

        private void txt_escuela_TextChanged(object sender, EventArgs e)
        {
        
            Escuela = Convert.ToString(txt_escuela.Text);
        }

        private void txt_tematica_TextChanged(object sender, EventArgs e)
        {
         
            Tematica = Convert.ToString(txt_tematica.Text);
        }

        private void txt_asignatura_TextChanged(object sender, EventArgs e)
        {
          
            Asignatura = Convert.ToString(txt_asignatura.Text);
        }
    }
}
