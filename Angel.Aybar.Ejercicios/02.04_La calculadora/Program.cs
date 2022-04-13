using System;

namespace _02._04_La_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02.04 Pagina Web";

            int operandoUno;
            int operandoDos;
            string cadena;
            bool esNumerico;
            char operacion;
            int resultado;

            do
            {
                Console.Write("Ingrese el primer operando:");
                cadena = Console.ReadLine();


                esNumerico = int.TryParse(cadena, out operandoUno);
                if (esNumerico == false)
                {
                    Console.WriteLine("ERROR,¡Debe ingresar un número!");
                }

            } while (!esNumerico );

            cadena = " ";
            esNumerico = false;

            do
            {
                Console.Write("Ingrese el segundo operando:");
                cadena = Console.ReadLine();

                esNumerico = int.TryParse(cadena, out operandoDos);
                if (esNumerico == false)
                {
                    Console.WriteLine("ERROR,¡Debe ingresar un número!");
                }

            } while (!esNumerico);

            do
            {
                Console.Write("Ingrese la operación (+,-,*,/): ");
                operacion = char.Parse(Console.ReadLine());

               if(operacion=='+' || operacion == '-' || operacion == '*'|| operacion == '/')
                {
                    break;
                }
               else
                {
                    Console.WriteLine("ERROR,¡La operación no es valida!");

                }

            } while (operacion != '+' || operacion != '-' || operacion != '*' || operacion != '/');

            resultado=Calculadora.Calcular(operandoUno, operandoDos, operacion);

            if(resultado==-1)
            {
                Console.WriteLine("ERROR,¡No se puede dividir por cero!");
            }
            else
            {
                Console.WriteLine(resultado);
            }

            Console.ReadKey();
        }
    }
}
