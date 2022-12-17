using SplitwiseExpenseApp.ExpenseService.SplitService;
using SplitwiseExpenseApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.ExpenseService
{
    public class SplitFactory
    {
        public static ExpenseSplit getSplitObject(ExpenseSplitType splitType)
        {
            switch (splitType)
            {
                case ExpenseSplitType.EQUAL:
                    return new EqualExpenseSplit();
                case ExpenseSplitType.UNEQUAL:
                    return new UnequalExpenseSplit();
                case ExpenseSplitType.PERCENTAGE:
                    return new PercentageExpenseSplit();
                default:
                    return null;

            }
        }
    }
}
