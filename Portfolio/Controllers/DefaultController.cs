using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    
    public class DefaultController : Controller
    {

        MyAcademyPortfolioProjectEntities db=new MyAcademyPortfolioProjectEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DefaultFeaturePartial()
        {
            var values=db.TblFeatures.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultAboutPartial()
        {
            var values =db.TblAbouts.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        //post işlemi yaptığıum için actionResult yazıyoruz bu önemli 
        public ActionResult SendMessage(TblMessages messages)
        {
            db.TblMessages.Add(messages);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public PartialViewResult DefaultServicePartial()
        {
            var values=db.TblServices.Where(x=>x.Status==true).ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultSkillPartial()
        {
            var values = db.TblSkills.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultProjectPartial()
        {
            var categories = db.TblCategories.ToList();
            ViewBag.categories = categories;

            var values = db.TblSkills.ToList();
            return PartialView(values);
        }

        public ActionResult DefaultExperiencePartial()
        {
            var values = db.TblExperiences.ToList();
            return PartialView(values);
        }

        public ActionResult DefaulTestimOnialPartial()
        {
            var values = db.TblTestimonials.ToList();
            return PartialView(values);
        }

        public ActionResult DefaultTeamPartial()
        {
            var values = db.TblTeams.ToList();
            return PartialView(values);
        }
    }
}