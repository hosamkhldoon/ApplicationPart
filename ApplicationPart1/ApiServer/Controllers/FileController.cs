using FileWorxObjects;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DTO;
using AutoMapper;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
      
        private File file = new File();
        [HttpPut]
        public IActionResult GET([FromBody]FileQueryService filterNewsAndPhotos)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<FileQueryService, FileQuery>());
            var mapper = new Mapper(config);

            FileQuery FileFilter = mapper.Map<FileQuery>(filterNewsAndPhotos);
            List<BusinessObject> ListFilterNewsAndPhoto = FileFilter.Run();
            
            if (ListFilterNewsAndPhoto != null)
                return Ok(ListFilterNewsAndPhoto);
            
            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GET([FromRoute]int id)
        {
            file.IDBusiness = id;
           
            file.Read();
          
            if (file != null)
            {

                return Ok(file);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DELETE([FromRoute]int id)
        {
            file.IDBusiness = id;
            file.Read();
          
            if (file == null)
                return NotFound();
            file.Delete();
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult PUT([FromRoute]int id,[FromBody]File FileUpdate)
        {
           
            file.IDBusiness = id;
            file.Read();
            FileUpdate.IDBusiness = id;
           
            if (file == null)
                return NotFound();

            FileUpdate.Updata();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody]File FileCreate)
        {
            FileCreate.IDFile = -1;
            FileCreate.Updata();
            return Accepted();
        }
    }
}

