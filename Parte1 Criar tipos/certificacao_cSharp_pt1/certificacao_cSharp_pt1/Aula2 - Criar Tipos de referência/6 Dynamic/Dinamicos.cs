﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;
            //objeto += 3;
           
            dynamic dinamico = 1;
            dinamico += 3;
            Console.WriteLine(dinamico);
        }
    }
}
