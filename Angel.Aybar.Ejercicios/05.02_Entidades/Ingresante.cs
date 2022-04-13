using System;
using System.Text;

namespace _05._02_Entidades
{
    public class Ingresante
    {
        private string[] cursos;        
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" Nombre: " + this.nombre +                      
                          "\n Direccion: " + this.direccion +
                          "\n Edad: " + this.edad +
                          "\n Genero: " + this.genero +
                          "\n Pais: " + this.pais );

            sb.AppendLine("Cursos:\n");
            for (int i = 0; i < cursos.Length; i++)
            {
                sb.AppendLine(this.cursos[i]+"\n");
            }
           
          
            return sb.ToString();
        }




    }
}
