using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using a1topicos3.DAL;
using a1topicos3.Models;

namespace a1topicos3.Controllers
{
    public class CartoesController : Controller
    {
        private CarroContext db = new CarroContext();

        // GET: Cartoes
        public ActionResult Index()
        {
            return View(db.Cartoes.ToList());
        }

        // GET: Cartoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cartoes cartoes = db.Cartoes.Find(id);
            if (cartoes == null)
            {
                return HttpNotFound();
            }
            return View(cartoes);
        }

        // GET: Cartoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cartoes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,tipo_cartao,numero,cvc,validade")] Cartoes cartoes)
        {
            if (ModelState.IsValid)
            {
                db.Cartoes.Add(cartoes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cartoes);
        }

        // GET: Cartoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cartoes cartoes = db.Cartoes.Find(id);
            if (cartoes == null)
            {
                return HttpNotFound();
            }
            return View(cartoes);
        }

        // POST: Cartoes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,tipo_cartao,numero,cvc,validade")] Cartoes cartoes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cartoes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cartoes);
        }

        // GET: Cartoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cartoes cartoes = db.Cartoes.Find(id);
            if (cartoes == null)
            {
                return HttpNotFound();
            }
            return View(cartoes);
        }

        // POST: Cartoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cartoes cartoes = db.Cartoes.Find(id);
            db.Cartoes.Remove(cartoes);
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
