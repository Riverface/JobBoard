using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace FriendLetter.Controllers
{
    public class JobController : Controller
    {

        [HttpGet("/jobs")]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewJob()
        {
            return View();
        }
        [HttpPost("/jobs/new")]
        public ActionResult CreateJob(string name, string company, string position)
        {
            JobOpening tempOpening = new JobOpening(name, company, position);
            return RedirectToAction("index");
        }
        [HttpPost("/jobs")]
        public ActionResult Board(){
        return View(JobOpening.GetAll());
        }
        [HttpGet("/jobs/{id}")]
        public ActionResult ShowJob(int id)
        {
            JobOpening foundOpening = JobOpening.GetOpeningByID(id);
            return View(foundOpening);
        }
    }
}