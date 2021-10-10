using FileWorxObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using AutoMapper;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private User user = new User();
        [HttpPut]
        public IActionResult GET([FromBody]UserQueryService userfilter)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserQueryService,UserQuery>());
            var mapper = new Mapper(config);

            UserQuery UserFilter = mapper.Map<UserQuery>(userfilter);


            List<User> ListDataUser = UserFilter.Run();
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
           
            if (user != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<User,UserReadService>());
                var mapper = new Mapper(config);

               UserReadService useredit = mapper.Map<UserReadService>(user);
                return Ok(useredit);
            }
            return NotFound();
        }
        [HttpPost("GETUSER")]
        public IActionResult GETUSER([FromBody]UserCeackLogin LoginUser)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User,UserCeackLogin>());
            var mapper = new Mapper(config);

           
            user.PasswordUser = LoginUser.PasswordUser;
            user.NameLogin = LoginUser.NameLogin;

            if (user.CheckLoginUser())
            {
                UserCeackLogin userlogin = mapper.Map<UserCeackLogin>(user);
                return Ok(userlogin);
            }
            return NotFound();
        
        }
        [HttpDelete("{id}")]
        public IActionResult DELETE([FromRoute]int id)
        {
            user.IDBusiness = id;
            user.Read();
           
            if (user == null)
                return NotFound();
            user.Delete();
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult PUT([FromRoute]int id,[FromBody] UserUpdateService UserUpdate)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserUpdateService, User>());
            var mapper = new Mapper(config);

            User useredit = mapper.Map<User>(UserUpdate);
            useredit.IDBusiness = id;
            useredit.ClassIDFileOrUser = 3;
            user.IDBusiness = id;
            user.Read();
            
            if (user == null)
                return NotFound();

            useredit.Updata();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody]UserUpdateService UserCreate)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserUpdateService, User>());
            var mapper = new Mapper(config);

            User user = mapper.Map<User>(UserCreate);
            user.IDBusiness = -1;
            user.ClassIDFileOrUser = 3;
            user.Updata();
            return Accepted();
        }
    }
}
