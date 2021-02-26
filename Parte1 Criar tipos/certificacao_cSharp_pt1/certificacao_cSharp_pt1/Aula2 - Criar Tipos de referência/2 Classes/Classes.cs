using certificacao_cSharp_pt1._6_Estruturas_Definidas_pelo_Usuário;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1.Aula2___Criar_Tipos_de_referência._2_Classes
{
    class Classes : IAulaItem
    {
        public void Executar()
        {
            ClassePosicaoGPS posicao1 = new ClassePosicaoGPS() { Latitude = 13.78, Longitude = 39.51 };
            posicao1 = new ClassePosicaoGPS(13.78, 29.51);
            Console.WriteLine(posicao1);

            PosicaoGPSComLeitura posicao2 = new PosicaoGPSComLeitura(13.78, 29.51, DateTime.Now);
            Console.WriteLine(posicao2);
        }
    }
    class ClassePosicaoGPS : IGPS
    {
        public ClassePosicaoGPS() { }

        public double Latitude;
        public double Longitude;
        public ClassePosicaoGPS(double latitude, double longtude)
        {
            Latitude = latitude;
            Longitude = longtude;
        }

        public bool EstaNoHemisferioNorte()
        {
            return Latitude > 0;
        }
        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }
    class PosicaoGPSComLeitura : ClassePosicaoGPS
    {
        private readonly DateTime dataLeitura;

        public PosicaoGPSComLeitura(double latitude, double longtude, DateTime dataLeitura) : base(latitude, longtude)
        {
            this.dataLeitura = dataLeitura;
        }
        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}, Data Leitura: {dataLeitura}";
        }
    }
}
