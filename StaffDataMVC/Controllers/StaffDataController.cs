using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using staff.repository;
using staff.model;


namespace StaffDataMVC.Controllers
{
    public class StaffDataController : Controller

    {

        staffregisterinfo obj;
        public StaffDataController()
        {
            obj = new staffregisterinfo();
        }
        // GET: StaffDataController1
        public ActionResult List()
        {
            return View("Select", obj.selectsp()); 
        }

        // GET: StaffDataController1/Details/5
        public ActionResult Details(int id)
        {
           
            var result = obj.selectname(id);
            return View("Details", result);
        }

        // GET: StaffDataController1/Create
        public ActionResult Create()
        {
            
            return View("create",new staffmodel());
        }

        // POST: StaffDataController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(staffmodel data)
        {
            try
            {
                obj.insertsp(data);
               
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: StaffDataController1/Edit/5
        public ActionResult Edit(int id)
        {
            var result = obj.selectname(id);
            return View("Edit", result);
        }

        // POST: StaffDataController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, staffmodel data)
        {
            try
            {
                data.ID = id;
                obj.updatesp(data);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: StaffDataController1/Delete/5
        public ActionResult Delete(int id)
        {
            var result = obj.selectname(id);

            return View("Delete", result);

            
        }

        // POST: StaffDataController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, staffmodel data)
        {
            try
            {
                obj.deletesp(id);
                return RedirectToAction(nameof(List));
               
            }
            catch
            {
                return View();
            }
        }
    }
}
