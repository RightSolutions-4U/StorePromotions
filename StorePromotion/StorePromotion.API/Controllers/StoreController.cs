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
    public class StoreController : ControllerBase
    {
        private readonly StorePromotionsContext _context;
        // GET: AdminUserController
        public StoreController(StorePromotionsContext context)
        {
            _context = context;
        }
        // GET: api/AdminUser
        [HttpGet("GetStores")]
        public async Task<ActionResult<IEnumerable<Store>>> GetStores()
        {
            return await _context.Stores.ToListAsync();
        }

        // GET: api/AdminUser/5
        [HttpGet("GetStore")]
        public async Task<ActionResult<Store>> GetStore(int StoreId)
        {
            var adminUser = await _context.Stores.FindAsync(StoreId);

            if (adminUser == null)
            {
                return NotFound();
            }

            return adminUser;
        }

        // PUT: api/AdminUser/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("PutAdminUser")]
        public async Task<IActionResult> PutAdminUser(int StoreId, Store store)
        {
            if (StoreId != store.StoreId)
            {
                return BadRequest();
            }

            _context.Entry(store).State = EntityState.Modified;

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

        [HttpPost("PostStore")]
        public async Task<ActionResult<Store>> PostStore(Store Store)
        {
            _context.Stores.Add(Store);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStore", new { id = Store.StoreId }, Store);
        }

        // DELETE: api/AdminUser/5
        [HttpDelete("DeleteStore")]
        public async Task<ActionResult<Store>> DeleteStore(int StoreId)
        {
            var Store = await _context.Stores.FindAsync(StoreId);
            if (Store == null)
            {
                return NotFound();
            }

            _context.Stores.Remove(Store);
            await _context.SaveChangesAsync();

            return Store;
        }

        private bool StoreExists(int storeId)
        {
            return _context.Stores.Any(e => e.StoreId == storeId);
        }
    }
}
