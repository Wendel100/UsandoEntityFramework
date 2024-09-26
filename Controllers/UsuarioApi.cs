using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CriaApis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioContoller : ControllerBase
    {
        [HttpGet("ObterData")]
        public ActionResult ObterDataHora(){
            var obj = new{
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToLongTimeString()
        };
        return Ok(obj);
    }
       [HttpGet("Apresentar/{nome}")]
       public ActionResult Apresentar(string nome){
        var mensagem =  $"Olá {nome}, seja bem vindo a sua Api";
        return Ok(new{mensagem});
     }

    }
}