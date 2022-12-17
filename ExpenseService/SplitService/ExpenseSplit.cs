﻿using SplitwiseExpenseApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.ExpenseService.SplitService
{
    public interface ExpenseSplit
    {
        public void validateSplitRequest(List<Split> splitList, double totalAmount);
    }
}
