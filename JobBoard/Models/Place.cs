using System.Collections.Generic;

namespace JobBoard.Models
{
    public class Job
    {
        public string Title{get; set;}
        public string Company{get; set;}
        public string Description{get; set;}
        public int Salary{get; set;}
        public string Address{get; set;}
        public string ContactInfo{get; set;}
        public int Id{get; set;}

        private static List<Job> _jobOffers = new List<Job>{}; 
        public Job(string title , string company , string description , int salary , string address , string contactInfo)
        {
            Title = title;
            Company = company;
            Description = description;
            Salary = salary;
            Address = address;
            ContactInfo = contactInfo;

            _jobOffers.Add(this);
            Id = _jobOffers.Count;
        }

        public static List<Job> GetAllJobs()
        {
            return _jobOffers;
        }

        public static void ClearJobs()
        {
            _jobOffers.Clear();
        }

        public static Job GetJob(int id)
        {
            return _jobOffers[id - 1];
        }
    }
}