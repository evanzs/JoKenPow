using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;

namespace WebApi.Models
{
    public class Calcula
    {
        public Resultado Calcular(Jogo jogo)
        {
            IJogadas jogadaUm = new Papel();
            IJogadas jogadaDois = new Tesoura();
            IJogadas jogadaTres = new Pedra();
            IJogadas jogadaQuatro = new Empate();


            jogadaUm.Proxima = jogadaDois;
            jogadaDois.Proxima = jogadaTres;
            jogadaTres.Proxima = jogadaQuatro;

            return jogadaUm.CalculaJogada(jogo);
        }
    }
}
