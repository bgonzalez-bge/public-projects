using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModusCreateNewsFeed.Models;
using ModusCreateNewsFeed.Models.DB;
using ModusCreateNewsFeed.Services;
using Microsoft.AspNetCore.Http;

namespace ModusCreateNewsFeed.Controllers
{
    public class HomeController : Controller
    {
        private const string UserIdKey = "UserId";
        private const string UserNameKey = "UserName";

        private IFeedService feedService;
        private IAccountService accountService;

        public HomeController(IFeedService feedService, IAccountService accountService)
        {
            this.feedService = feedService;
            this.accountService = accountService;
        }

        public IActionResult Index(string searchString, int selectedCategoryId)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(UserNameKey)))
            {
                return View("Login");
            }

            User user = new User() { Id = Convert.ToInt32(HttpContext.Session.GetInt32(UserIdKey)) };

            var News = feedService.GetNews(user, selectedCategoryId);

            if (!String.IsNullOrEmpty(searchString))
            {
                News = News.Where(n => n.Title.ToUpper().Contains(searchString.Trim().ToUpper()) || n.Description.ToUpper().Contains(searchString.Trim().ToUpper())).ToList() ;
            }

            ViewBag.RSSFeed = News;
            ViewBag.Categories = feedService.GetCategories(user);
            ViewData["User"] = HttpContext.Session.GetString(UserNameKey);
            ViewBag.Search = searchString;
            ViewBag.selectedCategoryId = selectedCategoryId.ToString();
            return View();
        }

        public IActionResult About()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(UserNameKey)))
            {
                return View("Login");
            }

            return View();
        }

        public IActionResult Subscribe()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(UserNameKey)))
            {
                return View("Login");
            }

            User user = new User() { Id = Convert.ToInt32(HttpContext.Session.GetInt32(UserIdKey)) };

            ViewBag.User = HttpContext.Session.GetString(UserNameKey);
            ViewBag.Categories = feedService.GetCategories(user); ;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Delete(int Id)
        {
            User user = new User() { Id = Convert.ToInt32(HttpContext.Session.GetInt32(UserIdKey)) };

            feedService.unSubscribe(user, Id);
            return RedirectToAction("Subscribe");
        }

        public IActionResult Add(int Id, string feedURL)
        {
            User user = new User(){Id = Convert.ToInt32(HttpContext.Session.GetInt32(UserIdKey))};

            feedService.Subscribe(user, Id, feedURL);
            return RedirectToAction("Subscribe");
        }

        public IActionResult Login(string Username, string Password)
        {
            string Error = string.Empty;

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString(UserNameKey)))
            {
                HttpContext.Session.Clear();
                return View();
            }

            User user = accountService.validateUser(Username, Password);

            if(user != null)
            {
                HttpContext.Session.SetInt32(UserIdKey, user.Id);
                HttpContext.Session.SetString(UserNameKey, user.Name);
                return RedirectToAction("Index");
            }
            else if(!string.IsNullOrEmpty(Username))
            {
                Error = "The user is incorrect";
            }
            ViewBag.Error = Error;

            return View();
        }

        public IActionResult Register(string UserName, string Password, string ConfirmPassword)
        {
            string error = string.Empty;

            if(!String.IsNullOrEmpty(UserName))
            {
                error = accountService.createUser(UserName, Password, ConfirmPassword);

                if(string.IsNullOrEmpty(error))
                {
                    User user = accountService.validateUser(UserName, Password);

                    if (user != null)
                    {
                        HttpContext.Session.SetInt32(UserIdKey, user.Id);
                        HttpContext.Session.SetString(UserNameKey, user.Name);
                        return RedirectToAction("Index");
                    }
                }
            }
            ViewBag.Username = UserName;
            ViewBag.Password = Password;
            ViewBag.ConfirmPassword = ConfirmPassword;
            ViewBag.Error = error;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
