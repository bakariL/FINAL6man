using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TV5.Models;

namespace TV5.Controllers
{
    public class VideoPlayersController : Controller
    {
        private TV5Context db = new TV5Context();

        // GET: VideoPlayers
        public ActionResult Index()
        {
            return View(db.VideoPlayers.ToList());
        }

        // GET: VideoPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoPlayer videoPlayer = db.VideoPlayers.Find(id);
            if (videoPlayer == null)
            {
                return HttpNotFound();
            }
            return View(videoPlayer);
        }

        // GET: VideoPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VideoID")] VideoPlayer videoPlayer)
        {
            if (ModelState.IsValid)
            {
                db.VideoPlayers.Add(videoPlayer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(videoPlayer);
        }

        // GET: VideoPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoPlayer videoPlayer = db.VideoPlayers.Find(id);
            if (videoPlayer == null)
            {
                return HttpNotFound();
            }
            return View(videoPlayer);
        }

        // POST: VideoPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VideoID")] VideoPlayer videoPlayer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(videoPlayer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(videoPlayer);
        }

        // GET: VideoPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoPlayer videoPlayer = db.VideoPlayers.Find(id);
            if (videoPlayer == null)
            {
                return HttpNotFound();
            }
            return View(videoPlayer);
        }

        // POST: VideoPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VideoPlayer videoPlayer = db.VideoPlayers.Find(id);
            db.VideoPlayers.Remove(videoPlayer);
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
