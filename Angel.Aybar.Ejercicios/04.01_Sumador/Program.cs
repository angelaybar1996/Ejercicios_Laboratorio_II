using System;
using _04._01_Entidades;

namespace _04._01_Sumador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04.01 Pagina Web";


            Sumador objeto1 = new Sumador();
            Sumador objeto2 = new Sumador();
            int cantidadSumas;
            long sumas;
            bool igualdad;

            objeto1.Sumar(1, 5);
            objeto1.Sumar("Juan", "Perez");

            cantidadSumas = (int)objeto1;//casteo explicito 
            //objeto1 es la variable a castear(recibido por parametro)
            //int es el casteador (el retorno)

            Console.WriteLine("Cantidad de sumas: {0}",cantidadSumas);//2

            objeto2.Sumar(10, 45);
            objeto2.Sumar("Laura", "Chaval");

            sumas = objeto1 + objeto2;
            igualdad = objeto1 | objeto2;

            Console.WriteLine("Sumando las sumas: {0}", sumas);//4
            Console.WriteLine("Comparando las sumas: {0}", igualdad);//true

            Console.ReadKey();
        }
    }
}
