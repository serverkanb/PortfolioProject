using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        MyAcademyPortfolioProjectEntities db = new MyAcademyPortfolioProjectEntities();

        public ActionResult Index()
        {
            var values = db.TblProjects.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProject()
        {
            var categories = db.TblCategories.ToList();

            List<SelectListItem> categorylist = (from x in categories select new SelectListItem()
            {
                Text=x.CategoryName,
                Value=x.CategoryId.ToString(),
                Selected=x.Equals(true)
               
                
            }).ToList();

            ViewBag.category = categorylist; 

            return View();
        }

        [HttpPost]
        public ActionResult AddProject(TblProjects projects)
        {
            var value = db.TblProjects.Add(projects);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProject(int id)
        {
            var project = db.TblProjects.Find(id);
            db.TblProjects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var categories = db.TblCategories.ToList();

            List<SelectListItem> categorylist = (from x in categories
                                                 select new SelectListItem()
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryId.ToString(),
                                                     Selected = x.Equals(true)


                                                 }).ToList();

            ViewBag.category = categorylist;

            return View();
        }
        [HttpPost]
        public ActionResult UpdateProject(TblProjects projects)
        {
            var value=db.TblProjects.Find(projects.ProjectId);
            value.ProjectName = projects.ProjectName;
            value.GithubUrl = projects.GithubUrl;
            value.ImageUrl = projects.ImageUrl;
            value.CategoryId = projects.CategoryId;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}