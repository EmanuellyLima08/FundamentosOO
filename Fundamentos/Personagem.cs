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
        //public bool EstaVivo { get; set; } = true;

        //Métodos
        public virtual void apresentarSe() { }
        public virtual void evoluir()
        {
            this.Nivel += 2;
            this.Forca *= 2;
            this.Inteligencia *= 2;
            this.Agilidade *= 2;
            Console.WriteLine("O jogador " + this.Nome + " evoluiu para nível " + this.Nivel + ". Suas habilidades foram atualizadas para: \nAgilidade: " + this.Agilidade + "\nInteligência: " + this.Inteligencia + "\nForça: " + this.Forca);
        }
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
            bool vencedor = false;
            while (vencedor == false)
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
                Console.WriteLine("O dano na vida do atacante foi de " + danoDeVida);
                Console.WriteLine("O nível de vida do atacante agora é " + this.Vida);
                Console.WriteLine("==============================================");
                Console.WriteLine();

                if (this.Vida <= 0)
                {
                    Console.WriteLine("O " + p.Nome + " venceu a batalha, derrotando o inimigo!");
                    vencedor = true;
                    p.evoluir();
                }
                if (p.Vida <= 0)
                {
                    Console.WriteLine("O " + this.Nome + "venceu a abatalha, derrotando o inimigo!");
                    vencedor = true;
                    this.evoluir();
                }
            }
        }
    }
}


//    if (!EstaVivo || !p.EstaVivo)
//    {
//        Console.WriteLine("Batalha impossível. Um dos personagens está morto.");
//        return;
//    }

//    // Ataque do personagem atual
//    int valorAtaque = atacar();
//    int valorDefInimigo = p.defender();
//    int danoDeVida = valorAtaque - valorDefInimigo;

//    if (danoDeVida <= 0)
//    {
//        danoDeVida = 1;
//    }

//    p.Vida -= danoDeVida;
//    Console.WriteLine("O dano na vida do inimigo foi de " + danoDeVida);
//    Console.WriteLine("O nível de vida do inimigo agora é " + p.Vida);

//    // Verifica se o inimigo morreu
//    if (p.Vida <= 0)
//    {
//        p.EstaVivo = false;
//        Console.WriteLine($"{p.Nome} morreu.");

//        // O personagem atual (vencedor) evolui
//        evoluir();
//        return;
//    }

//    // Ataque do inimigo
//    int valorAtInimigo = p.atacar();
//    int valorDefesa = defender();
//    int danoDeVida2 = valorAtInimigo - valorDefesa;

//    if (danoDeVida2 <= 0)
//    {
//        danoDeVida2 = 1;
//    }

//    Vida -= danoDeVida2;
//    Console.WriteLine($"O dano na vida do atacante foi de " + danoDeVida2);
//    Console.WriteLine($"O nível de vida do atacante agora é " + this.Vida);

//    // Verifica se o personagem atual morreu
//    if (Vida <= 0)
//    {
//        EstaVivo = false;
//        Console.WriteLine($"{Nome} morreu.");

//        // O inimigo (vencedor) evolui
//        p.evoluir();
//    }
//}

//    int valorAtaque = this.atacar();
//    int valorDefInimigo = p.defender();
//    int danoDeVida = valorAtaque - valorDefInimigo;
//    if (danoDeVida <= 0)
//    {
//        danoDeVida = 1;
//    }
//    p.Vida = p.Vida - danoDeVida;
//    Console.WriteLine("O dano na vida do inimigo foi de " + danoDeVida);
//    Console.WriteLine("O nível de vida do inimigo agora é " + p.Vida);

//    int valorAtInimigo = p.atacar();
//    int valorDefesa = this.defender();
//    int danoDeVida2 = valorAtInimigo - valorDefesa;
//    if (danoDeVida2 <= 0)
//    {
//        danoDeVida2 = 1;
//    }
//    this.Vida = this.Vida - danoDeVida2;
//    Console.WriteLine("O dano na vida do atacante foi de " + danoDeVida2);
//    Console.WriteLine("O nível de vida do atacante agora é " + p.Vida);
//}

//{
//    // Define o incremento de atributos por nível
//    int incrementoForca = 10;
//    int incrementoAgilidade = 10;
//    int incrementoInteligencia = 10;
//    int incrementoVida = 30;

//    // Aumenta o nível
//    Nivel++;

//    // Melhora os atributos com base no novo nível
//    Forca += incrementoForca;
//    Agilidade += incrementoAgilidade;
//    Inteligencia += incrementoInteligencia;
//    Vida += incrementoVida;

//    // Exibe os resultados da evolução
//    Console.WriteLine(this.Nome + " evoluiu para o nível " + this.Nivel);
//    Console.WriteLine($"Novos atributos: Força: " + this.Forca + ", Agilidade: " + this.Agilidade + ", Inteligência: " + this.Inteligencia + ", Vida: " + this.Vida);
//}


