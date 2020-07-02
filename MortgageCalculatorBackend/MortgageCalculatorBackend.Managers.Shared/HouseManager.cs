using MortgageCalculatorBackend.Contracts.Client;
using System;
using System.Collections.Generic;
using System.Text;
using MortgageCalculatorBackend.Managers.Shared;
using MortgageCalculatorBackend.Engines;

namespace MortgageCalculatorBackend.Managers.Shared
{
    public class HouseManager : ManagerBase, IHouseManager
    {
        public decimal CalculateMortgagePayment
            (decimal houseAmount, decimal downPayment, decimal annualInterestRate, decimal loanPeriod)
        {
            var engine = EngineFactory.CreateEngine<IMortgageEngine>();
            return engine.CalculateMortgagePayment(
                houseAmount, downPayment, annualInterestRate, loanPeriod);
        }

    }
}
