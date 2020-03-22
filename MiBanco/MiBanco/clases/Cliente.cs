using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBanco
{
    class Cliente
    {

        private String id;
        private String nombre;
        private String genero;

        public Cliente(String id, String nombre, String genero)
        {
            this.id = id;
            this.nombre = nombre;
            this.genero = genero;
        }

        public String getId()
        {
            return id;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getGenero()
        {
            return genero;
        }

        public String IndicarTratamiento()
        {

            if (genero == "M")
            { return "Dama"; }
            else
            { return "Caballero"; }

        }



    }
}
