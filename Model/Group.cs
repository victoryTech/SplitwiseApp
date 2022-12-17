using SplitwiseExpenseApp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.Model
{
    public class Group
    {
        string groupId;
        string groupName;
        List<User> groupMembers;

        List<Expense> expenseList;


        ExpenseController expenseController;

        public Group()
        {
            groupMembers = new List<User>();
            expenseList = new List<Expense>();
            expenseController = new ExpenseController();
        }

        //add member to group
        public void addMember(User member)
        {
            groupMembers.Add(member);
        }

        public String getGroupId()
        {
            return groupId;
        }

        public void setGroupId(String groupId)
        {
            this.groupId = groupId;
        }

        public void setGroupName(String groupName)
        {
            this.groupName = groupName;
        }

        public Expense createExpense(String expenseId, String description, double expenseAmount,
                                     List<Split> splitDetails, ExpenseSplitType splitType, User paidByUser)
        {

            Expense expense = expenseController.createExpense(expenseId, description, expenseAmount, splitDetails, splitType, paidByUser);
            expenseList.Add(expense);
            return expense;
        }

    }
}
