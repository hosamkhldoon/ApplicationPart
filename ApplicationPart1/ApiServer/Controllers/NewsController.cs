using FileWorxObjects;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DTO;
using AutoMapper;
using Confluent.Kafka;
using System;

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
                var config = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsReadService>());
                var mapper = new Mapper(config);
                  
                NewsReadService newsread = mapper.Map<NewsReadService>(news);
                return Ok(newsread);
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
        public IActionResult PUT([FromRoute]int id,[FromBody]NewsUpdateService NewsUpdate)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NewsUpdateService, News>());
            var mapper = new Mapper(config);

            News newsedit = mapper.Map<News>(NewsUpdate);
            newsedit.IDBusiness = id;
            newsedit.ClassIDFileOrUser = 1;
            news.IDBusiness = id;
            news.Read();
            
            if (news == null)
                return NotFound();

            newsedit.Updata();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody]NewsUpdateService NewsCreate)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NewsUpdateService, News>());
            var mapper = new Mapper(config);

            News news = mapper.Map<News>(NewsCreate);
            news.IDBusiness = -1;
            news.ClassIDFileOrUser = 1;
            news.Updata();
            return Ok(news.IDNews);
        }
    }
}
