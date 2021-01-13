using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1._6_Estruturas_Definidas_pelo_Usuário
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double latitude1 = 13.78;
            double longitude1 = 29.51;
            double latitude2 = 40.23;
            double longitude2 = 17.4;
            Console.WriteLine($"latitude1: {latitude1}");
            Console.WriteLine($"longitude1: {longitude1}");
            Console.WriteLine($"latitude2: {latitude2}");
            Console.WriteLine($"longitude2: {longitude2}");

            PosicaoGPS posicao1 = new PosicaoGPS(13.78, 29.51);
            Console.WriteLine(posicao1);
        }
    }
    interface IGPS
    {
        bool EstaNoHemisferioNorte();
    }
    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longtude)
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
}

