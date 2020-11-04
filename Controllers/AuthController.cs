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
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "this is get";
        }
        [HttpPost]
        public ActionResult<dynamic> AnyPost([FromBody] User user){

            return StatusCode(200 , new {
                msg = $"helloworld {user.name}"
            });
        }
        [HttpPost]
        [Route("customize/post")]
        public ActionResult<dynamic> CustomizePost([FromBody] User user){

            return StatusCode(200 , new {
                msg = $"customize {user.name}"
            });
        }
    }
    public partial class User {
        public string name { get ; set ;  }
        public string role { get ; set ; }

    }
}


