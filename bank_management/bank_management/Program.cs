using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_System
{
    class Account
    {
        string accName;
        string acid;
        int balance;
        int amount;
        Account acc;


        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }
        public string Acid
        {
            set { acid = value; }
            get { return acid; }
        }
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public int Amount
        {
            set { amount = value; }
            get { return amount; }
        }

        public Account Acc
        {
            set { acc = value; }
            get { return acc; }
        }

        public Account()
        {
            Console.WriteLine("Account Created with default.");
        }

        public Account(string accName, string acid, int balance)
        {
            Console.WriteLine("Account Created with 3 parameters.");
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public void deposit(int amount)
        {
            if (balance > 0)
            {
                balance = balance + amount;
                Console.WriteLine("After Diposite: " + balance);
            }
            else
            {
                Console.WriteLine("Not Diposited.");
            }

        }

        public void withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance = balance - amount;
                Console.WriteLine("After Withdraw: " + balance);
            }
            else
            {
                Console.WriteLine("Can not withdraw.");
            }
        }

        public void Transfer(int amount, Account acc)
        {
            if (amount > 0 && amount <= balance)
            {


                Console.WriteLine("Transfer amount:" + amount);
                balance = balance - amount;
                Console.WriteLine("After Transfer Balance:" + this.balance);
                balance = balance + amount;
                Console.WriteLine("Recieve amount:" + amount);

            }
            else
                Console.WriteLine("Amount Exceeded");
        }




        public void ShowInfo()
        {
            Console.WriteLine("Account Name is: " + accName);
            Console.WriteLine("ID is: " + acid);
            Console.WriteLine("Balance is: " + balance);
        }
    }
}

