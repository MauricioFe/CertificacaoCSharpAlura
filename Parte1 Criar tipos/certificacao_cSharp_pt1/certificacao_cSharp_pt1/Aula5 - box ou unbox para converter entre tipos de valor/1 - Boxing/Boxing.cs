﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;

            //nome disso se chama boxing que é quando adicionamos um tipo de valor a um tipo de referência
            object caixa = numero;

            Console.WriteLine(string.Concat("Resposta", numero, true));
        }
    }
}
