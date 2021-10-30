using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using StorePromotion.Common.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StorePromotion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly StorePromotionsContext _context;
        /*[Obsolete]*/
        private readonly IWebHostEnvironment _hostingEnvironment;
        // GET: AdminUserController
        public StoreController(StorePromotionsContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        // GET: api/AdminUser
        [HttpGet("GetStores")]
        public async Task<ActionResult<IEnumerable<Store>>> GetStores()
        {
            return await _context.Stores.ToListAsync();
        }

        // GET: api/AdminUser/5
        [HttpGet("GetStore")]
        public async Task<ActionResult<Store>> GetStore(int StoreId, int StoreOwnerId)
        {
            var store = await _context.Stores.FindAsync(StoreId,StoreOwnerId);
            /*var store =  _context.Stores.Where(e => e.StoreId == StoreId);*/
            if (store == null)
            {
                return NotFound();
            }

            return store;
        }
        //GetStoresWithOId
        [HttpGet("GetStoresWithOId")]
        public async Task<ActionResult<IEnumerable<Store>>> GetStoresWithOId(int OwnerId)
        {
            try
            {
                var store = await _context.Stores.Where(a => a.OwnerId == OwnerId)
                    .ToListAsync();
                return store;
            }
            catch(Exception e) {
                var msg = e.Message;
            }
            return NotFound();
        }
        // PUT: api/AdminUser/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        
        [HttpPut("PutStore")]
        public async Task<IActionResult> PutStore(int StoreId, Store store)
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
            catch (Exception e)
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
        [HttpPut("PutStoreEd")]
        public async Task<IActionResult> PutStoreEd(Store store)
        {
            _context.Entry(store).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
            }

            return NoContent();
        }

        [HttpPost("PostStore")]
        public async Task<ActionResult<Store>> PostStore(Store Store)
        {
            _context.Stores.Add(Store);
            await _context.SaveChangesAsync();

            //Add code to generate QRCode file and path
            QRCodeGenerator ObjQr = new QRCodeGenerator();

            QRCodeData qrCodeData = ObjQr.CreateQrCode("http://rightsolutions4u.com/qrcode/"+ Store.StoreId  , QRCodeGenerator.ECCLevel.Q);

            Bitmap bitMap = new QRCode(qrCodeData).GetGraphic(20);

            using (MemoryStream ms = new MemoryStream())

            {

                string projectRootPath = _hostingEnvironment.WebRootPath;
                string projectRootPath1 = _hostingEnvironment.ContentRootPath;
                projectRootPath = projectRootPath1.Replace("StorePromotion.API", "StorePromotion.UI");
                string path = projectRootPath + "\\wwwroot\\img\\QRCodes\\";
                var filename = "QRCode" + Store.StoreId + ".png";
                path = path + filename;
                    /*string path_virtual = "~/ProductImages/";*/

                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                byte[] byteImage = ms.ToArray();
                /*bitMap.Save("QRCode.png");*/
                bitMap.Save(@path, System.Drawing.Imaging.ImageFormat.Png);
                Store.Qrurl = path;
                var p1 = await PutStore(Store.StoreId, Store);
                //_context.Entry(Store).State = EntityState.Modified;

                //try
                //{
                //    await _context.SaveChangesAsync();
                //}
                //catch (DbUpdateConcurrencyException)
                //{
                //}


            }
            //Update current store record with QRCode URL
            

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
