using GCLab21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace GCLab21.Controllers
{
    public class RegistrationController : Controller
    {
        
        public ActionResult Index(string errormessage)
        {
            ViewBag.ErrorMessage = errormessage;
            return View();
        }

        //GET: Registration/Welcome
        public ActionResult Welcome(string firstname, string lastname, string userclass, string gender, string password, string useremail)
        {
            ViewBag.newuser = new User(firstname,  lastname,  userclass,  gender,  password, useremail);


            if (ViewBag.newuser.FirstName != "" && ViewBag.LastName != "" && ViewBag.Password != "")
            {
                return View();
            }

            else
            {
                return Redirect("Index");
            }
        }

        // GET: Registration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registration/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registration/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registration/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
