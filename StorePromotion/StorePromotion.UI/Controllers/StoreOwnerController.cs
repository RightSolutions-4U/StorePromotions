using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StorePromotion.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StorePromotion.UI.Controllers
{
    public class StoreOwnerController : Controller
    {
        // GET: StoreOwnerController
        public ActionResult Index()
        {
            return View("Register");
        }

        // GET: StoreOwnerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreOwnerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreOwnerController/Create
        [HttpPost]
        public async Task<ActionResult<StoreOwner>> Create(IFormCollection collection)
        {
            try
            {

                StoreOwner storeOwner = new StoreOwner
                {
                    Fname = collection["FName"],
                    Lname = collection["LName"],
                    CellNo = collection["CellNo"],
                    Email = collection["Email"],
                    UserId = collection["UserId"],
                    Pwd = collection["Pwd"],
                    IsActive = true
                };
                string output = JsonConvert.SerializeObject(storeOwner);
                var data = new StringContent(output, Encoding.UTF8, "application/json");
                var url = "https://localhost:44356/api/StoreOwner";
                /*var url = "https://localhost:44356/api/Addresses";*/

                var client = new HttpClient();
                var response = await client.PostAsync(url, data);
                var StoreOwner = response.Content.ReadAsStringAsync().Result;
                var StoreOwner1 = JsonConvert.DeserializeObject<StoreOwner>(StoreOwner);
                var StoreOwnerName = StoreOwner1.Fname;
                ViewBag.Name = StoreOwnerName;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreOwnerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreOwnerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreOwnerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreOwnerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
