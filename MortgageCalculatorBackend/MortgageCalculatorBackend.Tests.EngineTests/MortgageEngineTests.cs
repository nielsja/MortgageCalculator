using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculatorBackend.Accessors;
using MortgageCalculatorBackend.Common.Contracts;
using MortgageCalculatorBackend.Engines;
using MortgageCalculatorBackend.Utilities;

namespace MortgageCalculatorBackend.Tests.EngineTests
{
    [TestClass]
    public class MortgageEngineTests
    {
        private EngineFactory CreateFactory()
        {
            var context = new AmbientContext();
            var utilityFactory = new UtilityFactory(context);
            var accessorFactory = new AccessorFactory(context, utilityFactory);

            var engineFactory = new EngineFactory(context, accessorFactory, utilityFactory);
            return engineFactory;
        }

        private IMortgageEngine CreateEngine()
        {
            var engineFactory = CreateFactory();
            var engine = engineFactory.CreateEngine<IMortgageEngine>();
            return engine;
        }

        [TestMethod]
        public void CreateEngineTest()
        {
            var engine = CreateEngine();
            Assert.IsNotNull(engine);
        }

        [TestMethod]
        public void CalculateMortgagePayment_Test()
        {
            var engine = CreateEngine();
            var result = engine.CalculateMortgagePayment(100000, 10000, (decimal)0.12, 30);
            var expected = 254.54;

            Assert.AreEqual(Convert.ToDecimal(expected), Decimal.Round(result,2));
        }
    }
}
