using System;
using _04._03_Entidades;

namespace _04._03_Conversor_binario_recargado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando mediante los casteos explicitos
            NumeroDecimal nDecimal = (NumeroDecimal)9;
            NumeroBinario nBinario = (NumeroBinario)"1001";

            Console.WriteLine($"El número binario es {nBinario.Numero} y sumado con el numero decimal el resultado es { nBinario + nDecimal}");
            Console.WriteLine($"El número decimal es {nDecimal.Numero} y sumado con el numero binario el resultado es { nDecimal + nBinario}");

            if(nBinario==nDecimal)
            {
                Console.WriteLine("Ambos numeros son iguales");
            }
            else
            {
                Console.WriteLine("Los numeros son distintos");
            }

            Console.WriteLine($"El numero 12 en binario es {nDecimal.ConvertirDecimalABinario(12)}");


            Console.ReadKey();



        }
    }
}
