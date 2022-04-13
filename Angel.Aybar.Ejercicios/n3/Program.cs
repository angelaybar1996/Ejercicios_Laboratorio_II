using System;

namespace n3
{
    //Mostrar por pantalla todos los números
    //primos que haya hasta el número que ingrese el usuario por consola.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro3";
            int numero=0;
            bool esNumerico;
            string cadena;
            string continuar="no";


            do
            {
                //validacion para que el usuario ingrese un número(TENER EN CUENTA)
                do
                {
                    Console.WriteLine("Ingrese numero:");
                    cadena = Console.ReadLine();

                    if(cadena=="salir")
                    {
                        break;
  
                    }

                    esNumerico = int.TryParse(cadena, out numero);
                    if(esNumerico==false)
                    {
                        Console.WriteLine("ERROR,¡Debe ingresar un número!");
                    }
                
                } while (!esNumerico);


                //Logica para saber números primos
                Console.WriteLine("Lista de números primos:");
                for (int i = 0; i < numero; i++)
                {
                    if (i > 1)//el primer numero primo es 2
                    {
                        if (i % 2 != 0 || i == 2)
                        {
                            if (i % 3 != 0 || i == 3)
                            {
                                Console.WriteLine("{0}", i);
                            }
                        }
                    }

                }

                Console.WriteLine("¿Desea continuar?:");
                continuar = Console.ReadLine();

            } while (continuar == "si");
  
            Console.ReadKey();
        
        }
    }
}
