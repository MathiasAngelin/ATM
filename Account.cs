using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1_SimpleATMSoftware
{
    internal class Account
    {
        public double CreditCardNum { get; init; }
        public int Pin { get; private set; }
        public decimal Money { get; set; }
        public string Name { get; init; }
        public int transactionsToday = 0;
        public List<int> LatestTransactions = new List<int>();

        public Account(double creditCardNum, int pin, string name)
        {
            CreditCardNum = creditCardNum;
            Pin = pin;
            Money = 10000;
            Name = name;
        }
    }
}