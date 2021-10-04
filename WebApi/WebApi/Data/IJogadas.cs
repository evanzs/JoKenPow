using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public interface IJogadas
    {
       Resultado CalculaJogada(Jogo jogo);
        IJogadas Proxima{ get; set; }        
    }
}
