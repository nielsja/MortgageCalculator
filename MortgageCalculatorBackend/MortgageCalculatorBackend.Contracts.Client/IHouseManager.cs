using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Contracts.Client
{
    public interface IHouseManager
    {
        public decimal CalculateMortgagePayment
            (decimal houseAmount, decimal downPayment, decimal annualInterestRate, decimal loanPeriod);

        public decimal[] CalculateMultipleMortgagePayments
            (decimal downPayment, decimal annualInterestRate, decimal loanPeriod);
    }
}
