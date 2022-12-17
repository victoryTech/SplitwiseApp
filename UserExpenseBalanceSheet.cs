using SplitwiseExpenseApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp
{
    public class UserExpenseBalanceSheet
    {
        Dictionary<string, Balance> userVsBalance;
        double totalYourExpense;

        double totalPayment;

        double totalYouOwe;
        double totalYouGetBack;
        public UserExpenseBalanceSheet ()
        {
            userVsBalance = new Dictionary<string, Balance>();
            totalYourExpense = 0;
            totalYourExpense = 0;
            totalYouOwe = 0;
            totalYouGetBack = 0;
        }

        public Dictionary<string, Balance> getUserVsBalance()
        {
            return userVsBalance;
        }

        public double getTotalYourExpense()
        {
            return totalYourExpense;
        }

        public void setTotalYourExpense(double totalYourExpense)
        {
            this.totalYourExpense = totalYourExpense;
        }

        public double getTotalYouOwe()
        {
            return totalYouOwe;
        }

        public void setTotalYouOwe(double totalYouOwe)
        {
            this.totalYouOwe = totalYouOwe;
        }

        public double getTotalYouGetBack()
        {
            return totalYouGetBack;
        }

        public void setTotalYouGetBack(double totalYouGetBack)
        {
            this.totalYouGetBack = totalYouGetBack;
        }

        public double getTotalPayment()
        {
            return totalPayment;
        }

        public void setTotalPayment(double totalPayment)
        {
            this.totalPayment = totalPayment;
        }
    }
}
