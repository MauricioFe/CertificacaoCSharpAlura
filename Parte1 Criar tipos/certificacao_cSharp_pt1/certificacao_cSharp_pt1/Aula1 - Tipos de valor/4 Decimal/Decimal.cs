﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1._4_Decimal
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valorProduto1 = 10;
            double valorProduto2 = 20;
            double subtotal = 30;

            Console.WriteLine($"Descobrindo se 10 + 20 == 30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);

            valorProduto1 = 10.10;
            valorProduto2 = 20.20;
            subtotal = 30.30;

            Console.WriteLine($"Descobrindo se 10.10 + 20.20 == 30.30");
            Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);

            decimal materiaPrima = 10.10m;
            decimal maoDeObra = 20.20m;
            decimal custo = 30.30m;

            Console.WriteLine($"Descobrindo se (10.10 + 20.20) == 30.30");
            Console.WriteLine((materiaPrima + maoDeObra) == custo);
        }
    }
}