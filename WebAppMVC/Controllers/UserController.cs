using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.DAL;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class UserController : Controller
    {

        private _I_AllRepository<User> interfaceobj;

        public UserController()
        {
            this.interfaceobj = new AllRepository<User>();
        }
        // GET: User
        public ActionResult Index()
        {
            return View(from m in interfaceobj.GetModel() select m);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            User b = interfaceobj.GetModelById(id);
            return View(b);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User collection)
        {
            try
            {
                // TODO: Add insert logic here
                interfaceobj.InsertModel(collection);
                interfaceobj.save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            User b = interfaceobj.GetModelById(id);
            return View(b);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User collection)
        {
            try
            {
                // TODO: Add update logic here
                interfaceobj.UpdateModel(collection);
                interfaceobj.save();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: MyBooks/Delete/5
        public ActionResult Delete(int id)
        {

            User b = interfaceobj.GetModelById(id);
            return View(b);
        }

        // POST: MyBooks/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User collection)
        {
            try
            {
                // TODO: Add delete logic here
                interfaceobj.DeleteModel(id);
                interfaceobj.save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }



}