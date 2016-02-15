using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Techleb.WebApi.Database;
using Techleb.WebApi.Models.Jobs;

namespace Techleb.WebApi.Controllers
{

    [RoutePrefix("/api/Jobs")]
    public class JobsController : ApiController
    {
        techlebEntities db;
        public JobsController()
        {
            db = new techlebEntities();
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<job> Get()
        {
            return db.jobs;
        }
        [HttpGet]
        [Route("{id:int}")]
        public job Get(int id)
        {
            return db.jobs.Find(id);
        }

        [Route("{id:int}")]
        [HttpDelete]
        public void Delete(int id)
        {
            job toDelete = db.jobs.Find(id);
            if (toDelete != null)
            {
                db.jobs.Remove(db.jobs.Find(id));
            }

        }

        [Route("")]
        [HttpPost]

        public void Create(jobAdd model)
        {
            db.jobs.Add(new job()
            {
                job_date = DateTime.UtcNow,
                job_description = model.job_description,
                job_title = model.job_title,
                location_id = model.location_id,
                phone_id = model.phone_id,
                profession_needed = model.profession_needed
            });
            db.SaveChanges();
        }

        [Route("{id:int}")]
        [HttpPost]
        public void Edit(int id, jobEdit model)
        {
            job toEdit = db.jobs.Find(id);


            toEdit.job_date = DateTime.UtcNow;
            toEdit.job_description = model.job_description;
            toEdit.job_title = model.job_title;
            toEdit.location_id = model.location_id;
            toEdit.phone_id = model.phone_id;
            toEdit.profession_needed = model.profession_needed;

            db.jobs.Attach(toEdit);
            db.SaveChanges();
        }
    }
}
