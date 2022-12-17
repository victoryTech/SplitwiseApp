using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.Model
{
    public class Expense
    {
        string expenseId;
        string description;
        double expenseAmount;
        User paidByUser;
        ExpenseSplitType splitType;
        List<Split> splitDetails = new List<Split>();

        public Expense(string expenseId, double expenseAmount, string description,
                   User paidByUser, ExpenseSplitType splitType, List<Split> splitDetails)
        {
            this.expenseId = expenseId;
            this.expenseAmount = expenseAmount;
            this.description = description;
            this.paidByUser = paidByUser;
            this.splitType = splitType;
            this.splitDetails.AddRange(splitDetails);
        }

    }
}
