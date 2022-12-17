using SplitwiseExpenseApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.Controller
{
    public class UserController
    {
        List<User> userList;

        public UserController()
        {
            userList = new List<User>();
        }

        // Add User
        public void addUser(User user)
        {
            userList.Add(user);
        }

        // Get User
        public User getUser(string userId)
        {
            foreach(User user in userList)
            {
                if (user.getUserId().Equals(userId))
                    return user;
            }
            return null;
        }

        // Get List of User
        public List<User> getAllUsers()
        {
            return userList;
        }
    }
}