using SplitwiseExpenseApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.ExpenseService.SplitService
{
    public class EqualExpenseSplit : ExpenseSplit
    {
        public void validateSplitRequest(List<Split> splitList, double totalAmount)
        {
            // validate total amount in splits of each user in equal and overall equals to totalAmount or not
            double amountShouldBePresent = totalAmount / splitList.Count;
            foreach(Split split in splitList)
            {
                if(split.getAmountOwe() != amountShouldBePresent)
                {
                    // throw exception
                }
            }
        }
    }
}
