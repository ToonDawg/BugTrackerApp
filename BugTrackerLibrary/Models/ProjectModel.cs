using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDeskLibrary.Models
{
    public class ProjectModel
    {
        public int id { get; set; }

        public string Name { get; set; }

        public List<TicketsModel> Tickets { get; set; }

        public List<UserModel> users { get; set; }

        public List<UserModel> admins { get; set; }
    }
}
