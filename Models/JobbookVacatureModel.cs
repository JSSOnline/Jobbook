using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Jobbook.Models
{
    public class JobbookVacatureModel
    {
        public int ID { get; set; }
        public int JobCompanyID { get; set; }
        public DateTime JobPublished { get; set; }
        public DateTime JobExpiredDate { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string JobLocation { get; set; }
        public string JobContractType { get; set; }
        public int JobContractHours { get; set; }
        public string JobSeniority { get; set; }
        public int JobSalary { get; set; }
        public int JobDaysOff { get; set; }
        public bool JobExpired { get; set; }
        public string JobContactEmail { get; set; }
        public int JobContactTel { get; set; }
    }
   
}
