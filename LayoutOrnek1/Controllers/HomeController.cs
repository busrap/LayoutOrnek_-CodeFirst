using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LayoutOrnek1.Models;

namespace LayoutOrnek1.Controllers
{
    public class HomeController : Controller
    {
        private CalisanlarContext db = new CalisanlarContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Calisanlar.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calisan calisan = db.Calisanlar.Find(id);
            if (calisan == null)
            {
                return HttpNotFound();
            }
            return View(calisan);
        }
       
        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Adi,Soyadi,Maasi")] Calisan calisan)
        {
            if (ModelState.IsValid)
            {
                db.Calisanlar.Add(calisan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calisan);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calisan calisan = db.Calisanlar.Find(id);
            if (calisan == null)
            {
                return HttpNotFound();
            }
            return View(calisan);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Adi,Soyadi,Maasi")] Calisan calisan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calisan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calisan);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calisan calisan = db.Calisanlar.Find(id);
            if (calisan == null)
            {
                return HttpNotFound();
            }
            return View(calisan);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calisan calisan = db.Calisanlar.Find(id);
            db.Calisanlar.Remove(calisan);
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
