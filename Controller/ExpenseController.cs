using SplitwiseExpenseApp.ExpenseService;
using SplitwiseExpenseApp.ExpenseService.SplitService;
using SplitwiseExpenseApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.Controller
{
    public class ExpenseController
    {
        BalanceSheetController balanceSheetController;
        public ExpenseController()
        {
            balanceSheetController = new BalanceSheetController();
        }

        public Expense createExpense(String expenseId, String description, double expenseAmount,
                                 List<Split> splitDetails, ExpenseSplitType splitType, User paidByUser)
        {

            ExpenseSplit expenseSplit = SplitFactory.getSplitObject(splitType);
            expenseSplit.validateSplitRequest(splitDetails, expenseAmount);

            Expense expense = new Expense(expenseId, expenseAmount, description, paidByUser, splitType, splitDetails);

            balanceSheetController.updateUserExpenseBalanceSheet(paidByUser, splitDetails, expenseAmount);

            return expense;
        }

    }
}
