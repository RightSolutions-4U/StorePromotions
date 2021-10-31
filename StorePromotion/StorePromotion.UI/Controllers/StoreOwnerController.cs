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

        //Add code to call api to check store owner login
        public async Task<ActionResult<StoreOwner>> CheckOwnerLogin(IFormCollection  collection)
        {
            try
            {
                StoreOwner storeOwner = new StoreOwner();
                var client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                UriBuilder builder = new UriBuilder("https://localhost:44303/api/StoreOwner/GetStoreOwnerWithPwd?");

                builder.Query = "userId=" + collection["username"] + "&pwd=" + collection["pwd"];
                HttpResponseMessage Res = await client.GetAsync(builder.Uri);
                var storeowner = Res.Content.ReadAsStringAsync().Result;
                StoreOwner a = JsonConvert.DeserializeObject<StoreOwner>(storeowner);
                if (Res.IsSuccessStatusCode)
                {
                    // Get all stores
                    StoreDetails storeDetail = new StoreDetails();
                    var client1 = new HttpClient();
                    client1.DefaultRequestHeaders.Clear();
                    UriBuilder builder1 = new UriBuilder("https://localhost:44303/api/Store/GetStoresWithOId?");
                    StoreOwnerDetails storeOwnerDetails = new StoreOwnerDetails();
                    builder1.Query = "OwnerId=" + a.OwnerId;  
                    HttpResponseMessage Res1 = await client1.GetAsync(builder1.Uri);
                    var stores = Res1.Content.ReadAsStringAsync().Result;
                    storeOwnerDetails.Store = JsonConvert.DeserializeObject<Store[]>(stores);

                    if (Res1.IsSuccessStatusCode)
                    {
                        ViewBag.StoreOwnerName = a.Fname;
                        ViewBag.StoreOwnerId = a.OwnerId;
                    }
                    ViewBag.StoreOwnerLName = a.Fname;
                    ViewBag.StoreOwnerId = a.OwnerId;

                    ViewBag.StoreOwner = storeowner;
                    storeOwnerDetails.StoreOwner = a;
                    ViewBag.Error = null;
                    /*return View("Store", a);*/
                    return View("Store", storeOwnerDetails);
                }
                return View("Store");
            }
            catch (Exception e)
            {
                return View();
            }
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
                var url = "https://localhost:44303/api/StoreOwner/PostStoreOwner";
                /*var url = "https://localhost:44356/api/Addresses";*/

                var client = new HttpClient();
                var response = await client.PostAsync(url, data);
                var StoreOwner = response.Content.ReadAsStringAsync().Result;
                var StoreOwner1 = JsonConvert.DeserializeObject<StoreOwner>(StoreOwner);
                var StoreOwnerName = StoreOwner1.Fname;
                ViewBag.OwnerName = StoreOwnerName;
                /*return RedirectToAction(nameof(Index));*/
                return View("Store");
            }
            catch(Exception e)
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
