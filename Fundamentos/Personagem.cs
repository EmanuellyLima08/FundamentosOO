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
        public virtual void evoluir() { }
        public virtual int atacar() { }
        public virtual void defender() { }
        public virtual void batalha() { }


    }
}
