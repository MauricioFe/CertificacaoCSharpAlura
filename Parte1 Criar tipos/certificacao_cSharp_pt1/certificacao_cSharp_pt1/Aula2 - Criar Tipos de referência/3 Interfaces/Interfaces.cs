using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_cSharp_pt1
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligar();

            eletro1 = new Abajur();
            eletro1.Ligar();
        }
    }

    interface IEletrodomestico
    {
        void Ligar();
        void Desligar();
    }
    interface IIluminacao
    {
        double PontenciaDaLampada { get; set; }
    }
    class Televisao : IEletrodomestico
    {
        public void Desligar() { }
        public void Ligar() { }
    }
    class Abajur : IEletrodomestico, IIluminacao
    {
        public double PontenciaDaLampada { get; set; }
        public void Desligar() { }
        public void Ligar() { }
    }
    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PontenciaDaLampada { get; set; }
        public void Desligar() { }
        public void Ligar() { }
    }
    class Radio : IEletrodomestico
    {
        public void Desligar() { }
        public void Ligar() { }
    }
}
