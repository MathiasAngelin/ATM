using System;

namespace Challange_1_SimpleATMSoftware
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello! Create your account! \nWhat is your desired creditcard number?");
            double ccNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your desired pin?");
            int ccPin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
           

            Console.Clear();

            Account myAccount = new Account(ccNum, ccPin, name);
            ATMMachine myATM = new ATMMachine();
            string nameformat = $"Logged in user: {myAccount.Name}";
            Console.WriteLine("Welcome to the ATM! Please login");
            while (myATM.Login(myAccount) == false) ;

            bool isrunning = true;
            while (isrunning)
            {
                Console.Clear();
                Console.WriteLine($"What do you want to do? {nameformat,50} \n1.Show balance \n2.Withdraw money \n3.Show 5 latest withdrawls \n4.Exit");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        myATM.ShowMoney(myAccount);
                        break;

                    case 2:
                        myATM.Withdraw(myAccount);
                        break;

                    case 3:
                        myATM.ShowLatest(myAccount);
                        break;

                    case 4:
                        isrunning = false;
                        break;
                }
            }
        }
    }
}