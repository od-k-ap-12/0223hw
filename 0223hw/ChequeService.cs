using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0223hw
{
    class ChequeService:IGetCheque
    {
        public void PrintCheque()
        {
            Console.WriteLine("Cheque Print");
        }

        public void EmailCheque()
        {
            Console.WriteLine("Enter your email: ");
            Console.WriteLine("Your cheque has been sent to " + Console.Read());
        }

        public void SMSCheque()
        {
            Console.WriteLine("Your cheque has been sent");
        }
    }
}
