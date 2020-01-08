using ModusCreateNewsFeed.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModusCreateNewsFeed.Services
{
    public interface IAccountService
    {
        User validateUser(string Username, string Password);
        string createUser(string Username, string Password, string ConfirmPassword);
    }
}
