using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao.Entities
{
    class SavingAccount : Account // sealed impede que essa classe seja herdada
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {

        }

        public SavingAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) // colocando o sealed, eu digo que essa método não pode ser sobescrito em outra classe
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
