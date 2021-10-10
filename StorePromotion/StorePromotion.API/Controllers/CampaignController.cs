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
    public class CampaignController : ControllerBase
    {
        private readonly StorePromotionsContext _context;
        // GET: AdminUserController
        public CampaignController(StorePromotionsContext context)
        {
            _context = context;
        }
        [HttpGet("GetCustomers")]
        public async Task<ActionResult<IEnumerable<Campaign>>> GetCampaigns()
        {
            return await _context.Campaigns.ToListAsync();
        }

        // GET: api/AdminUser/5
        [HttpGet("GetCampaign")]
        public async Task<ActionResult<Campaign>> GetCampaign(int id)
        {
            var campaign = await _context.Campaigns.FindAsync(id);

            if (campaign == null)
            {
                return NotFound();
            }

            return campaign;
        }

        // PUT: api/AdminUser/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("PutCampaign")]
        public async Task<IActionResult> PutAdminUser(int id, Campaign campaign)
        {
            if (id != campaign.CampaignId)
            {
                return BadRequest();
            }

            _context.Entry(campaign).State = EntityState.Modified;

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

        [HttpPost("PostCampaign")]
        public async Task<ActionResult<Campaign>> PostCampaign(Campaign campaign)
        {
            _context.Campaigns.Add(campaign);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCampaign", new { id = campaign.CampaignId }, campaign);
        }

        // DELETE: api/AdminUser/5
        [HttpDelete("DeleteCampaign")]
        public async Task<ActionResult<Campaign>> DeleteCampaign(int id)
        {
            var campaign = await _context.Campaigns.FindAsync(id);
            if (campaign == null)
            {
                return NotFound();
            }

            _context.Campaigns.Remove(campaign);
            await _context.SaveChangesAsync();

            return campaign;
        }

        private bool CampaignExists(int id)
        {
            return _context.Campaigns.Any(e => e.CampaignId == id);
        }
    }
}
