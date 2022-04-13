using System;
using _03._01_Entidades;

namespace _03._01_Creo_que_necesito_un_prestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03.01 Pagina Web";

            Cuenta Cliente1 = new Cuenta("Angel", 150000);
            Cuenta Cliente2 = new Cuenta("Julio", 160000);
            Cuenta Cliente3 = new Cuenta("oscar", 140000);
            Cuenta Cliente4 = new Cuenta("Maria", 135000);
            Cuenta Cliente5 = new Cuenta("Juan", 180000);
            Cuenta Cliente6 = new Cuenta("Enrique",112000);
            Cuenta Cliente7 = new Cuenta("Julian", 900000);

            Console.WriteLine(Cliente1.Mostrar());
            Console.WriteLine(Cliente2.Mostrar());
            Console.WriteLine(Cliente3.Mostrar());
            Console.WriteLine(Cliente4.Mostrar());
            Console.WriteLine(Cliente5.Mostrar());
            Console.WriteLine(Cliente6.Mostrar());
            Console.WriteLine(Cliente7.Mostrar());
             
            if(Cliente1.Ingresar(8653)==-1)
            {
                Console.WriteLine("ERROR,¡No puede ingresar un monto negativo!");
            }
            else
            {
                Console.WriteLine(Cliente1.Mostrar());
            }


            if (Cliente2.Retirar(180000) == -1)
            {
                Console.WriteLine("ERROR,¡No puede ingresar un monto negativo!");
            }
            else
            {
                Console.WriteLine(Cliente2.Mostrar());
            }

            Console.ReadKey();

        }
    }
}
