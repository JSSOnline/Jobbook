using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobbook.Models
{
    public class JobbookProfileModel
    {
        public int ID { get; set; }
        public string JobbookProfileFirstName { get; set; }
        public string JobbookProfileLastName { get; set; }
        public string JobbookProfileOpen { get; set; }
        public string JobbookProfileTitle { get; set; }
        public string JobbookProfileDescription { get; set; }
        public string JobbookProfilePosts { get; set; }
        public string JobbookProfileWork { get; set; }
        public string JobbookProfileEducation { get; set; }
    }
}
