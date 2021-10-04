using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(Jogo jogada)
        {
            var calculadora = new Calcula();
            var teste = calculadora.Calcular(jogada);
            return Ok(teste);
        }
    }
}
