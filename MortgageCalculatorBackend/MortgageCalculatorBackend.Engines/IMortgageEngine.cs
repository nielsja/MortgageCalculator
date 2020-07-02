using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Engines
{
    public interface IMortgageEngine
    {
        public decimal CalculateMortgagePayment(
            decimal loanAmount, decimal downPayment, decimal interestRate, decimal loanPeriod);
    }
}
