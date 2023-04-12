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
    public class CarteiraMotoristaController : Controller
    {
        private CarroContext db = new CarroContext();

        // GET: CarteiraMotorista
        public ActionResult Index()
        {
            return View(db.carteiraMotoristas.ToList());
        }

        // GET: CarteiraMotorista/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarteiraMotorista carteiraMotorista = db.carteiraMotoristas.Find(id);
            if (carteiraMotorista == null)
            {
                return HttpNotFound();
            }
            return View(carteiraMotorista);
        }

        // GET: CarteiraMotorista/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarteiraMotorista/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,validade,numero_registro")] CarteiraMotorista carteiraMotorista)
        {
            if (ModelState.IsValid)
            {
                db.carteiraMotoristas.Add(carteiraMotorista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carteiraMotorista);
        }

        // GET: CarteiraMotorista/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarteiraMotorista carteiraMotorista = db.carteiraMotoristas.Find(id);
            if (carteiraMotorista == null)
            {
                return HttpNotFound();
            }
            return View(carteiraMotorista);
        }

        // POST: CarteiraMotorista/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,validade,numero_registro")] CarteiraMotorista carteiraMotorista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carteiraMotorista).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carteiraMotorista);
        }

        // GET: CarteiraMotorista/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarteiraMotorista carteiraMotorista = db.carteiraMotoristas.Find(id);
            if (carteiraMotorista == null)
            {
                return HttpNotFound();
            }
            return View(carteiraMotorista);
        }

        // POST: CarteiraMotorista/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarteiraMotorista carteiraMotorista = db.carteiraMotoristas.Find(id);
            db.carteiraMotoristas.Remove(carteiraMotorista);
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
