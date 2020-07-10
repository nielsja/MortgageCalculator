using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MortgageCalculatorBackend.Common.Contracts;
using MortgageCalculatorBackend.Contracts.Client;
using MortgageCalculatorBackend.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MortgageCalculatorBackend.Client.Web.Controllers
{
    public class HouseController : Controller
    {
        private ManagerFactory CreateFactory()
        {
            var context = new AmbientContext();
            var managerFactory = new ManagerFactory(context);
            return managerFactory;
        }

        private IHouseManager CreateManager()
        {
            var managerFactory = CreateFactory();
            var manager = managerFactory.CreateManager<IHouseManager>();
            return manager;
        }

        public decimal CalculateMortgagePayment
            (decimal houseAmount, decimal downPayment, decimal annualInterestRate, decimal loanPeriod)
        {
            //Console.WriteLine("House Controller - CalculateMortgagePayment method reached");
            return CreateManager().CalculateMortgagePayment(houseAmount, downPayment, annualInterestRate, loanPeriod);
        }

        public decimal[] CalculateMultipleMortgagePayments
            (decimal downPayment, decimal annualInterestRate, decimal loanPeriod)
        {
            return CreateManager().CalculateMultipleMortgagePayments(downPayment, annualInterestRate, loanPeriod);
        }
    }
}
