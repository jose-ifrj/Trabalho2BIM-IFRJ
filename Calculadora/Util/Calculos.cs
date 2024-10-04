using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace Calculadora.Util
{
    public class Calculo
    {
        public string Soma(string x,string y)
        {
            long z = Int64.Parse(x);
            long f = Int64.Parse(y);
            long result = z + f;
            return result.ToString();
        }

        public string Subtrair(string x, string y)
        {
            long z = Int64.Parse(x);
            long f = Int64.Parse(y);
            long result = z - f;
            return result.ToString();
        }

        public string Mult(string x, string y)
        {
            long z = Int64.Parse(x);
            long f = Int64.Parse(y);
            long result = z * f;
            return result.ToString();
        }

        public string Div(string x, string y)
        {
            long z = Int64.Parse(x);
            long f = Int64.Parse(y);
            long result = z / f;
            return result.ToString();
        }
        public string Seno(string angulo)
        {
            double radiano = Int32.Parse(angulo) * Math.PI / 180;
            double resultado = Math.Sin(radiano);
            return resultado.ToString();
        }
        public string Cosseno(string angulo)
        {
            double radiano = Int32.Parse(angulo) * Math.PI / 180;
            double resultado = Math.Cos(radiano);
            return resultado.ToString();
        }
        public string Tangente(string angulo)
        {
            double radiano = Int32.Parse(angulo) * Math.PI / 180;
            double resultado = Math.Tan(radiano);
            return resultado.ToString();
        }
        public string Fatorial(string texto)
        {
            long num = Int64.Parse(texto);
            long resultado;
            long temp;

            //Recursividade para numero positivo
            if (num == 1)
            {
                resultado = 1;
                return resultado.ToString();
            }
            else if (num > 0)
            {
                temp = num - 1;
                resultado = num * Int64.Parse(Fatorial(temp.ToString()));
                return resultado.ToString();
            };

            //Recursividade para numero negativo
            if (num == -1)
            {
                resultado = -1;
                return resultado.ToString();
            }
            else if (num < 0)
            {
                temp = num + 1;
                resultado = num * Int64.Parse(Fatorial(temp.ToString()));
                return resultado.ToString();
            }
            else { return "ERRO INESPERADO"; };

        }

        public string Binario(string texto)
        {
            long num = Int64.Parse(texto);
            long resto;
            string resultado = string.Empty;
            while (num > 0)
            {
                resto = num % 2;
                num = num / 2;
                resultado = resto.ToString() + resultado;
            }
            return resultado;
        }

     /* BINARIO ANTIGO
      *
      *

        public string Binario(string texto)
        {
            int num = Int32.Parse(texto);
            return Convert.ToString(num, 2);
        }

      * 
      * 
      */
    }
}
