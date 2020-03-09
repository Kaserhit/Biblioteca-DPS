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
        private double saldo;



        public Cuenta(Cliente cliente, String numCuenta, double saldo)
        {
            this.cliente = cliente;
            this.numCuenta = numCuenta;
            this.saldo = saldo;

        }


        public Cliente getCliente()
        {
            return cliente;
        }

        public String getNumCuenta()
        {
            return numCuenta;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public void depositar(double monto)
        {
            saldo = saldo + monto;
                        
        }

        public void retirar(double monto)
        {
            saldo = saldo - monto;

        }


        public void CalcularInteres(double tasa)
        {
            saldo = saldo+(saldo * (tasa/100));

        }


        public void CalcularComision(double tasa)
        {
            saldo = saldo - (saldo * (tasa / 100));
        }


        public Boolean HaySaldo()
        {
            if (saldo > 0)
            { return true; }
            else
            { return false; }

        }

    }



}
