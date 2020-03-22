using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBanco
{
    class Cuenta

    {

        private Cliente cliente;
        private String numCuenta;
   



        public Cuenta(Cliente cliente, String numCuenta)
        {
            this.cliente = cliente;
            this.numCuenta = numCuenta;
        

        }


        public Cliente getCliente()
        {
            return cliente;
        }

        public String getNumCuenta()
        {
            return numCuenta;
        }

       

    }



}
