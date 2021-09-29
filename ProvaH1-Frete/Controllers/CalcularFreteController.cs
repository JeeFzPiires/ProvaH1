using Microsoft.AspNetCore.Mvc;
using ProvaH1_Frete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaH1_Frete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcularFreteController : Controller
    {
        [HttpGet]
        public ActionResult Ola()
        {
            return Ok("Olá");
        }

        [HttpPost("CalcularFrete")]
        public ActionResult CalcularFrete(Frete frete)
        {

            if(frete.tipoPostagem == 1)
            {
                return Ok("Frete Escolhido foi o PAC e o valor será de: " + (frete.ComprimentoCm * frete.LarguraCm * frete.AlturaCm) / 6000);
            }
            if(frete.tipoPostagem == 2)
            {
                return Ok("Frete escolhido foi o Sedex e o valor será de: " + ((frete.ComprimentoCm * frete.LarguraCm * frete.AlturaCm) / 6000) * 10);

            }
            if (frete.tipoPostagem == 3)
            {
                return Ok("Frete escolhido foi o Sedex e o valor será de: " + ((frete.ComprimentoCm * frete.LarguraCm * frete.AlturaCm) / 6000) * 20);

            }
            if (frete.tipoPostagem == 4)
            {
                return Ok("Frete escolhido foi o Sedex e o valor será de:  " + ((frete.ComprimentoCm * frete.LarguraCm * frete.AlturaCm) / 6000) * 30);

            }
            return BadRequest("Tipo de postagem não disponivel");
        }
        
    }
}
