using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        MyAcademyPortfolioProjectEntities db = new MyAcademyPortfolioProjectEntities();
        public ActionResult Index()
        {
            var values = db.TblServices.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddService(TblServices services)
        {
            db.TblServices.Add(services);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteService(int id)
        {
            var value = db.TblServices.Find(id);
            db.TblServices.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        

        public ActionResult MakeActive(int id)
        {
            var value = db.TblServices.Find(id);
            value.Status=true;
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public ActionResult MakePassive(int id)
        {
            var value =db.TblServices.Find(id);
            value.Status=false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ChageStatus(int id)
        {
            var value =db.TblServices.Find(id);
            if (value.Status == true)
            {
                value.Status=false;
            }
            else
            {
                value.Status = true;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}