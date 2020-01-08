using ModusCreateNewsFeed.Models;
using ModusCreateNewsFeed.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModusCreateNewsFeed.Services
{
    public interface IFeedService
    {
        List<DAfeed> GetNews(User user, int feedCategoryId);

        List<DAcategory> GetCategories(User user);
        void unSubscribe(User user, int feedId);

        void Subscribe(User user, int feedId, string myfeed);
    }
}
