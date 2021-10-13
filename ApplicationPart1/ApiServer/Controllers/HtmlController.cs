using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileWorxObjects;
using DTO;
using AutoMapper;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HtmlController : ControllerBase
    {
        HtmlFile htmlfile = new HtmlFile();
        [HttpPost("GETHTML")]
        public IActionResult GETHTML([FromBody] string link)
        {
            htmlfile.LinkPage = link;

            htmlfile.GETNameFile();

            if (htmlfile != null)
            {
              
                return Ok(htmlfile);
            }



            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GET([FromRoute] int id)
        {
            htmlfile.IDBusiness = id;

            htmlfile.Read();

            if (htmlfile != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HtmlFile, HtmlFileReadService>());
                var mapper = new Mapper(config);
               HtmlFileReadService htmlfileread = mapper.Map<HtmlFileReadService>(htmlfile);
                return Ok(htmlfileread);
            }



            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DELETE([FromRoute] int id)
        {

            htmlfile.IDBusiness = id;
            htmlfile.Read();

            if (htmlfile == null)
                return NotFound();
            htmlfile.DeleteFile();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody] HtmlFile HtmlFileCreate)
        {
          
            HtmlFileCreate.CreateFile();
            return Ok(htmlfile.IDBusiness);
        }
    }
}
