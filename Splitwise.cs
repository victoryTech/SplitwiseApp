using SplitwiseExpenseApp.Controller;
using SplitwiseExpenseApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp
{
    public class Splitwise
    {
        UserController userController;
        GroupController groupController;

        BalanceSheetController balanceSheetController;

        public Splitwise()
        {
            userController = new UserController();
            groupController = new GroupController();
            balanceSheetController = new BalanceSheetController();
        }

        public void demo()
        {
            setupUserAndGroup();

            //Step1: add members to the group
            Group group = groupController.getGroup("G1001");
            group.addMember(userController.getUser("U2001"));
            group.addMember(userController.getUser("U3001"));

            //Step2. create an expense inside a group
            List<Split> splits = new List<Split>();
            Split split1 = new Split(userController.getUser("U1001"), 300);
            Split split2 = new Split(userController.getUser("U2001"), 300);
            Split split3 = new Split(userController.getUser("U3001"), 300);
            splits.Add(split1);
            splits.Add(split2);
            splits.Add(split3);
            group.createExpense("Exp1001", "Breakfast", 900, splits, ExpenseSplitType.EQUAL, userController.getUser("U1001"));

            List<Split> splits2 = new List<Split>();
            Split splits2_1 = new Split(userController.getUser("U1001"), 400);
            Split splits2_2 = new Split(userController.getUser("U2001"), 100);
            splits2.Add(splits2_1);
            splits2.Add(splits2_2);
            group.createExpense("Exp1002", "Lunch", 500, splits2, ExpenseSplitType.UNEQUAL, userController.getUser("U2001"));

            foreach (User user in userController.getAllUsers())
            {
                balanceSheetController.showBalanceSheetOfUser(user);
            }
        }

        public void setupUserAndGroup()
        {
            // onboard user to splitwise app
            addUsersToSplitwiseApp();

            // create a group by user1
            User user1 = userController.getUser("U1001");
            groupController.createNewGroup("G1001", "Outing with Friends", user1);
        }

        public void addUsersToSplitwiseApp()
        {
            // adding user1
            User user1 = new User("U1001", "User1");

            // adding User2
            User user2 = new User("U2001", "User2");

            // adding User3
            User user3 = new User("U3001", "User3");

            userController.addUser(user1);
            userController.addUser(user2);
            userController.addUser(user3);
        }
    }
}
