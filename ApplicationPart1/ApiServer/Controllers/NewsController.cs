using FileWorxObjects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {

        
        private News news = new News();
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
        public IActionResult GET([FromRoute]int id)
        {
            news.IDBusiness = id;
       
            news.Read();
        
            if (news != null)
            {

                return Ok(news);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DELETE([FromRoute]int id)
        {
            news.IDBusiness = id;
            news.Read();
            
            if (news == null)
                return NotFound();
            news.Delete();
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult PUT([FromRoute]int id,[FromBody]News NewsUpdate)
        {
            NewsUpdate.IDBusiness = id;
            news.IDBusiness = id;
            news.Read();
            
            if (news == null)
                return NotFound();

            NewsUpdate.Updata();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody]News NewsCreate)
        {
           
            NewsCreate.Updata();
            
            return Ok(NewsCreate.IDNews);
        }
    }
}
