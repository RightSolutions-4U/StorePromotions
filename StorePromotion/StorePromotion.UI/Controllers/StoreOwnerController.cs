using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
