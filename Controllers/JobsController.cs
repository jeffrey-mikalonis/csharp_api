using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using td_interview_api.Interfaces;
using td_interview_api.Entities;

namespace td_interview_api.Controllers
{
    [ApiController]
    [Route("job")]
    public class JobsController : ControllerBase
    {
        private IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public IEnumerable<Job> Get()
        {
            return _jobService.Get();
        }
    }
}
