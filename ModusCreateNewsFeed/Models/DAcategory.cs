using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModusCreateNewsFeed.Models
{
    public class DAcategory
    {
        public DAcategory()
        {
            this.feeds = new List<DAcategorySubItem>();
        }

        public string categoryName { get; set; }
        public string categoryId { get; set; }

        public List<DAcategorySubItem> feeds { get; set; }

    }

    public class DAcategorySubItem
    {
        public int UserId { get; set; }
        public int FeedId { get; set; }
        public string FeedTitle { get; set; }
        public string FeedDescription { get; set; }
        public Boolean subscribed { get; set; }
    }
}
