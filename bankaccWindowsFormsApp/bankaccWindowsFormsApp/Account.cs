using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccWindowsFormsApp
{
    class Account
    {
        public String customerName;
        public String accountNumber;
        public double balance = 0;

        public double Deposite(double amount)
        {
             balance = balance + amount;
            return balance;
        }

       public double withdraw(double amount)
        {
             balance = balance - amount;
            return balance;
        }
        public string Getinfo()
        {
            string info = "customer Name:"+customerName + "  " +"Account Number:"+accountNumber+ " " +
                "your balance is:"+balance;

            return info;
        }

    }
}
