using FileWorxObjects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DTO;
using AutoMapper;

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

            IBusinessQueryRepositroy DataNewsPhoto = new BusinessQueryReportsql();
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
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Photo,PhotoReadService>());
                var mapper = new Mapper(config);

                PhotoReadService photoread = mapper.Map<PhotoReadService>(photo);
                return Ok(photoread);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DELETE([FromRoute]int id)
        {
            photo.IDBusiness = id;
            photo.Read();
            
            if (photo == null)
                return NotFound();
            photo.Delete();
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult PUT([FromRoute]int id, [FromBody]PhotoUpdateService PhotoUpdate)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PhotoUpdateService, Photo>());
            var mapper = new Mapper(config);

            Photo photoedit = mapper.Map<Photo>(PhotoUpdate);
            photoedit.IDBusiness = id;
            photoedit.ClassIDFileOrUser = 2;
            photo.IDBusiness = id;
            photo.Read();
       
            if (photo == null)
                return NotFound();

            photoedit.Updata();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody]PhotoUpdateService PhotoCreate)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PhotoUpdateService, Photo>());
            var mapper = new Mapper(config);

            Photo photo = mapper.Map<Photo>(PhotoCreate);
            photo.IDBusiness = -1;
            photo.ClassIDFileOrUser = 2;
            photo.Updata();
            return Ok(photo.IDPhoto);
        }
    }
}

