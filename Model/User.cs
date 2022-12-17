using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.Model
{
    public class User
    {
        String userId;
        String userName;
        UserExpenseBalanceSheet userExpenseBalanceSheet;

        public User(String id, String userName)
        {
            this.userId = id;
            this.userName = userName;
            userExpenseBalanceSheet = new UserExpenseBalanceSheet();
        }
        public String getUserId()
        {
            return userId;
        }

        public UserExpenseBalanceSheet getUserExpenseBalanceSheet()
        {
            return userExpenseBalanceSheet;
        }
    }
}
