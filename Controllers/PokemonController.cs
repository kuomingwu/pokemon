using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using jon.Models ;
namespace jon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            //取得所有pokemon
            
            return "this is get";
        }

        [HttpPost]
        [Route("pikachu")]
        public ActionResult<dynamic> Create([FromBody] CreateBody entity)
        {
            //新增一隻皮卡丘
            Pikachu pika = new Pikachu();
            pika.name = entity.name ;
            return StatusCode(200 , new {
                entity = pika
            });
        }
        public class CreateBody {
            public string name { get ; set ; }
        }
    }
}