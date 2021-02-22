using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_System
{
    class savings : Account
    {
        public savings(string name, string id, int balance)
            : base(name, id, balance)
        {
            Console.WriteLine("savings account created.");
        }

        new public void withdraw(int withdraw)
        {
            if (withdraw >= 430)
            {
                if (withdraw <= Balance)
                {
                    Balance = Balance - withdraw;
                    Console.WriteLine("Withdraw completed.");
                    Console.WriteLine("New Balance: " + Balance);
                }
                else
                    Console.WriteLine("Balance is less then" + withdraw);
            }
            else
                Console.WriteLine("Cannot withdraw!!! Less Than 430!!");
        }
    }
}
