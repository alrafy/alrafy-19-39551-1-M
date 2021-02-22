using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Abir", "1234", 20000);
            a1.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a1.Transfer(200, a1);
            Console.WriteLine("******************************");
            Account a2 = new Account("Sabir", "5678", 5000);
            a2.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a2.Transfer(200, a1);
            Console.WriteLine("******************************");
            savings s1 = new savings("Joy", "1111", 1500);
            s1.ShowInfo();
            s1.withdraw(500);
            Console.WriteLine("******************************");
            Special_current s2 = new Special_current("Shuvo", "2222", 15500);
            s2.ShowInfo();
            s2.withdraw(3000);
            Console.WriteLine("******************************");
            Fixed f1 = new Fixed("Tonoy", "4444", 10000);
            f1.ShowInfo();
            f1.withdraw(3000);
            Console.WriteLine();
            Console.WriteLine("******************************");
            Overdraft o = new Overdraft("NIloy", "9999", 10000);
            o.ShowInfo();
            o.withdraw(200);
            Console.WriteLine();

        }
    }
}
