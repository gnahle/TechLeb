using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Techleb.WebApi.Models.Jobs
{
    public class jobEdit
    {
        public int phone_id { get; set; }
        public int location_id { get; set; }
        public string job_title { get; set; }
        public string profession_needed { get; set; }
        public string job_description { get; set; }
    }
}