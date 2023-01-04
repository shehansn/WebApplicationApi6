using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationApi6.Models;
using WebApplicationApi6.Services;

namespace WebApplicationApi6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UserService _userService;

        public UsersController()
        {
            _userService = new UserService();
        }

        [HttpGet("{id?}")]
        public IActionResult Users(int? id)
        {
           
            var newUsers = _userService.getAllUsers();
            if (id is null) return Ok(newUsers);

            newUsers = newUsers.Where(x => x.Id == id).ToList();

            return Ok(newUsers);

            //var users= new string[] { "user1", "user2","user3" };
            //return Ok(users);
            //return Ok();

        }
        //can use this method also
        /*
        [HttpGet("{id}")]
        public IActionResult Users(int id)
        {
            var newUsers = getAllUsers().Where(x=>x.Id==id);
            return Ok(newUsers);

        }
        */


        /*
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
        */
    }
}
