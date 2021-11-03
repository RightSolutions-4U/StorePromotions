using StorePromotion.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace StorePromotion.UI.Controllers
{
    public class PromotionsController : Controller
    {
        // GET: PromotionsController
        public async Task<ActionResult<Store>> Index(int ownerid)
        {
            //Add code to call api to check store owner login
                try
                {

                        // Get all stores
                        Store store = new Store();
                        var client1 = new HttpClient();
                        client1.DefaultRequestHeaders.Clear();
                        UriBuilder builder1 = new UriBuilder("https://localhost:44303/api/Store/GetStoresWithOId?");
                        builder1.Query = "OwnerId=" + ownerid;
                        HttpResponseMessage Res1 = await client1.GetAsync(builder1.Uri);
                        var stores = Res1.Content.ReadAsStringAsync().Result;
                        var a = JsonConvert.DeserializeObject<Store[]>(stores);

                        if (Res1.IsSuccessStatusCode)
                        {
                            return View("Promotions", a);
                        }
                        
                    return View("Promotions");
                }
                catch (Exception e)
                {
                    return View("Promotions");
                }
                
        }

        // GET: PromotionsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PromotionsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PromotionsController/Create
        [HttpPost]
/*        [ValidateAntiForgeryToken]*/
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {

                var Message = collection["txtMessag"];
            var StoreId = collection["StoreId1"];
            /*Customer customers = new Customer();*/
            var client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            UriBuilder builder = new UriBuilder("https://localhost:44303/api/Customer/GetCustomerWithStoreId?");

            builder.Query = "storeid=" + StoreId;
            HttpResponseMessage Res = await client.GetAsync(builder.Uri);
            var customers = Res.Content.ReadAsStringAsync().Result;
            Customer[] a = JsonConvert.DeserializeObject<Customer[]>(customers);
            if (Res.IsSuccessStatusCode)
            {
                    var accountSid = "";
                    var authToken = "";
                    TwilioClient.Init(accountSid, authToken);
                    /*var to = new PhoneNumber("+923354883191");*/
                    var to = new PhoneNumber("+12057459526");
                    /*var from = new PhoneNumber("+17162192114");*/
                    var from = new PhoneNumber("+17074523398");

                   /* var message = MessageResource.Create(
                        to: to,
                        from: from,
                        body: "Sending SMS to shazia from twilio test Account"
                        );*/
                    /*return Content(message.Sid);*/
                    foreach (var c in a)
                    {
                        var message = MessageResource.Create(
                        to: to,
                        from: from,
                        body: "Sending SMS to shazia from twilio test Account"
                        );
                    }
            }


                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: PromotionsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PromotionsController/Edit/5
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

        // GET: PromotionsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PromotionsController/Delete/5
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
