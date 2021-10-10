using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StorePromotion.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace StorePromotion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreOwnerController : ControllerBase
    {
        private readonly StorePromotionsContext _context;
        // GET: AdminUserController
        public StoreOwnerController(StorePromotionsContext context)
        {
            _context = context;
        }
        // GET: api/AdminUser
        [HttpGet("GetStoreOwners")]
        public async Task<ActionResult<IEnumerable<StoreOwner>>> GetStoreOwners()
        {
            return await  _context.StoreOwners.ToListAsync();
        }

        // GET: api/AdminUser/5
        [HttpGet("GetStoreOwner")]
        public async Task<ActionResult<StoreOwner>> GetStoreOwner(string id)
        {
            var adminUser = await _context.StoreOwners.FindAsync(id);

            if (adminUser == null)
            {
                return NotFound();
            }

            return adminUser;
        }

        [HttpGet("GetStoreOwnerWithPwd")]
        public ActionResult<StoreOwner> GetStoreOwnerWithPwd(string userId, string pwd)
        {
            bool StoreOwnerExists;
            StoreOwnerExists = _context.StoreOwners.Any(e => e.UserId == userId && e.Pwd == pwd);

            if (StoreOwnerExists == false)
            {
                return NotFound();
            }
            var storeOwner = _context.StoreOwners.SingleOrDefault(e => e.UserId == userId);
            return storeOwner;
        }

        // PUT: api/AdminUser/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("PutAdminUser")]
        public async Task<IActionResult> PutAdminUser(string id, AdminUser adminUser)
        {
            if (id != adminUser.UserId)
            {
                return BadRequest();
            }

            _context.Entry(adminUser).State = EntityState.Modified;

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

        [HttpPost("PostStoreOwner")]
        public async Task<ActionResult<StoreOwner>> PostStoreOwner(StoreOwner storeOwner)
        {
/*            storeOwner.Fname = FName;
            storeOwner.Lname = LName;
            storeOwner.CellNo = CellNo;
            storeOwner.Email = Email;
            storeOwner.IsActive = IsActive;
*/            _context.StoreOwners.Add(storeOwner);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStoreOwner", new { id = storeOwner.OwnerId }, storeOwner);
        }

        // DELETE: api/AdminUser/5
        [HttpDelete("DeleteStoreOwner")]
        public async Task<ActionResult<StoreOwner>> DeleteStoreOwner(int id)
        {
            var storeOwner = await _context.StoreOwners.FindAsync(id);
            if (storeOwner == null)
            {
                return NotFound();
            }

            _context.StoreOwners.Remove(storeOwner);
            await _context.SaveChangesAsync();

            return storeOwner;
        }

        private bool StoreOwnerExists(int id)
        {
            return _context.StoreOwners.Any(e => e.OwnerId == id);
        }
    }
}
