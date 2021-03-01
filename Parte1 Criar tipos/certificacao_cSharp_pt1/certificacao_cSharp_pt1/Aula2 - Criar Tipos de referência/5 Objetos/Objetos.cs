using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1.Aula2___Criar_Tipos_de_referência._5_Objetos
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuação: {pontuacao}");

            Console.WriteLine("OBJECT COM VALOR PRIMITIVO");
            object meuObjeto;
            meuObjeto = pontuacao;

            Console.WriteLine($"meuObjeto: {meuObjeto}");
            Console.WriteLine($"tipo do meuObjeto: {meuObjeto.GetType()}");

            Console.WriteLine();
            Console.WriteLine("OBJECT COM REFERÊNCIA DE OBJETO");

            meuObjeto = new Jogador();
            Jogador classRef;
            classRef = (Jogador)meuObjeto;

            Console.WriteLine($"ClassRef {classRef.Pontuacao}");
        }
    }
    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
