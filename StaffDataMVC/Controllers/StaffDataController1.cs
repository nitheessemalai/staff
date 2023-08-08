using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using staff.repository;

namespace StaffDataMVC.Controllers
{
    public class StaffDataController1 : Controller

    {

        staffregisterinfo obj;
        public StaffDataController1()
        {
            obj = new staffregisterinfo();
        }
        // GET: StaffDataController1
        public ActionResult List()
        {
            return View("List", obj.selectsp()); 
        }

        // GET: StaffDataController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StaffDataController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StaffDataController1/Create
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

        // GET: StaffDataController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StaffDataController1/Edit/5
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

        // GET: StaffDataController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StaffDataController1/Delete/5
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
