using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1.Aula2___Criar_Tipos_de_referência._6_Dynamic
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
