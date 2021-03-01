using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1.Aula3___classes__métodos__métodos_de_exprensão._3_Parametros
{
    class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {

            ImprimirDetalhesDoPedido("Maria de Fátima", 31, "Caneca Vermelha");
            //Argumentos nomeados
            ImprimirDetalhesDoPedido(numeroPedido: 31, nomeProduto: "Caneca vermelha", vendedor: "Maria de Fátima");
            //Argumentos nomeados e por ordem
            ImprimirDetalhesDoPedido("Maria de Fátima", 31, nomeProduto: "Caneca Vermelha");
            ImprimirDetalhesDoPedido(vendedor: "Maria de Fátima", 31, nomeProduto: "Caneca Vermelha");
            ImprimirDetalhesDoPedido("Maria de Fátima", numeroPedido: 31, "Caneca Vermelha");
        }

        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrWhiteSpace(vendedor))
            {
                throw new ArgumentException(message: "Nome do vendedor não pode ser nulo");
            }
            Console.WriteLine($"Vendedor: {vendedor}, Pedido No.: {numeroPedido}, Nome do produto.:{nomeProduto}");
        }
    }
}
