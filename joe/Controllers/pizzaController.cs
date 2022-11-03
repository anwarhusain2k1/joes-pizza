using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace joe.Controllers
{
    public class pizzaController : Controller
    {
        // GET: pizza
        public ActionResult menu()
        {
            op obj = new op();
            obj.add();
            List<pizza> Menu = obj.menu;
            return View(Menu);
        }

        // GET: pizza/Details/5
        public ActionResult Details(string id)
        {
            op obj = new op();
            obj.add();
            List<pizza> Menu = obj.menu;
            pizza p = Menu.Find(x => x.Name == id);
            op.cart.Add(p);
            return View(p);
        }
        public ActionResult cart()
        {
            
            int amount=0;
            foreach(pizza p in op.cart)
                amount = amount +p.price;
            ViewBag.total = amount;
            return View(op.cart);
        }
        // GET: pizza/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: pizza/Create
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

        // GET: pizza/Edit/5
        public ActionResult Edit(string name)
        {
            return View();
        }

        // POST: pizza/Edit/5
        [HttpPost]
        public ActionResult Edit(string name,pizza p)
        {
            try
            {
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: pizza/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: pizza/Delete/5
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
