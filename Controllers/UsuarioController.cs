using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {   
      [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterHora(){
         var obj = new { 

            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToLongTimeString()
          };  

          return Ok(obj);

        }

        [HttpGet("TESTE")]
        public IActionResult teste(){
          var obj = new {teste = "TESTE"};
          
          return Ok(obj);

        }

        [HttpGet("Apresentar/{nome}/{sobrenome}")]
        public IActionResult Apresentar(string nome, string sobrenome){
          var obj = new {Apresentar = $"{nome} {sobrenome} seja bem vindo!" } ;
          return Ok(obj);
        }
        
        
        
    }
}