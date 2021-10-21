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
    public class CityController : ControllerBase
    {
        private readonly StorePromotionsContext _context;
        // GET: AdminUserController
        public CityController(StorePromotionsContext context)
        {
            _context = context;
        }
        // GET: api/AdminUser
        [HttpGet("GetCities")]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            return await _context.Cities.ToListAsync();
        }
       

    }
}
