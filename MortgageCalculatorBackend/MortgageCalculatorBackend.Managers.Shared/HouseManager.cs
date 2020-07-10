using MortgageCalculatorBackend.Contracts.Client;
using System;
using System.Collections.Generic;
using System.Text;
using MortgageCalculatorBackend.Managers.Shared;
using MortgageCalculatorBackend.Engines;
using MortgageCalculatorBackend.Accessors;

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

        public decimal[] CalculateMultipleMortgagePayments
            (decimal downPayment, decimal annualInterestRate, decimal loanPeriod)
        {
            var accessor = AccessorFactory.CreateAccessor<IHouseAccessor>();
            var engine = EngineFactory.CreateEngine<IMortgageEngine>();
            var houseAmountList = accessor.HouseList();

            var result = new List<decimal>();
            foreach (var houseAmount in houseAmountList)
            {
                result.Add(engine.CalculateMortgagePayment(
                    houseAmount, downPayment, annualInterestRate, loanPeriod));
            }

            return result.ToArray();
        }

    }
}
