using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03_Entidades
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string Numero
        {
            get
            {
                return this.numero;
            }
           
        }

        /// <summary>
        /// Que convierte un número entero del sistema binario al sistema decimal.
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>Retorna el número en formato decimal</returns>
        public  double ConvertirBinarioADecimal(string numeroString)
        {
            double retorno;
            string stringBinario;
            int resultado;

            stringBinario = numeroString;
            retorno = 0;
            resultado = 0;

            char[] array = stringBinario.ToCharArray();
            // Invertido  los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    resultado += (int)Math.Pow(2, i);
                }
                else if (array[i] != '0' && array[i] != '1')
                {
                    retorno = -1;
                    return retorno;
                }
            }

            retorno = resultado;
            return retorno;
        }
                
        //(TENERLO SUPER EN CUENTA,SUPER UTIL)
        /// <summary>
        /// Es el casteo explicito para poder crear un tipo NumeroBinario en la clase NumeroDecimal
        /// </summary>
        /// <param name="numero">parametro que recibe de tipo string</param>
        public static explicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        //(TENER SUPER EN CUENTA,SUPER UTIL)
        /// <summary>
        /// Casteo explicito donde la instancia de tipo NumeroBinario pasará a ser
        /// de tipo double para LUEGO ser casteada a tipo NumeroDecimal para luego
        /// finalmente retornar una instancia de tipo NumeroDecimal
        /// </summary>
        /// <param name="nb">parametro que recibe de tipo NumeroBinario</param>
        public static explicit operator NumeroDecimal(NumeroBinario nb)
        {
            //aca utilizo el casteo NumeroDecimal para crear un numero decimal sin llamar a su constructor que es privado
            //LA DEFINICION DEL CASTEO NumeroDecimal SE DEFINE EN LA CLASE NUMERODECIMAL
            return (NumeroDecimal)nb.ConvertirBinarioADecimal(nb.Numero);
        }

        public static string operator +(NumeroBinario nb,NumeroDecimal nd)
        {
            double suma;
            string resultado;
            
            suma = nd.Numero + ((NumeroDecimal)nb).Numero;
            resultado = nd.ConvertirDecimalABinario(suma);

            return resultado;
        }

        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            double resta;
            string resultado;

            resta = nd.Numero - ((NumeroDecimal)nb).Numero;
            resultado = nd.ConvertirDecimalABinario(resta);

            return resultado;
        }

        /// <summary>
        /// Verifica que los numeros binarios sean iguales
        /// </summary>
        /// <param name="nb"></param>
        /// <param name="nd"></param>
        /// <returns>Retorna true si son iguales, false en caso contrario</returns>
        public static bool operator ==(NumeroBinario nb,NumeroDecimal nd)
        {
            //no te olvides los parentisis dobles!! MUCHO OJO !!
            return nb.Numero == ((NumeroBinario)nd).Numero;
        }

        /// <summary>
        /// Es el opuesto a la igualdad que siempre lo tiene que acompañar
        /// </summary>
        /// <param name="nb"></param>
        /// <param name="nd"></param>
        /// <returns></returns>
        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
 
            return !(nb==nd);
        }




    }
}
