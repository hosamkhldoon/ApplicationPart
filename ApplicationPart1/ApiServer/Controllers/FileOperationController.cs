using FileWorxObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileOperationController : ControllerBase
    {
        
        [HttpPost]
        public IActionResult POST([FromBody] FileOperation file)
        {
            file.Upload();
            return Accepted();
        }
    }

}
