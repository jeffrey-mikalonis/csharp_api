using System.Collections.Generic;
using td_interview_api.Entities;
using td_interview_api.Interfaces;

namespace td_interview_api.Services
{
    public class JobService : IJobService {
        public JobService() {

        }

        public IEnumerable<Job> Get(){
            return new List<Job>() {
                new Job() {
                    Name = "Senior Software Engineer"
                },
                new Job() {
                    Name = "Software Engineer"
                },
                new Job() {
                    Name = "Support Engineer"
                }
            };
        }
    }
}