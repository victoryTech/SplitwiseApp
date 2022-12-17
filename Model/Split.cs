using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.Model
{
    public class Split
    {
        User user;
        double amountOwe;

        public Split(User user, double amountOwe)
        {
            this.user = user;
            this.amountOwe = amountOwe;
        }

        public User getUser()
        {
            return user;
        }

        public void setUser(User user)
        {
            this.user = user;
        }

        public double getAmountOwe()
        {
            return amountOwe;
        }

        public void setAmountOwe(double amountOwe)
        {
            this.amountOwe = amountOwe;
        }
    }
}
