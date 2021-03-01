﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            int idade = 42;
            int copiaIdade = idade;
            Console.WriteLine("int idade = 42;");
            Console.WriteLine("int copiaIdade = idade;");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 32;
            Console.WriteLine("int idade = 32;");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            var cliente1 = new Cliente("josé da Silva", 42);
            var cliente2 = cliente1;

            Console.WriteLine();
            Console.WriteLine(@"var cliente1 = new Cliente(""josé da Silva"", 42);");
            Console.WriteLine(@"var cliente2 = cliente1;");
            Console.WriteLine($"cliente1: {cliente1}");
            Console.WriteLine($"cliente2: {cliente2}");

            cliente1.Nome = "Maria de Souza";
            Console.WriteLine();
            Console.WriteLine(@"cliente1.Nome = ""Maria de Souza"";");
            Console.WriteLine($"cliente1: {cliente1}");
            Console.WriteLine($"cliente2: {cliente2}");
        }



    }
    class Cliente
    {
        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";

        }
    }
}
