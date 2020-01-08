using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModusCreateNewsFeed.Models.DB
{
    public class RepositoryContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "ModusCreate",
                Password = "ModusCreate"

            });

            modelBuilder.Entity<FeedCategory>().HasData(new FeedCategory
            {
                Id = 1,
                Description = "Sports"

            }, new FeedCategory
            {
                Id = 2,
                Description = "Entertainment"

            }, new FeedCategory
            {
                Id = 3,
                Description = "Politics"

            }, new FeedCategory
            {
                Id = 4,
                Description = "My feeds"

            });

            modelBuilder.Entity<Feed>().HasData(new Feed
            {
                Id = 1,
                Title = "SkySports",
                Description = "Follow us to keep up with the news on Football, Golf, Rugby, Cricket, Tennis, F1, Boxing and more from Sky Sports",
                URL = "https://www.skysports.com/rss/12040",
                FeedCategoryId = 1

            }, new Feed
            {
                Id = 2,
                Title = "Sporting News",
                Description = "The latest sports news, video, analysis, scores and better info. Covering the NFL, MLB, NBA, NHL, NASCAR, college football and basketball, soccer and more.",
                URL = "http://www.sportingnews.com/us/rss",
                FeedCategoryId = 1

            }, new Feed
            {
                Id = 3,
                Title = "Yardbarker",
                Description = "Realtime rumors, news and gossip from thousands of sports blogs ",
                URL = "https://www.yardbarker.com/rss/rumors",
                FeedCategoryId = 1
            }, new Feed
            {
                Id = 4,
                Title = "Heroic Hollywood",
                Description = "Covering the greatest heroes of the big and small screen ranging from comic book legends to iconic characters in cinema. ",
                URL = "https://heroichollywood.com/feed",
                FeedCategoryId = 2
            }, new Feed
            {
                Id = 5,
                Title = "Deadline",
                Description = "Deadline.com is always the first to break up-to-the-minute entertainment, Hollywood and media news, with an unfiltered, no-holds-barred analysis of events. The site is the go-to source for breaking news about the business of TV, film, media and other entertainment ",
                URL = "https://deadline.com/feed/",
                FeedCategoryId = 2
            }, new Feed
            {
                Id = 6,
                Title = "Black Hollywood",
                Description = "The Black Hollywood Education and Resource Center, a nonprofit, public benefit organization, is designed to advocate, educate, research, develop, and preserve the history, and the future, of blacks in the film and television industries.",
                URL = "https://bherc.org/feed",
                FeedCategoryId = 2
            }, new Feed
            {
                Id = 7,
                Title = "The New York Times",
                Description = "News, opinion and multimedia on politics and government.",
                URL = "https://rss.nytimes.com/services/xml/rss/nyt/Politics.xml",
                FeedCategoryId = 3
            }, new Feed
            {
                Id = 8,
                Title = "Los Angeles Times",
                Description = "Essential political coverage from California and the presidential campaign, including in-depth commentary, analysis and election results.",
                URL = "https://www.latimes.com/politics/rss2.0.xml",
                FeedCategoryId = 3
            });

            modelBuilder.Entity<Subcription>().HasData(new Subcription
            {
                Id = 1,
                UserId = 1,
                FeedId = 1

            }, new Subcription
            {
                Id = 2,
                UserId = 1,
                FeedId = 4
            }, new Subcription
            {
                Id = 3,
                UserId = 1,
                FeedId = 7
            });

        }

        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
            this.Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<FeedCategory> FeedCategories { get; set; }
        public DbSet<Feed> Feeds { get; set; }
        public DbSet<Subcription> Subcriptions { get; set; }
    
    }
}
