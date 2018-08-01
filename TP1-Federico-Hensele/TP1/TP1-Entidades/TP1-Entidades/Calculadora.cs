using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Entidades
{
    public class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            if(!(operador == "+" || operador == "-" || operador == "*" || operador == "/"))
            {
                operador = "+";
            }
            return operador;
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado; 

            switch(ValidarOperador(operador))
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = 0;
                    break;
            }
                    return resultado;      
        }
    }
}
