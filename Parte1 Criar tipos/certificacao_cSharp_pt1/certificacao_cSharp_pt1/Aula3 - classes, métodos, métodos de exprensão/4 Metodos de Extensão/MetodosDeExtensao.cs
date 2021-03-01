using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1
{
    class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            Impressora impressora = new Impressora("Esse é \r\no meu documento");
            impressora.ImprimirDocumento();
            ImprimirDocumentoHTML(impressora.Documento);
            impressora.ImprimirDocumentoHTML();
        }
        void ImprimirDocumentoHTML(string documento)
        {
            Console.WriteLine($"<html><body>{documento}</body></html>");
        }


    }
    class Impressora
    {
        public Impressora(string documento)
        {
            this.Documento = documento;
        }

        public string Documento { get; }

        internal void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }
       
    }
    static class ImpressoraExtensions
    {
        // a palavra this indica que eu estou extendendo a classe impressora com o método abaixo
        public static void ImprimirDocumentoHTML(this Impressora impressora)
        {
            Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }
    }
}
