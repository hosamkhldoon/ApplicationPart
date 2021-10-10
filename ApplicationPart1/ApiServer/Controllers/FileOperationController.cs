using FileWorxObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using DTO;
using AutoMapper;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileOperationController : ControllerBase
    {
        
        [HttpPost]
        public IActionResult POST([FromBody] FileTransmissionService file)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<FileTransmissionService, FileOperation>());
            var mapper = new Mapper(config);

            FileOperation FileTransmission = mapper.Map<FileOperation>(file);
            FileTransmission.Upload();
            return Accepted();
        }
    }

}
