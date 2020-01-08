using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModusCreateNewsFeed.Models
{
    public class DAfeed
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
