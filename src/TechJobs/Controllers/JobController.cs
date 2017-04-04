﻿using Microsoft.AspNetCore.Mvc;
using TechJobs.Data;
using TechJobs.ViewModels;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class JobController : Controller
    {

        // Our reference to the data store
        private static JobData jobData;

        static JobController()
        {
            jobData = JobData.GetInstance();
        }

        // The detail display for a given Job at URLs like /Job?id=17
        public IActionResult Index(int id)
        {
            // DONE #1 - get the Job with the given ID and pass it into the view
            
            Job singleJob = jobData.Find(id);
            return View(singleJob);
        }

        public IActionResult New()
        {
            NewJobViewModel newJobViewModel = new NewJobViewModel();
            return View(newJobViewModel);
        }

        [HttpPost]
        public IActionResult New(NewJobViewModel newJobViewModel)
        {
            // TODO #6 - Validate the ViewModel and if valid, create a 
            // new Job and add it to the JobData data store. Then
            // redirect to the Job detail (Index) action/view for the new Job.
            if (ModelState.IsValid)
            {
                Job newJob = new Job();
                newJob.Name = newJobViewModel.Name; // Because it is just a new string, nothing to compare to
                newJob.Employer = jobData.Employers.Find(newJobViewModel.EmployerID);
                newJob.Location = jobData.Locations.Find(newJobViewModel.LocationID);
                newJob.CoreCompetency = jobData.CoreCompetencies.Find(newJobViewModel.CoreCompetencyID);
                newJob.PositionType = jobData.PositionTypes.Find(newJobViewModel.PositionID);

                jobData.Jobs.Add(newJob);
                // TODO 8 - Make sure this version of this works once I finish making 7s work.
                //return RedirectToAction("Index", new { id = newJob.ID });
                return Redirect(string.Format("/Job?id={0}", newJob.ID)); 
            }
            else
            {
                return View(newJobViewModel);
            }
        }
    }
}
