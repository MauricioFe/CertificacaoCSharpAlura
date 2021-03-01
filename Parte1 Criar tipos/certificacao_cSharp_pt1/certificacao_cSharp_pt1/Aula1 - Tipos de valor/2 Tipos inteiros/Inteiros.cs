using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1
{
    class Inteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5;

            char resposta = 'S'; //System.char

            byte nivelDeAzul = 0xFF; //255 em hexadecimal
            short passageirosVoo = 230;//System.Int16
            passageirosVoo = -6;

            int populacao = 1500; //System.Int32
            populacao = -2300;

            long populacaoDoBrasil = 207_660_929; //System.Int64 +/-207 milhões

            sbyte nivelDeBrilho = -127;

            ushort passageirosNavio = 2300;
            uint estoque = 2300000;
            ulong populacaoDoMundo = 7_000_000_000;

            Console.WriteLine($"Resposta: {resposta}");

            Console.WriteLine($"Nivel de Azul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");

            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");

        }
    }
}
