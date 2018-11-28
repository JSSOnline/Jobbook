using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Jobbook.Models;

namespace Jobbook.Models
{
    public class JobbookContext : DbContext
    {
        public JobbookContext (DbContextOptions<JobbookContext> options)
            : base(options)
        {
        }

        public DbSet<Jobbook.Models.JobbookVacatureModel> JobbookVacatureModel { get; set; }

        public DbSet<Jobbook.Models.JobbookProfileModel> JobbookProfileModel { get; set; }

        public DbSet<Jobbook.Models.JobbookCompanyModel> JobbookCompanyModel { get; set; }
    }
}
