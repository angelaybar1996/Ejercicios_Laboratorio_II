using System;
using System.Text;

namespace _03._03_Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random = new Random();

        public int NotaPrimerParcial 
        {
            set
            {
                 notaPrimerParcial = value;
            }
        }
        public int NotaSegundoParcial 
        {
            set
            {
                notaSegundoParcial = value;
            }
        }

        static Estudiante()
        {
            random.Next();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        private float CalcularPromedio(int notaPrimerParcial,int notaSegundoParcial)
        {
            float retorno;
            int suma;
            retorno = 0;

            if(notaPrimerParcial>0 || notaPrimerParcial<=10
                && notaSegundoParcial>0 || notaSegundoParcial<=10)
            {
                suma = notaPrimerParcial + notaSegundoParcial;
                retorno = (float)(suma / 2);
            }


            return retorno;

        }

        public double CalcularNotaFinal(int notaPrimerParcial, int notaSegundoParcial)
        {
            double retorno;
            float promedio;
            retorno = 0;

            promedio = this.CalcularPromedio(notaPrimerParcial, notaSegundoParcial);

            if (promedio>=4)
            {              
                retorno = (double)random.Next(6,10);
            }
            else
            {
                retorno = -1;
            }
            return retorno;
        }
        public string Mostrar(double notaFinal)
        {
            StringBuilder sb = new StringBuilder();



            sb.AppendLine("Nombre: " + this.nombre +
                          " Apellido: " + this.apellido +
                          " Legajo: " + this.legajo+
                          " Nota 1er parcial: " +this.notaPrimerParcial+
                          " Nota 2do parcial: " +this.notaSegundoParcial+
                          " Promedio: "+CalcularPromedio(notaPrimerParcial,notaSegundoParcial));
            if(notaFinal==-1)
            {
                sb.AppendLine("Alumno desaprobado");
            }
            else
            {
                sb.AppendLine("Nota final: " + notaFinal);
            }

            
            return sb.ToString();
        }


    }
}
