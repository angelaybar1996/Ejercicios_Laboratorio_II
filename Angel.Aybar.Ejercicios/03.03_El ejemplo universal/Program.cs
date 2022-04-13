using System;
using _03._03_Entidades;

namespace _03._03_El_ejemplo_universal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03.03 Pagina Web";

            Estudiante alumno1 = new Estudiante("Gonzales", "18785", "Juan");
            Estudiante alumno2 = new Estudiante("Pascual", "19665", "Julio");
            Estudiante alumno3 = new Estudiante("Einstein", "11079", "Maria");

            alumno2.NotaPrimerParcial = 5;
            alumno2.NotaSegundoParcial = 6;

            alumno3.NotaPrimerParcial = 4;
            alumno3.NotaSegundoParcial = 2;

            double notaFinal1= alumno1.CalcularNotaFinal(alumno1.NotaPrimerParcial = 10, alumno1.NotaSegundoParcial = 10);
            double notaFinal2= alumno2.CalcularNotaFinal(alumno2.NotaPrimerParcial = 5, alumno2.NotaSegundoParcial = 6);
            double notaFinal3= alumno3.CalcularNotaFinal(alumno3.NotaPrimerParcial = 4, alumno3.NotaSegundoParcial = 2);

            Console.WriteLine(alumno1.Mostrar(notaFinal1));
            Console.WriteLine(alumno2.Mostrar(notaFinal2));
            Console.WriteLine(alumno3.Mostrar(notaFinal3));
           

            

            Console.ReadKey();
        }
    }
}
