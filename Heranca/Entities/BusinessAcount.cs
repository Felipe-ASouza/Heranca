﻿namespace Heranca.Entities
{
    public class BusinessAcount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAcount()
        {
        }

        public BusinessAcount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) //Loan = Emprestar
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
            
        }
    }
}