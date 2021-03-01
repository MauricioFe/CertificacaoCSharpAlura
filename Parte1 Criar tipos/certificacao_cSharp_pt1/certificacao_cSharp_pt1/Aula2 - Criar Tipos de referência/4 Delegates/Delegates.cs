using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1
{
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    delegate double MetodoMultiplicacao(double input);

    class Calculadora
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }
        static double Triplicar(double input)
        {
            return input * 3;
        }
        public static void Executar()
        {
            Console.WriteLine($"Duplicar (7.5): {Duplicar(7.5)}");
            Console.WriteLine($"Triplicar (7.5): {Triplicar(7.5)}");

            MetodoMultiplicacao metodoMultiplicacao = Duplicar;
            Console.WriteLine($"Delegate duplicar {metodoMultiplicacao(7.5)}");
            metodoMultiplicacao = Triplicar;
            Console.WriteLine($"Delegate triplicar {metodoMultiplicacao(7.5)}");
            //delegate com implementação anônima
            MetodoMultiplicacao metodoQuadrado = delegate (double input)
            {
                return input * input;
            };

            double quadrado = metodoQuadrado(5);
            Console.WriteLine($"quadrado: {quadrado}");

            //expressão lambda
            MetodoMultiplicacao metodoCubo = input => input * input * input;

            double cubo = metodoQuadrado(4.375);
            Console.WriteLine($"cubo {cubo}");
        }
    }
}
