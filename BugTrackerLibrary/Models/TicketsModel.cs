using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDeskLibrary.Models
{
    public class TicketsModel
    {
        public int id { get; set; }

        public string subject { get; set; }

        public string userEmail { get; set; }

        public string description { get; set; }

        public string catagory { get; set; }

        public List<string> details { get; set; }


        //start and end time
    }
}
