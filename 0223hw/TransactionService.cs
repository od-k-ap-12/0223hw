using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0223hw
{
    class TransactionService:ITransactions
    {
        public void SendMoney(Customer c1, Customer c2)
        {
            Console.WriteLine("Enter PIN:");
            if (c1.pin == Console.ReadLine())
            {
                Console.WriteLine("Enter amount of money to send: ");
                int money = Convert.ToInt32(Console.ReadLine());
                if (c1.balance - money < 0)
                {
                    throw new Exception("Not enough money to take");
                }
                c1.balance = -money;
                c2.balance += money;
                Console.WriteLine("Transaction was successfull");
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }
    }
}
