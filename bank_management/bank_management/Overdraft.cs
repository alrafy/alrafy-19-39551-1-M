using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_System
{
    class Overdraft : Account
    {
        public Overdraft(string name, string id, int balance)
        {
            Console.WriteLine("Overdraft created.");
        }
        new public void withdraw(int withdraw)
        {
            if (withdraw > Balance)
            {
                int overdraft = Balance * 5000;
                Balance = Balance + overdraft;

                if (withdraw <= Balance)
                {
                    Balance = Balance - withdraw;
                    Console.WriteLine("Transaction Executed!!!");
                    Console.WriteLine(overdraft);
                }
                else
                    Console.WriteLine("Sorry transaction can't be completed because its exceed the limits of loan");
            }
            else
                Balance = Balance - withdraw;
            Console.WriteLine("New Balance : " + Balance);
        }
    }
}
