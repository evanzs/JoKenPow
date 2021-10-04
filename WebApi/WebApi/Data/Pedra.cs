using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public class Pedra: IJogadas
    {
        public IJogadas Proxima { get; set; }
        public Resultado CalculaJogada(Jogo jogo)
        {
                if (jogo.Jogador1.Joga.Equals(TipoJogada.Pedra) && jogo.Jogador2.Joga.Equals(TipoJogada.Tesoura))
                {
                  return new Resultado(jogo.Jogador1.Joga.ToString(), jogo.Jogador2.Joga.ToString(), "Jogador 1 Venceu!");
                }
                else if (jogo.Jogador2.Joga.Equals(TipoJogada.Pedra) && jogo.Jogador1.Joga.Equals(TipoJogada.Tesoura))
                {
                   return new Resultado(jogo.Jogador1.Joga.ToString(), jogo.Jogador2.Joga.ToString(), "Jogador 2 Venceu!");
                }

            return Proxima.CalculaJogada(jogo);
        }
    }
}
