using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class TeamController : Controller
    {
        MyAcademyPortfolioProjectEntities db = new MyAcademyPortfolioProjectEntities();

        public ActionResult Index()
        {
            var values = db.TblTeams.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTeam(TblTeams teams)
        {
            db.TblTeams.Add(teams);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTeam(int id)
        {
            var team = db.TblTeams.Find(id);
            db.TblTeams.Remove(team);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTeam(int id)
        {
            var team = db.TblTeams.Find(id);
            return View(team);
        }

        [HttpPost]
        public ActionResult UpdateTeam(TblTeams teams)
        {
            var value = db.TblTeams.Find(teams.TeamId);
            value.ImageUrl = teams.ImageUrl;
            value.NameSurname = teams.NameSurname;
            value.Title = teams.Title;
            value.Description = teams.Description;
            value.TwitterUrl = teams.TwitterUrl;
            value.FacebookUrl = teams.FacebookUrl;
            value.Linkedin = teams.Linkedin;
            value.InstagramUrl = teams.InstagramUrl;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}