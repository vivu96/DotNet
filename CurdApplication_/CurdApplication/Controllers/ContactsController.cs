using CURDApplication.Data;
using CURDApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CURDApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactsAPIDbContext dbContext;

        public ContactsController(ContactsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {

            return Ok(await dbContext.Contants.ToListAsync());
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetContact([FromRoute] Guid id)
        {
            var contact =await dbContext.Contants.FindAsync(id);
            if (contact == null) {
                return NotFound("Not Found ");

            }
            return Ok(contact);
        }

        [HttpPost]
        public async Task<ActionResult> AddContact(AddContactRequest AddContactRequest)
        {
            var contact = new Contact()
            {
                Id = Guid.NewGuid(),
                Address = AddContactRequest.Address,
                Email = AddContactRequest.Email,
                FullName = AddContactRequest.FullName,
                Phone = AddContactRequest.Phone
            };
            await dbContext.Contants.AddAsync(contact);
            await dbContext.SaveChangesAsync();

            return Ok(contact);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<ActionResult> UpdateContact([FromRoute] Guid id, UpdateContactRequest UpdateContactRequest)
        {

            var contant = await dbContext.Contants.FindAsync(id);
            if (contant != null)
            {
                contant.FullName = UpdateContactRequest.FullName;
                contant.Address = UpdateContactRequest.Address;
                contant.Phone = UpdateContactRequest.Phone;
                contant.Email = UpdateContactRequest.Email;
                await dbContext.SaveChangesAsync();
                return Ok("Success");

            }


            return NotFound("Showing some Error");


        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<ActionResult> DeleteContact([FromRoute] Guid id)
        {
            var contact = await dbContext.Contants.FindAsync(id);
            if (contact != null)
            {
                dbContext.Remove(contact);
              await  dbContext.SaveChangesAsync();
                return Ok("this was delete");
            }
            return NotFound();


        }
    }
}