using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        public double AcctBal { get; set; }
        public double Deposit { get; set; }
        public int Withdraw { get; set; }
        public string AcctType { get; set; }
        public string AccountNum { get; set; }

        public virtual double GetWithdraw(double amount)
        {
            this.AcctBal = this.AcctBal - amount;
            return amount;
        }

        public double GetDeposit(double amount)
        {
            this.AcctBal = this.AcctBal + amount;
            return amount;
        }

        public double GetBalance()
        {
            return this.AcctBal;
        }
    }
}