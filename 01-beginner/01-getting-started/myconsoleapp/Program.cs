using System;

namespace myconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu nome: ");
            var _nome = Console.ReadLine();
            Console.WriteLine("\r\nSeja bem vindo {0}.\r\n\r\nIremos somar os valores 1,5 com 2,1 com 1,4 utilizando alguns recursos do C#.\r\n", _nome);
            Console.WriteLine("Resultado da soma: {0}", Somar(1.5d, 2.1d, 1.4d));
            Console.Write("Pressione qualquer tecla para encerrar a aplicação.");
            Console.ReadKey();
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
