using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_labexer_1
{
    internal class CashierClass
    {
        private static int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;

        static CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }

        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }
}
