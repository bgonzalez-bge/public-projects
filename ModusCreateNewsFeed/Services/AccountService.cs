using ModusCreateNewsFeed.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModusCreateNewsFeed.Services
{
    public class AccountService : IAccountService
    {
        readonly RepositoryContext _repositoryContext;

        public AccountService(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public User validateUser(string Username, string Password)
        {
            return _repositoryContext.Users.Where(u => u.Name == Username && u.Password == Password).FirstOrDefault();

        }

        public string createUser(string Username, string Password, string ConfirmPassword)
        {
        
            if (Username.Length < 4)
                return "Username must have more than 4 characteres";

            if (Password.Length < 4)
                return "Password must have more than 4 characteres";

            if (!Password.Equals(ConfirmPassword))
                return "Passwords do not coincide";

            if (_repositoryContext.Users.Any(u => u.Name == Username))
                return "UserName already exists";

            User user = new User
            {
                Name = Username,
                Password = Password
            };

            _repositoryContext.Users.Add(user);
            _repositoryContext.SaveChanges();

            return string.Empty;

        }
    }
}
