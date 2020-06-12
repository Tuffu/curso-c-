using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Heranca.Entities
{
    class BusinesAccount : Account // assim que se passa a herança para uma sub-classe
    {
        public double LoanLimit { get; set; }

        public BusinesAccount()
        {

        }

        public BusinesAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {

            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance = +LoanLimit;
            }
        }
    }
}
