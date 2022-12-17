using SplitwiseExpenseApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.Controller
{
    public class BalanceSheetController
    {
        public void updateUserExpenseBalanceSheet(User expensePaidBy, List<Split> splits, double totalExpenseAmount)
        {
            // update the total amount paid of the expense paid by user
            UserExpenseBalanceSheet paidByUserExpenseSheet = expensePaidBy.getUserExpenseBalanceSheet();
            paidByUserExpenseSheet.setTotalPayment(paidByUserExpenseSheet.getTotalPayment() + totalExpenseAmount);

            foreach(Split split in splits)
            {
                User userOwe = split.getUser();
                UserExpenseBalanceSheet oweUserExpenseSheet = userOwe.getUserExpenseBalanceSheet();
                double oweAmount = split.getAmountOwe();

                if (expensePaidBy.getUserId().Equals(userOwe.getUserId()))
                {
                    paidByUserExpenseSheet.setTotalYourExpense(paidByUserExpenseSheet.getTotalYourExpense() + oweAmount);
                }
                else
                {

                    //update the balance of paid user
                    paidByUserExpenseSheet.setTotalYouGetBack(paidByUserExpenseSheet.getTotalYouGetBack() + oweAmount);

                    Balance userOweBalance;
                    if (paidByUserExpenseSheet.getUserVsBalance().ContainsKey(userOwe.getUserId()))
                    {
                        // yeh line?
                        userOweBalance = paidByUserExpenseSheet.getUserVsBalance().GetValueOrDefault((userOwe.getUserId()));
                    }
                    else
                    {
                        userOweBalance = new Balance();
                        // yeh line?
                        paidByUserExpenseSheet.getUserVsBalance().Add(userOwe.getUserId(), userOweBalance);
                    }

                    userOweBalance.setAmountGetBack(userOweBalance.getAmountGetBack() + oweAmount);


                    //update the balance sheet of owe user
                    oweUserExpenseSheet.setTotalYouOwe(oweUserExpenseSheet.getTotalYouOwe() + oweAmount);
                    oweUserExpenseSheet.setTotalYourExpense(oweUserExpenseSheet.getTotalYourExpense() + oweAmount);

                    Balance userPaidBalance;
                    if (oweUserExpenseSheet.getUserVsBalance().ContainsKey(expensePaidBy.getUserId()))
                    {
                        userPaidBalance = oweUserExpenseSheet.getUserVsBalance().GetValueOrDefault(expensePaidBy.getUserId());
                    }
                    else
                    {
                        userPaidBalance = new Balance();
                        oweUserExpenseSheet.getUserVsBalance().Add(expensePaidBy.getUserId(), userPaidBalance);
                    }
                    userPaidBalance.setAmountOwe(userPaidBalance.getAmountOwe() + oweAmount);
                }
            }
        }


        public void showBalanceSheetOfUser(User user)
        {

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Balance sheet of user : " + user.getUserId());

            UserExpenseBalanceSheet userExpenseBalanceSheet = user.getUserExpenseBalanceSheet();

            Console.WriteLine("TotalYourExpense: " + userExpenseBalanceSheet.getTotalYourExpense());
            Console.WriteLine("TotalGetBack: " + userExpenseBalanceSheet.getTotalYouGetBack());
            Console.WriteLine("TotalYourOwe: " + userExpenseBalanceSheet.getTotalYouOwe());
            Console.WriteLine("TotalPaymnetMade: " + userExpenseBalanceSheet.getTotalPayment());

            foreach(var entry in userExpenseBalanceSheet.getUserVsBalance())
            {
                string userID = entry.Key;
                Balance balance = entry.Value;

                Console.WriteLine("userID:" + userID + " YouGetBack:" + balance.getAmountGetBack() + " YouOwe:" + balance.getAmountOwe());
            }

            Console.WriteLine("---------------------------------------");

        }
    }
}

