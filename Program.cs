using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookkeep
{
    static class Anaccount
    {
        public static string Time(string time)
        {
            time = Console.ReadLine();
            return time;
        }
        public static string Money(int money)
        {
            money = int.Parse(Console.ReadLine());
            return money;
        }
        public static string Classification(string classification)
        {
            classification = Console.ReadLine();
            return classification;
        }
        public static string Paymentmethod(string paymentmethod)
        {
            paymentmethod = Console.ReadLine();
            return paymentmethod;
        }
        public static string Remark(string Remark)
        {
            Remark = Console.ReadLine();
            return Remark;
        }
    }
}

