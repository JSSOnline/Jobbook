using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Jobbook.Models
{
    public class JobbookCompanyModel
    {
        public int ID { get; set; }
        public string JobbookCompanyName { get; set; }
        public string JobbookCompanyDescription { get; set; }
        public string JobbookCompanyWebsite { get; set; }
        public string JobbookCompanyEmail { get; set; }
        public string JobbookCompanyTel { get; set; }
    }
}
