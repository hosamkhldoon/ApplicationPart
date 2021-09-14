using FileWorxObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private User user = new User();
        [HttpPut]
        public IActionResult GET([FromBody]UserQuery userfilter)
        {

          
        //string SerializeToJson = JsonConvert.SerializeObject(DataUser.Run());
            List<User> ListDataUser = userfilter.Run();
            if (ListDataUser != null)
            {

                return Ok(ListDataUser);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GET([FromRoute]int id)
        {
            user.IDBusiness = id;
         
            user.Read();
            string SerializeToJson = JsonConvert.SerializeObject(user);
            if (user != null)
            {

                return Ok(user);
            }
            return NotFound();
        }
        [HttpPost("GETUSER")]
        public IActionResult GETUSER([FromBody]User LoginUser)
        {
            user.PasswordUser = LoginUser.PasswordUser;
            user.NameLogin = LoginUser.NameLogin;
   
            if (user.CheckLoginUser())
                return Ok(user);
            return NotFound();
        
        }
        [HttpDelete("{id}")]
        public IActionResult DELETE([FromRoute]int id)
        {
            user.IDBusiness = id;
            user.Read();
            string SerializeToJson = JsonConvert.SerializeObject(user);
            if (user == null)
                return NotFound();
            user.Delete();
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult PUT([FromRoute]int id,[FromBody] User UserUpdate)
        {
            UserUpdate.IDBusiness = id;
            user.IDBusiness = id;
            user.Read();
            string SerializeToJson = JsonConvert.SerializeObject(UserUpdate);
            if (user == null)
                return NotFound();

            UserUpdate.Updata();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody]User UserCreate)
        {
           

            UserCreate.Updata();
            return Accepted();
        }
    }
}
