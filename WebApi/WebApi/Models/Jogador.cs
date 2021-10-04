
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Jogador
    {
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [EnumDataType(typeof(TipoJogada))]
        public TipoJogada Joga { get; set; }
    }
}
