using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using do0.Models;

namespace do0.Controllers
{
    public class AdmFrontPagePostsController : Controller
    {
        private do0Context db = new do0Context();

        // GET: AdmFrontPagePosts
        public ActionResult Index()
        {
            return View(db.FrontPagePosts.ToList());
        }

        // GET: AdmFrontPagePosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FrontPagePosts frontPagePosts = db.FrontPagePosts.Find(id);
            if (frontPagePosts == null)
            {
                return HttpNotFound();
            }
            return View(frontPagePosts);
        }

        // GET: AdmFrontPagePosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdmFrontPagePosts/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "do0FrontPagePostsId,do0AvatarName,do0UserName,Rascunho,Autor,Data,Titulo,Introducao,Descricao,Pasta,LinkExterno,LinkUrl,Reserva1")] FrontPagePosts frontPagePosts)
        {
            if (ModelState.IsValid)
            {
                db.FrontPagePosts.Add(frontPagePosts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(frontPagePosts);
        }

        // GET: AdmFrontPagePosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FrontPagePosts frontPagePosts = db.FrontPagePosts.Find(id);
            if (frontPagePosts == null)
            {
                return HttpNotFound();
            }
            return View(frontPagePosts);
        }

        // POST: AdmFrontPagePosts/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "do0FrontPagePostsId,do0AvatarName,do0UserName,Rascunho,Autor,Data,Titulo,Introducao,Descricao,Pasta,LinkExterno,LinkUrl,Reserva1")] FrontPagePosts frontPagePosts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(frontPagePosts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(frontPagePosts);
        }

        // GET: AdmFrontPagePosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FrontPagePosts frontPagePosts = db.FrontPagePosts.Find(id);
            if (frontPagePosts == null)
            {
                return HttpNotFound();
            }
            return View(frontPagePosts);
        }

        // POST: AdmFrontPagePosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FrontPagePosts frontPagePosts = db.FrontPagePosts.Find(id);
            db.FrontPagePosts.Remove(frontPagePosts);
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
