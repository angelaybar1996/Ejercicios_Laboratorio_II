using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03_Conversor_binario
{
    public static class Conversor
    {
        /// <summary>
        /// Convierte un número entero del sistema decimal al sistema binario
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>Retorna el número en formato binario</returns>
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            string retorno;
            retorno = "";
  
            if (numeroEntero > 0)
            {
                String binario = "";

                while (numeroEntero > 0)
                {
                    if (numeroEntero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }

                    numeroEntero = (int)(numeroEntero / 2);
                }

                retorno=binario;
            }
            else
            {
                if (numeroEntero == 0)
                {
                    retorno="0";
                }
                
            }
            
            return retorno;

        }

        /// <summary>
        /// Que convierte un número entero del sistema binario al sistema decimal.
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>Retorna el número en formato decimal</returns>
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int retorno;           
            string stringBinario;
            int resultado;

            stringBinario =numeroEntero.ToString();
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
                else if(array[i]!='0' && array[i] != '1')
                {
                    retorno = -1;
                    return retorno;
                }
            }

            retorno=resultado;
            return retorno;
        }
    }

    #region Manera facil decimal a binario con atajos c#

    //Nro 1
    //
    //static void method1()
    //{
    //    int decimalNumber = 15;
    //    int resto;
    //    string binary = string.Empty;

    //    while (decimalNumber > 0)
    //    {
    //        resto = decimalNumber % 2;
    //        decimalNumber /= 2;
    //        binary = resto.ToString() + binary;
    //    }
    //    Console.WriteLine("Binary:  {0}", binary);
    //}

    //Nro 2
    //Usando el toString(value,2) en base dos
    //static void method2()
    //{
    //    int value = 15;
    //    string binary = Convert.ToString(value, 2);
    //    Console.WriteLine("Binary:  {0}", binary);
    //}
    #endregion
}
