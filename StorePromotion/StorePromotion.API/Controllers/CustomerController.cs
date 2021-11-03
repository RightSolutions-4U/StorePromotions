using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StorePromotion.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePromotion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly StorePromotionsContext _context;
        // GET: AdminUserController
        public CustomerController(StorePromotionsContext context)
        {
            _context = context;
        }
        // GET: api/AdminUser
        [HttpGet("GetCustomers")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        // GET: api/AdminUser/5
        [HttpGet("GetCustomer")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        [HttpGet("GetCustomerWithStoreId")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomerWithStoreId(int storeid)
        {
            var customer = await _context.Customers.Where(a => a.StoreId == storeid)
                    .ToListAsync();
            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }
        // PUT: api/AdminUser/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("PutAdminUser")]
        public async Task<IActionResult> PutAdminUser(int id, Customer customer)
        {
            if (id != customer.CustId)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!AddressExists(id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return NoContent();
        }

        [HttpPost("PostCustomer")]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.CustId }, customer);
        }

        // DELETE: api/AdminUser/5
        [HttpDelete("DeleteCustomer")]
        public async Task<ActionResult<Customer>> DeleteCustomer(int id)
        {
            var storeOwner = await _context.Customers.FindAsync(id);
            if (storeOwner == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(storeOwner);
            await _context.SaveChangesAsync();

            return storeOwner;
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustId == id);
        }
    }
}
