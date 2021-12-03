using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Challange_1_SimpleATMSoftware
{
    internal class ATMMachine
    {
        public void ShowMoney(Account myacc)
        {
            Console.WriteLine($"You have {myacc.Money} dollars on your account!");
            Console.WriteLine("Press a key to continute...");
            Console.ReadKey(true);
        }

        public bool Login(Account myacc)
        {
            Console.WriteLine($"Enter your Creditcard number");
            double CCInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter your Pin number");
            int pinInput = Convert.ToInt32(Console.ReadLine());

            if (CCInput == myacc.CreditCardNum && pinInput == myacc.Pin)
                return true;
            else
            {
                Console.WriteLine("Wrong Cardnumber or Pin..");
                return false;
            }
        }

        public void Withdraw(Account myacc)
        {
            Console.WriteLine($"How much would you like to withdraw? - Limit to 1000 per withdrawl and {10 - myacc.transactionsToday} left today");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            if (withdrawAmount <= myacc.Money && withdrawAmount < 1000 && myacc.transactionsToday < 10)
            {
                myacc.Money -= withdrawAmount;
                myacc.transactionsToday++;
                CheckIfMoreThan5(myacc);
                myacc.LatestTransactions.Add(withdrawAmount);
                Console.WriteLine("Done, here's your money");
            }
            else
            {
                Console.WriteLine("You either tried to take out to much, or you have reached your daily limit ");
            }
            Console.WriteLine("Press a key to continute...");
            Console.ReadKey(true);
        }

        public void ShowLatest(Account myacc)
        {
            Console.WriteLine("These are your 5 last withdrawls");
            foreach (var item in myacc.LatestTransactions)
            {
                Console.WriteLine($"You withdrew: {item} dollars");
            }
            Console.WriteLine("Press a key to continute...");
            Console.ReadKey(true);
        }

        public void CheckIfMoreThan5(Account myacc)
        {
            if(myacc.LatestTransactions.Count > 4)
            {
                myacc.LatestTransactions.RemoveAt(0);
            }
        }
    }
}