using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0223hw
{
    class ATM
    {
        public string location { get; set; }
        public ATM(string _location)
        {
            location = _location;
        }

        public void SendMoney(Customer c1, Customer c2,ITransactions IT)
        {
            IT.SendMoney(c1, c2);
        }

        public void Withdraw(Customer c,IMoney IM)
        {
            IM.Withdraw(c);
        }
        public void Add(Customer c,IMoney IM)
        {
            IM.Add(c);
        }
        public void ReceiveCheque(IGetCheque IGC)
        {
            Console.WriteLine("1.Receive the cheque by email \n2.By SMS \n3.Print it");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    IGC.EmailCheque();
                    break;
                case 2:
                    IGC.SMSCheque();
                    break;
                case 3:
                    IGC.PrintCheque();
                    break;
                default:
                    break;
            }
        }
    }
}
