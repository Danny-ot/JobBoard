using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class JobsController : Controller
    {

        [HttpGet("/jobs")]
        public ActionResult Index()
        {
            List<Job> jobOffers = Job.GetAllJobs();
            return View(jobOffers);
        }

        [HttpGet("/jobs/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/jobs")]
        public ActionResult Create(string title , string company , string description , int salary , string address , string contactInfo)
        {
            Job job = new Job(title , company , description , salary , address , contactInfo);
            return RedirectToAction("Index");
        }

        [HttpGet("/jobs/{id}")]
        public ActionResult Show(int id)
        {
            Job speciJob = Job.GetJob(id);
            return View(speciJob);
        }
    }
}