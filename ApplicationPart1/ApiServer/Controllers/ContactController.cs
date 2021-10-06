using FileWorxObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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



            List<Contact> ListDataContact = contactfilter.Run();
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

                return Ok(contact);
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
        public IActionResult PUT([FromRoute] int id, [FromBody] Contact ContactUpdate)
        {
            ContactUpdate.IDBusiness = id;
            contact.IDBusiness = id;
            contact.Read();

            if (contact == null)
                return NotFound();

            ContactUpdate.Updata();
            return NoContent();
        }
        [HttpPost]
        public IActionResult POST([FromBody] Contact ContactCreate)
        {


            ContactCreate.Updata();
            return Accepted(ContactCreate.IDContact);
        }
    }
}
