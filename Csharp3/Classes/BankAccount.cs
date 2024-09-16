using Csharp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3.Classes
{
    public class BankAccount : IInformation
    {
        private double balance;
        public double Balance
        {
            get
            {
                if (balance < 1000000)
                {
                    return balance;
                }
                return 1000000;
            }

            protected set
            {
                if (value > 0)
                {
                    balance = value;
                } else
                {
                    balance = 0;
                }
            }
        }

        //overloading ctor
        public BankAccount()
        {
            Balance = 100;
        }

        
        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        } 

        // induk overrding
        public virtual double AddToBalance(double balanceToBeAdded)
        {
            Balance += balanceToBeAdded;
            return Balance;
        }

        public string GetInformation()
        {
            return $"$Your current balance is: {Balance:c}";
        }
    }

    //inheritance
    public class ChildBankAccount : BankAccount
    {
        public ChildBankAccount()
        {
            Balance = 10;
        }
        //overriding method
        public override double AddToBalance(double balanceToBeAdded)
        {
            if (balanceToBeAdded > 1000)
            {
                balanceToBeAdded = 1000;
            }
            if (balanceToBeAdded < -1000)
            {
                balanceToBeAdded = -1000;
            }
            return base.AddToBalance(balanceToBeAdded);
        }
    }
}
