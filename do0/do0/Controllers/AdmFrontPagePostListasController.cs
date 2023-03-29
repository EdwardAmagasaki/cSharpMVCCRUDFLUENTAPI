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
    public class AdmFrontPagePostListasController : Controller
    {
        private do0Context db = new do0Context();

        // GET: AdmFrontPagePostListas
        public ActionResult Index()
        {
            var frontPagePostLista = db.FrontPagePostLista.Include(f => f.FrontPagePosts);
            return View(frontPagePostLista.ToList());
        }

        // GET: AdmFrontPagePostListas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FrontPagePostLista frontPagePostLista = db.FrontPagePostLista.Find(id);
            if (frontPagePostLista == null)
            {
                return HttpNotFound();
            }
            return View(frontPagePostLista);
        }

        // GET: AdmFrontPagePostListas/Create
        public ActionResult Create()
        {
            ViewBag.do0FrontPagePostsId = new SelectList(db.FrontPagePosts, "do0FrontPagePostsId", "do0AvatarName");
            return View();
        }

        // POST: AdmFrontPagePostListas/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FrontPagePostListaId,do0FrontPagePostsId,do0AvatarName,do0UserName,Rascunho,Autor,Data,Titulo,Introducao,Descricao,Pasta,LinkExterno,LinkUrl,Reserva1")] FrontPagePostLista frontPagePostLista)
        {
            if (ModelState.IsValid)
            {
                db.FrontPagePostLista.Add(frontPagePostLista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.do0FrontPagePostsId = new SelectList(db.FrontPagePosts, "do0FrontPagePostsId", "do0AvatarName", frontPagePostLista.do0FrontPagePostsId);
            return View(frontPagePostLista);
        }

        // GET: AdmFrontPagePostListas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FrontPagePostLista frontPagePostLista = db.FrontPagePostLista.Find(id);
            if (frontPagePostLista == null)
            {
                return HttpNotFound();
            }
            ViewBag.do0FrontPagePostsId = new SelectList(db.FrontPagePosts, "do0FrontPagePostsId", "do0AvatarName", frontPagePostLista.do0FrontPagePostsId);
            return View(frontPagePostLista);
        }

        // POST: AdmFrontPagePostListas/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FrontPagePostListaId,do0FrontPagePostsId,do0AvatarName,do0UserName,Rascunho,Autor,Data,Titulo,Introducao,Descricao,Pasta,LinkExterno,LinkUrl,Reserva1")] FrontPagePostLista frontPagePostLista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(frontPagePostLista).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.do0FrontPagePostsId = new SelectList(db.FrontPagePosts, "do0FrontPagePostsId", "do0AvatarName", frontPagePostLista.do0FrontPagePostsId);
            return View(frontPagePostLista);
        }

        // GET: AdmFrontPagePostListas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FrontPagePostLista frontPagePostLista = db.FrontPagePostLista.Find(id);
            if (frontPagePostLista == null)
            {
                return HttpNotFound();
            }
            return View(frontPagePostLista);
        }

        // POST: AdmFrontPagePostListas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FrontPagePostLista frontPagePostLista = db.FrontPagePostLista.Find(id);
            db.FrontPagePostLista.Remove(frontPagePostLista);
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
