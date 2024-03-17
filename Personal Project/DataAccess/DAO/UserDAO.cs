using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.DAO
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public User GetUserByAccount(string username, string password)
        {
            User user = null;
            try
            {
                using var context = new PRNProjectContext();
                user = context.Users.SingleOrDefault(c => c.Username.Equals(username) && c.Password.Equals(password));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        public IEnumerable<User> GetUserList()
        {
            var users = new List<User>();
            try
            {
                using var context = new PRNProjectContext();
                users = context.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return users;
        }

        public User GetUserByID(int userID)
        {
            User user = null;
            try
            {
                using var context = new PRNProjectContext();
                user = context.Users.SingleOrDefault(c => c.UserId == userID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        // Add new a User
        public void AddNew(User user)
        {
            try
            {
                User _user = GetUserByID(user.UserId);
                if (_user == null)
                {
                    using var context = new PRNProjectContext();
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The User is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Update a User
        public void Update(User user)
        {
            try
            {
                User _user = GetUserByID(user.UserId);
                if (_user != null)
                {
                    using var context = new PRNProjectContext();
                    context.Users.Update(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The User does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Remove a User
        public void Remove(int userID)
        {
            try
            {
                User user = GetUserByID(userID);
                if (user != null)
                {
                    using var context = new PRNProjectContext();
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The User does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
