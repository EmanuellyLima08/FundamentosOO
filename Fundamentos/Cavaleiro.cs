using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Cavaleiro : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá, eu sou o cavaleiro " + this.Nome + "! Meu nível atual é " + this.Nivel + ", tenho força " + this.Forca + ", minha agilidade é " + this.Agilidade + ", minha inteligência é" + this.Inteligencia + " e tenho " + this.Vida + " pontos de vida!");
            Console.WriteLine("==============================================");
            Console.WriteLine();
        }
    }
}
