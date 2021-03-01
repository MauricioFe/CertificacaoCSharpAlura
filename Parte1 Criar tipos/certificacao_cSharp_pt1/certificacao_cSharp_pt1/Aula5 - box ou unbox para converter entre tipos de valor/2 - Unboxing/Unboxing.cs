using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;      // tipo de valor
            object caixa = numero;

            try
            {
                int unboxed = (int)caixa;
                Console.WriteLine("Unboxing ok");
            }
            catch (InvalidCastException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
