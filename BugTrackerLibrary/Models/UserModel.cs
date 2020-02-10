using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDeskLibrary.Models
{
    public class UserModel
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public List<ProjectModel> currentProjects { get; set; }

        public List<TicketsModel> tickets { get; set; }
    }
}

/*Creating a SQL connection
    1. Create a healper class that returns the configuration string
    2. Create a connection string in App.config
     
     
     */
