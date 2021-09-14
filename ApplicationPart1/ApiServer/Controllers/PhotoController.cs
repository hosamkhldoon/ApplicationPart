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
    public class PhotoController : ControllerBase
    {
        
        private Photo photo = new Photo();
        [HttpGet]
        public IActionResult GET()
        {

             BusinessQuery DataNewsPhoto = new BusinessQuery();
        string SerializeToJson = JsonConvert.SerializeObject(DataNewsPhoto.Run());
            if (SerializeToJson != null)
            {

                return Ok(SerializeToJson);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GET([FromRoute ]int id)
        {
            photo.IDBusiness = id;
         
            photo.Read();
            string SerializeToJson = JsonConvert.SerializeObject(photo);
            if (photo != null)
            {

                return Ok(photo);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DELETE([FromRoute]int id)
        {
            photo.IDBusiness = id;
            photo.Read();
            string SerializeToJson = JsonConvert.SerializeObject(photo);
            if (photo == null)
                return NotFound();
            photo.Delete();
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult PUT([FromRoute]int id, [FromBody]Photo PhotoUpdate)
        {
            PhotoUpdate.IDBusiness = id;
            photo.IDBusiness = id;
            photo.Read();
            string SerializeToJson = JsonConvert.SerializeObject(PhotoUpdate);
            if (photo == null)
                return NotFound();

            PhotoUpdate.Updata();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody]Photo PhotoCreate)
        {
           
            PhotoCreate.Updata();
            return Ok(PhotoCreate);
        }
    }
}

