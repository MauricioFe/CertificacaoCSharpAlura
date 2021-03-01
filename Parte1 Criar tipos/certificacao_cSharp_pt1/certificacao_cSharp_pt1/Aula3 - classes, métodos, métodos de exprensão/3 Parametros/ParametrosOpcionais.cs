using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1.Aula3___classes__métodos__métodos_de_exprensão._3_Parametros
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas Skywalker");
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial.FazerPedido(2, "Comercial");
            clienteEspecial.FazerPedido(3);
        }
    }
    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome = "Anônimo")
        {
            this.nome = nome;
        }
        //Sempre colocar os opcionais por último
        public void FazerPedido(int produtoId, string endereco = "Residencial", int quantidade = 10)
        {
            Console.WriteLine($"cliente {this.nome}, produtoId: {produtoId}. endereço:{endereco}, quantidade: {quantidade}");
        }
    }
}
