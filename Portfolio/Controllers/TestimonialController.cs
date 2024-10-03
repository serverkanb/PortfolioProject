using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        MyAcademyPortfolioProjectEntities db = new MyAcademyPortfolioProjectEntities();
        public ActionResult Index()
        {
            var values = db.TblTestimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddTestimOnial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTestimOnial(TblTestimonials testimonials)
        {
            db.TblTestimonials.Add(testimonials);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimOnial(int id)
        {
            var value = db.TblTestimonials.Find(id);
            db.TblTestimonials.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimOnial(int id)
        {
            var testimonial = db.TblTestimonials.Find(id);
            return View(testimonial);
        }
        [HttpPost]
        public ActionResult UpdateTestimOnial(TblTestimonials testimonials)
        {
            var value = db.TblTestimonials.Find(testimonials.TestimonialId);
            value.TestimonialId = testimonials.TestimonialId;
            value.Title = testimonials.Title;
            value.Comment = testimonials.Comment;
            value.CommentDate =  testimonials.CommentDate;
            value.ImageUrl = testimonials.ImageUrl;
            value.NameSurname = testimonials.NameSurname;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MakeActive(int id)
        {
            var value = db.TblTestimonials.Find(id);
            value.Status = true;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult MakePassive(int id)
        {
            var value = db.TblTestimonials.Find(id);
            value.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ChageStatus(int id)
        {
            var value = db.TblTestimonials.Find(id);
            if (value.Status == true)
            {
                value.Status = false;
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