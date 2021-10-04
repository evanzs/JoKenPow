using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public class Empate : IJogadas
    {
        public IJogadas Proxima { get; set; }
        public Resultado CalculaJogada(Jogo jogo)
        {
            if (jogo.Jogador1.Joga.Equals(jogo.Jogador2.Joga))
                return new Resultado(jogo.Jogador1.Joga.ToString(), jogo.Jogador2.Joga.ToString(), "Os jogadores empataram!");

            return Proxima.CalculaJogada(jogo);
        }

        
    }
}
