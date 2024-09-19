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
            int z = Int32.Parse(x);
            int f = Int32.Parse(y);
            int result = z + f;
            return result.ToString();
        }

        public string Subtrair(string x, string y)
        {
            int z = Int32.Parse(x);
            int f = Int32.Parse(y);
            int result = z - f;
            return result.ToString();
        }

        public string Mult(string x, string y)
        {
            int z = Int32.Parse(x);
            int f = Int32.Parse(y);
            int result = z * f;
            return result.ToString();
        }

        public string Div(string x, string y)
        {
            int z = Int32.Parse(x);
            int f = Int32.Parse(y);
            int result = z / f;
            return result.ToString();
        }
        public string Seno(string angulo)
        {
            int z = Int32.Parse(angulo);
            int resultado = Convert.ToInt32(Math.Sin(z));
            return resultado.ToString();
        }
        public string Cosseno(string angulo)
        {
            int z = Int32.Parse(angulo);
            int resultado = Convert.ToInt32(Math.Cos(z));
            return resultado.ToString();
        }
        public string Tangente(string angulo)
        {
            int z = Int32.Parse(angulo);
            int resultado = Convert.ToInt32(Math.Tan(z));
            return resultado.ToString();
        }
        public string Fatorial(string texto)
        {
            int num = Int32.Parse(texto);
            int resultado;
            int temp;

            //Recursividade para numero positivo
            if (num == 1)
            {
                resultado = 1;
                return resultado.ToString();
            }
            else if (num > 0)
            {
                temp = num - 1;
                resultado = num * Int32.Parse(Fatorial(temp.ToString()));
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
                resultado = num * Int32.Parse(Fatorial(temp.ToString()));
                return resultado.ToString();
            }
            else { return "ERRO INESPERADO"; };

        }

        public string Binario(string texto)
        {
            int num = Int32.Parse(texto);
            return Convert.ToString(num, 2);
        }
    }
}
