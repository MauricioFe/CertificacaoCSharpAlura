﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            bool possuiSaldo = true;
            Console.WriteLine($"possuiSaldo: {possuiSaldo}");

            int dias = DateTime.Now.Day;
            Console.WriteLine($"dias: {dias}");
            bool diasPar = (dias % 2 == 0);

            if (diasPar)
                Console.WriteLine("dias é um número par");
            else
                Console.WriteLine("dias é um número ímpar");
        }
    }
}
