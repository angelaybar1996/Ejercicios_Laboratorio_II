using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03_Entidades
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero 
        {
            get
            {
                return this.numero;
            }                        
        }

        /// <summary>
        /// Convierte un número double del sistema decimal al sistema binario
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>Retorna el número en formato binario</returns>
        public  string ConvertirDecimalABinario(double numeroFlotante)
        {
            string retorno;
            retorno = "";

            if (numeroFlotante > 0)
            {
                String binario = "";

                while (numeroFlotante > 0)
                {
                    if (numeroFlotante % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }

                    numeroFlotante = (int)(numeroFlotante / 2);
                }

                retorno = binario;
            }
            else
            {
                if (numeroFlotante == 0)
                {
                    retorno = "0";
                }
            }
            return retorno;
        }
        
        //SUPER UTIL, TENERLO MUY ENCUENTA!
        /// <summary>
        /// Es el casteo explicito, la mejor manera de hacer una instancia de NumeroDecimal sin usar su constructor privado
        /// voy a poder usarlo en otras clases.
        /// </summary>
        /// <param name="numero">parametro que recibe de tipo double</param>
        public static explicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        //SUPER UTIL,TENERLO SUPER EN CUENTA!
        /// <summary>
        /// Casteo explicito donde la instancia de tipo NumeroDecimal pasa
        /// a ser de tipo string para luego ser casteado por el tipo NumeroBinario
        /// y finalmente retornar una instancia de NumeroBinario redefinida en la clase NumeroBinario.
        /// </summary>
        /// <param name="nd">parametro que recibe</param>
        public static explicit operator NumeroBinario(NumeroDecimal nd)
        {
            //La definicion del casteo NumeroBinario esta en su clase NumeroBinario
            //retorna la instancia de un tipo NumeroBinario
            return (NumeroBinario)nd.ConvertirDecimalABinario(nd.Numero);
        }

        public static double operator +( NumeroDecimal nd, NumeroBinario nb)
        {

            return nd.Numero + ((NumeroDecimal)nb).Numero;
        }

        public static double operator -( NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.Numero - ((NumeroDecimal)nb).Numero;
        }

        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.Numero == ((NumeroDecimal)nb).Numero;
        }

        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {

            return !(nd==nb);
        }
    }
}
