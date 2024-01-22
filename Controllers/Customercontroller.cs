using Microsoft.AspNetCore.Mvc;
using Customer.Data;
using Microsoft.EntityFrameworkCore;

namespace Customer.Data
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ApiDbContext _context;

        private int id;

        public CustomerController(ApiDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetCustomer")]
         public ActionResult<IEnumerable<Customer>>Get ()
         {
            return _context.Customers.ToList();
         }

           // public async Task<ActionResult<int>> GetCustomer(int id)
        // {
        //     return Ok(await _context.Customers.ToListAsync());
        // }
         

        // [HttpDelete]
        // [Route("id")]

        // public async Task<ActionResult<int>> DeleteCustomer(int id)

        // {
        //     var Customer = await _context.Customers.FindAsync(id);


        //     if (Customer == null)
        //     {
        //         return NotFound("Incorrect Trainee Id");
        //     }


        //     _context.Customers.Remove(Customer);
        //     await _context.SaveChangesAsync();

        //     return Ok();
        // }


        // [HttpPut]
        // [Route("id")]

        // public async Task<ActionResult> PutCustomer(Customer Customer)
        // {
        //     if (id != Customer.Id)
        //     {

        //         return BadRequest();
        //     }
        //     _context.Entry(Customer).State = EntityState.Modified;
        //     await _context.SaveChangesAsync();
        //     return Ok();
        // }


        // [HttpPost]
        // [Route("Create")]

        // public async Task<ActionResult<Customer>> Create(Customer Customer)
        // {
        //     _context.Add(Customer);

        //     await _context.SaveChangesAsync();
        //     return Ok();


        // }




    }
}