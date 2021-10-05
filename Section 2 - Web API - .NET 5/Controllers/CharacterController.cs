using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Section_1___Introduction___.NET_5.Models;

namespace Section_1___Introduction___.NET_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();
        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(knight);
        }
    }
}