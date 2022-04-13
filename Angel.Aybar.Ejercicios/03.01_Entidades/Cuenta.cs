using System;

namespace _03._01_Entidades
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        public string Titular
        { get
            {
                return titular;
            }
            set
            {
                titular = value;
            }
        }
        public int Cantidad 
        {
            get
            { 
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }

        public Cuenta(string titular, int cantidad)
        {
            this.Titular = titular;
            this.Cantidad = cantidad;
        }

        public string Mostrar()
        {
            string mensaje;
            mensaje = "El titular es " + this.Titular + " y tiene depositado $ " + this.Cantidad + " en su cuenta";
            return mensaje;
        }

        public int Ingresar(int cantidad)
        {
            int retorno;
            retorno = -1;

            if(cantidad>0)
            {
                this.Cantidad += cantidad;
                retorno = 0;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }

        public int Retirar(int monto)
        {
            int retorno;
            retorno = -1;

            if (cantidad > 0)
            {
                this.Cantidad -=monto;
                retorno = 0;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }


    }
}