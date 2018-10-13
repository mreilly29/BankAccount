using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Savings : Account
    {
        //properties
        public double MinBal { get; set; }

        //Constructors
        public Savings()
        {
            //default constructor
        }
        
        public override double GetWithdraw(double amount)
        {
            double temp = this.AcctBal - amount;
            if(temp <= MinBal)
            {
                Console.WriteLine("Savings account must have a minimum of ${0}", MinBal);
                return AcctBal;
            }
            AcctBal = temp;
            Console.WriteLine("Your current savings balance is {0}", AcctBal);
            return AcctBal;
        }
    }
}


