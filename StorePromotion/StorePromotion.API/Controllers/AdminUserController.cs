using Microsoft.AspNetCore.Http;
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
    public class AdminUserController : ControllerBase
    {
        private readonly StorePromotionsContext _context;
        // GET: AdminUserController
        public AdminUserController(StorePromotionsContext context)
        {
            _context = context;
        }

        // GET: api/AdminUser
        [HttpGet("GetAdminUsers")]
        public async Task<ActionResult<IEnumerable<AdminUser>>> GetAdminUsers()
        {
            return await _context.AdminUsers.ToListAsync();
        }

        // GET: api/AdminUser/5
        [HttpGet("GetAdminUser")]
        public async Task<ActionResult<AdminUser>> GetAdminUser(string id)
        {
            var adminUser = await _context.AdminUsers.FindAsync(id);

            if (adminUser == null)
            {
                return NotFound();
            }

            return adminUser;
        }

        [HttpGet("GetAdminUserWithPwd")]
        public ActionResult<AdminUser> GetAdminUserWithPwd(string userId, string pwd)
        {
            bool AdminUserExists;
            AdminUserExists = _context.AdminUsers.Any(e => e.UserId == userId && e.Pwd == pwd);

            if (AdminUserExists == false)
            {
                return NotFound();
            }
            var AdminUsers = _context.AdminUsers.SingleOrDefault(e => e.UserId == userId);
            return AdminUsers;
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

                [HttpPost("PostAdminUser")]
                public async Task<ActionResult<AdminUser>> PostAdminUser(string id, string pwd, AdminUser adminUser)
                {
                    adminUser.UserId = id;
                    adminUser.Pwd = pwd;
                    _context.AdminUsers.Add(adminUser);
                    await _context.SaveChangesAsync();

                    return CreatedAtAction("GetAdminUser", new { id = adminUser.UserId }, adminUser);
                }

                // DELETE: api/AdminUser/5
                [HttpDelete("DeleteAdminUser")]
                public async Task<ActionResult<AdminUser>> DeleteAdminUser(string id)
                {
                    var adminUser = await _context.AdminUsers.FindAsync(id);
                    if (adminUser == null)
                    {
                        return NotFound();
                    }

                    _context.AdminUsers.Remove(adminUser);
                    await _context.SaveChangesAsync();

                    return adminUser;
                }

                private bool AdminUserExists(string id)
                {
                    return _context.AdminUsers.Any(e => e.UserId == id);
                }
    }
}
