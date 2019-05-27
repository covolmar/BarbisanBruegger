using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BarbisanBruegger.Models;

namespace BarbisanBruegger.Controllers
{
    public class FormworksController : Controller
    {
        private FormworkDBContext db = new FormworkDBContext();

        // GET: Formworks
        public ActionResult Index()
        {
            return View(db.Formworks.ToList());
        }

        // GET: Formworks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Formwork formwork = db.Formworks.Find(id);
            if (formwork == null)
            {
                return HttpNotFound();
            }
            return View(formwork);
        }

        // GET: Formworks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Formworks/Create
        // Aktivieren Sie zum Schutz vor übermäßigem Senden von Angriffen die spezifischen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Description,Number,PricePerMonth")] Formwork formwork)
        {
            if (ModelState.IsValid)
            {
                db.Formworks.Add(formwork);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(formwork);
        }

        // GET: Formworks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Formwork formwork = db.Formworks.Find(id);
            if (formwork == null)
            {
                return HttpNotFound();
            }
            return View(formwork);
        }

        // POST: Formworks/Edit/5
        // Aktivieren Sie zum Schutz vor übermäßigem Senden von Angriffen die spezifischen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Description,Number,PricePerMonth")] Formwork formwork)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formwork).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(formwork);
        }

        // GET: Formworks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Formwork formwork = db.Formworks.Find(id);
            if (formwork == null)
            {
                return HttpNotFound();
            }
            return View(formwork);
        }

        // POST: Formworks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Formwork formwork = db.Formworks.Find(id);
            db.Formworks.Remove(formwork);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
