using System;

namespace myconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ola Cristiano Jose dos Reis!");
            Console.WriteLine("Resultado da soma: {0}", Somar(1.5d, 2.1d, 1.4d));
        }

        protected static double Somar(params double[] termos) {
            double _resultado = 0;
            foreach (double _termo in termos) {
                _resultado += _termo;
            }
            return _resultado;
        }
    }
}
