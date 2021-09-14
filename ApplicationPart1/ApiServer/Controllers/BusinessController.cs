using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileWorxObjects;
using Newtonsoft.Json;
using System.Net.Http;

namespace ApiServer.Controllers
{

    [Route("api/Business")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
       
        private BusinessObject business = new BusinessObject();
         [HttpGet]
        public IActionResult GET()
        {
           BusinessQuery DataNewsPhoto = new BusinessQuery();

            List<BusinessObject> ListDataNewsAndPhotos = DataNewsPhoto.Run();
           if (ListDataNewsAndPhotos != null)
            {
            
                return Ok(ListDataNewsAndPhotos);
            }
           return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GET([FromRoute] int id)
        {
            business.IDBusiness = id;
            business.Read();
            
            if (business != null)
            {

                return Ok(business);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DELETE([FromRoute] int id)
        {
            business.IDBusiness = id;
            business.Read();
            string SerializeToJson = JsonConvert.SerializeObject(business);
            if (business == null)
                return NotFound();
            business.Delete();
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult PUT([FromRoute] int id,[FromBody] BusinessObject BusinessUpdate)
        {

            business.IDBusiness = id;
            business.Read();
            string SerializeToJson = JsonConvert.SerializeObject(BusinessUpdate);
            if (business == null)
                return NotFound();

            BusinessUpdate.Updata();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody]BusinessObject BusinessCreate)
        {
        
            BusinessCreate.Updata();
            return Accepted();
        }
    }
}
