using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }


        public BankAccount(string Num, string Hol, double Bal)
        {
            if (Num == null || Hol == null)
            {
                Num = "Unknown";
                Hol = "Unknown";
            }
            if (Bal < 0)
            {
                Bal = 0.0;
            }
            this.AccountNumber = Num;
            this.AccountHolder = Hol;
            this.Balance = Bal;
            
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.Balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if ((this.Balance - amount) > 0 && amount > 0)
            {
                this.Balance -= amount;
            }
        }
        public double GetBalance() { return this.Balance; }
    }

}
