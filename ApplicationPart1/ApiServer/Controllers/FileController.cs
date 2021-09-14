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
    public class FileController : ControllerBase
    {
      
        private File file = new File();
        [HttpPut]
        public IActionResult GET([FromBody]FileQuery filterNewsAndPhotos)
        {

           // string SerializeToJson = JsonConvert.SerializeObject(DataNewsPhoto.Run());
            List<BusinessObject> ListFilterNewsAndPhoto = filterNewsAndPhotos.Run();
            
            if (ListFilterNewsAndPhoto != null)
                return Ok(ListFilterNewsAndPhoto);
            
            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GET([FromRoute]int id)
        {
            file.IDBusiness = id;
           
            file.Read();
            string SerializeToJson = JsonConvert.SerializeObject(file);
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
            string SerializeToJson = JsonConvert.SerializeObject(file);
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
            string SerializeToJson = JsonConvert.SerializeObject(FileUpdate);
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

