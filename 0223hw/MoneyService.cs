using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0223hw
{
    class MoneyService:IMoney
    {
        public void Withdraw(Customer c)
        {
            Console.WriteLine("Enter PIN:");
            if (c.pin == Console.ReadLine())
            {
                Console.WriteLine("Enter amount of money to withdraw: ");
                int money = Convert.ToInt32(Console.ReadLine());
                if (c.balance - money < 0)
                {
                    throw new Exception("Not enough money to take");
                }
                else
                {
                    c.balance = -money;
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }
        public void Add(Customer c)
        {
            Console.WriteLine("Enter PIN:");
            if (c.pin == Console.ReadLine())
            {
                Console.WriteLine("Enter amount of money to add: ");
                c.balance = +Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }
    }
}
