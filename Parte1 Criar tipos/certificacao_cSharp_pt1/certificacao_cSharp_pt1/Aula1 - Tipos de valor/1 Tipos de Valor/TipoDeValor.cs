﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade;
            idade = 30;
            Console.WriteLine(idade);
            int copiaIdade = idade;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 23;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");
        }
    }
}
