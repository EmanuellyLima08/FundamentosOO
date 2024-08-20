using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Mago : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá, eu sou o " + this.Nome + " sou nível " + this.Nivel + ", tenho força " + this.Forca + ", minha agilidade é " + this.Agilidade + ", minha inteligência é" + this.Inteligencia + " e tenho " + this.Vida + " pontos de vida!");
        }

        public override int atacar()
        {
            int pontosAtaque = 0;
            pontosAtaque = (this.Inteligencia + this.Forca + this.Agilidade + this.Nivel + this.Vida) / 5;
            return pontosAtaque;
        }

        public override void batalha()
        {
            throw new NotImplementedException();
        }

        public override void defender()
        {

        }

        public override void evoluir()
        {
            throw new NotImplementedException();
        }
    }
}
