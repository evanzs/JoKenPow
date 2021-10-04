using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Resultado
    {
        public Resultado(string jogador1, string jogador2, string venceu)
        {
            Jogador1 = $" jogador1 jogou {jogador1}";
            Jogador2 = $"jogador2 jogou {jogador2} ";
            Venceu = venceu;
        }

        public string Jogador1 { get; set; }

        public string Jogador2 { get; set; }

        public string Venceu { get; set; }
    }
}
