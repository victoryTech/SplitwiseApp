using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.Model
{
    public class Balance
    {
        double amountOwe;
        double amountGetBack;

        public double getAmountOwe()
        {
            return amountOwe;
        }

        public void setAmountOwe(double amountOwe)
        {
            this.amountOwe = amountOwe;
        }

        public double getAmountGetBack()
        {
            return amountGetBack;
        }

        public void setAmountGetBack(double amountGetBack)
        {
            this.amountGetBack = amountGetBack;
        }
    }
}
