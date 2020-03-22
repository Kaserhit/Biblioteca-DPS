using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBanco.clases
{
    class Libros
    {
        private int Isbn;
        private String Nombre;
        private String Autor;
        private String Editorial;
        private int Unidades;
        private int Edicion;
        private String Escuela;
        private String Tematica;
        private String Asignatura;

        public Libros(int isbn, string nombre, string autor, string editorial, int unidades, int edicion, string escuela, string tematica, string asignatura)
        {
            Isbn = isbn;
            Nombre = nombre;
            Autor = autor;
            Editorial = editorial;
            Unidades = unidades;
            Edicion = edicion;
            Escuela = escuela;
            Tematica = tematica;
            Asignatura = asignatura;
        }

        public int getIsbn()
        {
            return Isbn;
        }

        public String getNombre()
        {
            return Nombre;
        }

        public String getAutor()
        {
            return Autor;
        }

        public String getEditorial()
        {
            return Editorial;
        }

        public int getUnidades()
        {
            return Unidades;
        }

        public int getEdicion()
        {
            return Edicion;
        }

        public String getEscuela()
        {
            return Escuela;
        }

        public String getTematica()
        {
            return Tematica;
        }

        public String getAsignatura()
        {
            return Asignatura;
        }

    }



}
