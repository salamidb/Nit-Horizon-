using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Knith_Horizon.Models;

namespace Knith_Horizon.Controllers
{
    public class AttendenceController : Controller
    {
        private knithEntities1 db = new knithEntities1();

        // GET: /Attendence/
        public ActionResult Index()
        {
            return View(db.AttendIntegrities.ToList());
        }

        // GET: /Attendence/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendIntegrity attendintegrity = db.AttendIntegrities.Find(id);
            if (attendintegrity == null)
            {
                return HttpNotFound();
            }
            return View(attendintegrity);
        }

        // GET: /Attendence/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Attendence/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Eno,CheckFDate,CheckTDate,Checked")] AttendIntegrity attendintegrity)
        {
            if (ModelState.IsValid)
            {
                db.AttendIntegrities.Add(attendintegrity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(attendintegrity);
        }

        // GET: /Attendence/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendIntegrity attendintegrity = db.AttendIntegrities.Find(id);
            if (attendintegrity == null)
            {
                return HttpNotFound();
            }
            return View(attendintegrity);
        }

        // POST: /Attendence/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Eno,CheckFDate,CheckTDate,Checked")] AttendIntegrity attendintegrity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendintegrity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attendintegrity);
        }

        // GET: /Attendence/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AttendIntegrity attendintegrity = db.AttendIntegrities.Find(id);
            if (attendintegrity == null)
            {
                return HttpNotFound();
            }
            return View(attendintegrity);
        }

        // POST: /Attendence/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AttendIntegrity attendintegrity = db.AttendIntegrities.Find(id);
            db.AttendIntegrities.Remove(attendintegrity);
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
