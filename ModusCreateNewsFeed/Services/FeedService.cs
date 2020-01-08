using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;
using ModusCreateNewsFeed.Models;
using ModusCreateNewsFeed.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace ModusCreateNewsFeed.Services
{
    public class FeedService : IFeedService
    {
        readonly RepositoryContext _repositoryContext;

        public FeedService(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        

        public List<DAfeed> GetNews(User user, int feedCategoryId)
        {

            List<DAfeed> DAfeeds = new List<DAfeed>();

            var subscriptions = _repositoryContext.Subcriptions.Where(s => s.UserId == user.Id).Select(s => s.Feed);
            subscriptions = subscriptions.Where(s => s.UserId == null || s.UserId == user.Id);

            if (feedCategoryId > 0)
            {
                subscriptions = subscriptions.Where(s => s.FeedCategoryId == feedCategoryId);
            }

            foreach (Feed feed in subscriptions)
            {
                try
                {
                    string feedURL = feed.URL;
                    WebClient webclient = new WebClient();
                    string RSSData = webclient.DownloadString(feedURL);

                    XDocument xml = XDocument.Parse(RSSData);
                    DAfeeds.AddRange((from x in xml.Descendants("item")
                                           select new DAfeed
                                           {
                                               Title = ((string)x.Element("title")),
                                               URL = ((string)x.Element("link")),
                                               Description = ((string)x.Element("description")),
                                               Date = ((DateTime)x.Element("pubDate"))
                                           }).ToList()) ;
                }
                catch
                {

                }
            }

            return DAfeeds.OrderByDescending(fd => fd.Date).ToList() ;

        }


        public List<DAcategory> GetCategories(User user)
        {
            List<DAcategory> categories = new List<DAcategory>();

            var subscriptions = _repositoryContext.Subcriptions.Where(s => s.UserId == user.Id);

            var FeedCategories = _repositoryContext.FeedCategories.Include(c => c.Feeds);

            foreach(FeedCategory feedCategory in FeedCategories)
            {
                DAcategory category = new DAcategory();
                category.categoryName = feedCategory.Description;
                category.categoryId = feedCategory.Id.ToString();

                foreach (Feed feed in feedCategory.Feeds.Where(s => s.UserId == null || s.UserId == user.Id))
                {
                    category.feeds.Add(new DAcategorySubItem
                    {
                        FeedId = feed.Id,
                        FeedTitle = feed.Title,
                        FeedDescription = feed.Description,
                        subscribed = subscriptions.Any(s => s.FeedId == feed.Id)
                });
                }

                categories.Add(category);

            }

            return categories;
        }

        public void unSubscribe(User user, int feedId)
        {
            Subcription subcription = _repositoryContext.Subcriptions.Where(s => s.UserId == user.Id && s.FeedId == feedId).FirstOrDefault();
            _repositoryContext.Subcriptions.Remove(subcription);
            _repositoryContext.SaveChanges();
        }

        public void Subscribe(User user, int feedId, string myfeed)
        {
            if (!string.IsNullOrEmpty(myfeed))
            {
                Feed feed = new Feed
                {
                    Title = "My feed",
                    Description = myfeed,
                    URL = myfeed,
                    UserId = user.Id,
                    FeedCategoryId = _repositoryContext.FeedCategories.Where(c => c.Description == "My feeds").FirstOrDefault().Id
                };
                _repositoryContext.Feeds.Add(feed);
                _repositoryContext.SaveChanges();
                feedId = feed.Id;
            }

            Subcription subcription = new Subcription
            {
                UserId = user.Id,
                FeedId = feedId
            };
            _repositoryContext.Subcriptions.Add(subcription);
            _repositoryContext.SaveChanges();
        }
    }
}
