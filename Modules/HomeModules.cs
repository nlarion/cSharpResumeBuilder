using Nancy;
using Resume.Objects;
using System.Collections.Generic;
using Resume.Addresses;

namespace Resume
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Job> allJobs = Job.GetAll();
        if (allJobs.Count >=0)
        {
          return View["index.cshtml",allJobs];
        }
        else
        {
          return View["index.cshtml"];
        }
      };
      Get["/jobs"] = _ => {
        List<Job> allJobs = Job.GetAll();
        return View["jobs.cshtml", allJobs];
      };
      Get["/jobs/new"] = _ => {
        return View["resume_form.cshtml"];
      };
      Post["/"] = _ => {
        Address address  =  new Address(Request.Form["new-image"]);
        Job newJob = new Job(Request.Form["new-job"], Request.Form["new-description"],address);
        List<Job> allJobs = Job.GetAll();
        return View["index.cshtml", allJobs];
      };
      Get["/jobs/{id}"] = parameters => {
        Job job = Job.Find(parameters.id);
        return View["/job.cshtml", job];
      };
    }
  }
}
