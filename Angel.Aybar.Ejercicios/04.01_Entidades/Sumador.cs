using System;
using System.Text;

namespace _04._01_Entidades
{
    public class Sumador
    {
        private int cantidadSumas;
        
        /// <summary>
        /// Constructor que inicializa con cero para eso reutiliza el constructor 
        /// y le carga valor cero.
        /// </summary>
        public Sumador():this(0)
        {
            
        }

       /// <summary>
       /// Costructor que inicializa cantidadSumas con un valor recibido por parametro
       /// </summary>
       /// <param name="cantidadSumas"></param>
       public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        

        public long Sumar(long a,long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            StringBuilder sb = new StringBuilder();

            this.cantidadSumas++;
            sb.Append(a);
            sb.Append(b);

            return sb.ToString();

        }

        public static bool operator |(Sumador s1,Sumador s2)
        {
            bool retorno;
            retorno = false;

            if(s1.cantidadSumas ==s2.cantidadSumas)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador + 
        /// El resultado va a ser la suma de las instancias de la clase Sumador
        /// </summary>
        /// <param name="s1">primer parametro de clase Sumador</param>
        /// <param name="s2">segundo parametro de clase Sumador</param>
        /// <returns>Retorna un valor de tipo Long al sumar las cantidadSumas de las instancias</returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            long retorno;

            retorno = s1.cantidadSumas + s2.cantidadSumas;

            return retorno;
        }
        /// <summary>
        /// Conversion explicita de tipo Sumador a tipo Int 
        /// Donde se retorna un valor entero que permacia privado hasta ahora
        /// </summary>
        /// <param name="s"></param>
        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }

    }
}
