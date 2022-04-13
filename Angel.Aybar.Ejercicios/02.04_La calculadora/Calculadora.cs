using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._04_La_calculadora
{
    public static class Calculadora
    {
        //dos metodos estaticos
        /// <summary>
        /// Calcula cualquier operacion matematica simple
        /// </summary>
        /// <param name="ope1">primer operando</param>
        /// <param name="ope2">segundo operando</param>
        /// <param name="op">operación</param>
        /// <returns>Retorna el resultado de la operación</returns>
        public static int Calcular(int ope1,int ope2,char op)
        {
            int retorno;
            retorno = 0;
            bool validacion;
            switch (op)
            {
                case '+':
                    retorno = ope1 + ope2;                   
                    break;
                case '-':
                    retorno = ope1 - ope2;
                    break;
                case '*':
                    retorno = ope1 * ope2;
                    break;
                case '/':
                    validacion=Validar(ope2);
                    if(validacion==true)
                    {
                        retorno = ope1 / ope2;
                    }
                    else
                    {
                        retorno = -1;
                    }
                    break;
            }
            return retorno;
        }
        /// <summary>
        /// Valida que la division no sea por 0
        /// </summary>
        /// <param name="ope2">Es el segundo operando que jamas debe ser 0</param>
        /// <returns></returns>
        private static bool Validar(int ope2)
        {
            bool retorno;
            retorno = false;

            if(ope2!=0)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
