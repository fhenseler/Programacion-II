using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Entidades
{
    public class Numero
    {
        private double _numero;

        public Numero(double numero)
        {
            this._numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        public string SetNumero
        {
            set
            {
                this._numero = ValidarNumero(value);
            }
        }

        private static double ValidarNumero(string strNumero)
        {
            double value;
            if (!(double.TryParse(strNumero, out value)))
            {
                value = 0;
            }
            return value;
        }

        public static string DecimalBinario(double numero)
        {
            string binario = "";

            if(numero > 0)
            {
                while (numero > 0)
                {
                    binario = (numero % 2).ToString() + binario;
                    numero = numero / 2;
                }
            }
            else
            {
                return "VALOR INVALIDO";
            }
            return binario;
        }

        public static string DecimalBinario(string numero)
        {
            string binario = "";
            int aux;

            int.TryParse(numero, out aux);
            if(aux > 0)
            {
                while (aux > 0)
                {
                    binario = (aux % 2).ToString() + binario;
                    aux = aux / 2;
                }
            }
            else
            {
                return "VALOR INVALIDO";
            }

            return binario;
        }

        public static string BinarioDecimal(string binario)
        {
            int entero = 0;

            if(isbin(binario))
            {
                for (int i = 1; i <= binario.Length; i++)
                {
                    entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
                }
                return entero.ToString();
            }
            else
            {
                return "VALOR INVALIDO";
            }
        }

        public static double operator +(Numero num1, Numero num2)
        {
            double resultado;
            resultado = num1._numero + num2._numero;
            return resultado;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            double resultado;
            resultado = num1._numero - num2._numero;
            return resultado;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            double resultado;
            resultado = num1._numero * num2._numero;
            return resultado;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            double resultado;
            resultado = num1._numero / num2._numero;
            return resultado;
        }

        static bool isbin(string s)
        {
            foreach (var c in s)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                } 
            }
            return true;
        }
    }
}