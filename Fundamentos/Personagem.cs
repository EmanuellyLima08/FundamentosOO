using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Personagem
    {
        //Atributos - características dos personagens
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        //Métodos
        public virtual void apresentarSe() { }
        public virtual int atacar()
        {
            int pontosAtaque = 0;
            pontosAtaque = (this.Inteligencia + (this.Forca * 2) + this.Agilidade + this.Nivel + this.Vida) / 6;
            return pontosAtaque;
        }
        public virtual int defender()
        {
            int pontosDefesa = 0;
            pontosDefesa = (this.Inteligencia + this.Forca + (this.Agilidade * 2) + this.Nivel + this.Vida) / 6;
            return pontosDefesa;
        }
        public virtual void batalhar(Personagem p)
        {
            int valorAtaque = this.atacar();
            int valorDefInimigo = p.defender();
            int danoDeVida = valorAtaque - valorDefInimigo;
            if (danoDeVida <= 0)
            {
                danoDeVida = 1;
            }
            p.Vida = p.Vida - danoDeVida;
            Console.WriteLine("O dano na vida do inimigo foi de " + danoDeVida);
            Console.WriteLine("O nível de vida do inimigo agora é " + p.Vida);

            int valorAtInimigo = p.atacar();
            int valorDefesa = this.defender();
            int danoDeVida2 = valorAtInimigo - valorDefesa;
            if (danoDeVida2 <= 0)
            {
                danoDeVida2 = 1;
            }
            this.Vida = this.Vida - danoDeVida2;
            Console.WriteLine("O dano na vida do atacante foi de " + danoDeVida2);
            Console.WriteLine("O nível de vida do atacante agora é " + p.Vida);
        }

        public virtual void evoluir()
        {
            // Incrementa as habilidades conforme o personagem evolui
            Forca += 5;
            Agilidade += 5;
            Inteligencia += 5;
            Vida += 20;  // Aumenta a vida a cada evolução

            // A cada evolução, o nível também aumenta
            Nivel++;

            // Exibe os novos atributos do personagem
            Console.WriteLine($"{Nome} evoluiu para o nível {Nivel}!");
            Console.WriteLine($"Novos atributos de {Nome}: Força: {Forca}, Agilidade: {Agilidade}, Inteligência: {Inteligencia}, Vida: {Vida}");
        }




    }


}
}
