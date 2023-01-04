using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationApi6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Users()
        {
            var users= new string[] { "user1", "user2","user3" };
            return Ok(users);
        }

        [HttpPost]
        public IActionResult NewUser()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateUser()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteUser()
        {
            var wrong = true;
            if (wrong)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
