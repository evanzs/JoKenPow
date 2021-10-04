using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public enum TipoJogada
    {
        [Description("Pedra")]
        Pedra,

        [Description("Papel")]
        Papel,

        [Description("Tesoura")]
        Tesoura,
    }
}
