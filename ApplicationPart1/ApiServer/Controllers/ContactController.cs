using FileWorxObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using AutoMapper;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private Contact contact = new Contact();
        [HttpPut]
        public IActionResult GET([FromBody] ContactQuery contactfilter)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ContactQueryService,ContactQuery>());
            var mapper = new Mapper(config);

            ContactQuery ContactFilter = mapper.Map<ContactQuery>(contactfilter);

            List<Contact> ListDataContact = ContactFilter.Run();
            if (ListDataContact != null)
            {

                return Ok(ListDataContact);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult GET([FromRoute] int id)
        {
            contact.IDBusiness = id;

            contact.Read();

            if (contact != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Contact, ContactReadService>());
                var mapper = new Mapper(config);

                ContactReadService contactedit = mapper.Map<ContactReadService>(contact);
                return Ok(contactedit);
            }
            return NotFound();
        }
 
        [HttpDelete("{id}")]
        public IActionResult DELETE([FromRoute] int id)
        {
            contact.IDBusiness = id;
            contact.Read();

            if (contact == null)
                return NotFound();
            contact.Delete();
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult PUT([FromRoute] int id, [FromBody] ContactUpdateService ContactUpdate)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ContactUpdateService, Contact>());
            var mapper = new Mapper(config);

            Contact contactedit = mapper.Map<Contact>(ContactUpdate);
            contactedit.IDBusiness = id;
            contact.IDBusiness = id;
            contact.Read();

            if (contact == null)

                return NotFound();

            contactedit.Updata();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody] ContactUpdateService ContactCreate)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ContactUpdateService, Contact>());
            var mapper = new Mapper(config);

            Contact contact = mapper.Map<Contact>(ContactCreate);
            contact.IDBusiness = -1;
            contact.ClassIDFileOrUser = 4;

            contact.Updata();
            return Accepted(contact.IDContact);
        }
    }
}
