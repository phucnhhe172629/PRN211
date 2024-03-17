using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public User GetUserByID(int userID) => UserDAO.Instance.GetUserByID(userID);

        public IEnumerable<User> GetUsers() => UserDAO.Instance.GetUserList();

        public void InsertUser(User user) => UserDAO.Instance.AddNew(user);

        public void DeleteUser(int userID) => UserDAO.Instance.Remove(userID);

        public void UpdateUser(User user) => UserDAO.Instance.Update(user);

        public User GetUserByAccount(string username, string password) => UserDAO.Instance.GetUserByAccount(username, password);
    }
}
