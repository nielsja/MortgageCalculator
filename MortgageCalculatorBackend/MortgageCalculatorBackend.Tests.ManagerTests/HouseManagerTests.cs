using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.TesthostProtocol;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculatorBackend.Accessors;
using MortgageCalculatorBackend.Common.Contracts;
using MortgageCalculatorBackend.Contracts.Client;
using MortgageCalculatorBackend.Engines;
using MortgageCalculatorBackend.Managers;
using MortgageCalculatorBackend.Managers.Shared;
using MortgageCalculatorBackend.Utilities;

namespace MortgageCalculatorBackend.Tests.ManagerTests
{
    [TestClass]
    public class HouseManagerTests
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

        [TestMethod]
        public void CreateManagerTest()
        {
            var manager = CreateManager();
            Assert.IsNotNull(manager);
        }

        [TestMethod]
        public void CalculateMortgagePayment_Test()
        {
            var manager = CreateManager();
            var result = manager.CalculateMortgagePayment(100000, 10000, (decimal)0.12, 30);
            var expected = 254.54;

            Assert.AreEqual(Convert.ToDecimal(expected), Decimal.Round(result, 2));
        }

        [TestMethod]
        public void CalculateMultipleMortgagePayments_Test()
        {
            var manager = CreateManager();
            var result = manager.CalculateMultipleMortgagePayments(1000, (decimal)0.12, 30);
            var expected = 3;

            Assert.AreEqual(expected, result.Length);
        }
    }
}
