using MortgageCalculatorBackend.Engines.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Engines
{
    class MortgageEngine : EngineBase, IMortgageEngine
    {
        public decimal CalculateMortgagePayment
            (decimal houseAmount, decimal downPayment, decimal annualInterestRate, decimal loanPeriod)
        {
            decimal loanAmount = houseAmount - downPayment;
            decimal monthlyInterestRate = (annualInterestRate / (decimal)100) / (decimal)12;
            decimal loanTermMonths = loanPeriod * (decimal)12;

            double numerator = (double)(loanAmount * monthlyInterestRate);
            double denominator = (double)1.0 / ((double)1.0 + (double)monthlyInterestRate);

            double monthlyPayment = numerator /
                (1.0 - Math.Pow((double)denominator, (double)loanTermMonths));

            return (decimal)monthlyPayment;
        }
    }
}
