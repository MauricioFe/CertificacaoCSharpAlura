
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1

{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_123_456_789;
            long inteiroLongo = inteiro;
            Console.WriteLine(inteiroLongo);

            //inteiro = inteiroLongo;

            Gato gato = new Gato();
            Animal animal = gato;

            Console.WriteLine(animal.GetType());

            IAnimal

        }
    }
}

