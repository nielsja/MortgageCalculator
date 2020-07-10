using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MortgageCalculatorBackend.Accessors;
using MortgageCalculatorBackend.Common.Contracts;
using MortgageCalculatorBackend.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Tests.AccessorTests
{
    [TestClass]
    public class HouseAccessorTests
    {
        AmbientContext _context = new AmbientContext();

        private UtilityFactory CreateUtilityFactory()
        {
            return new UtilityFactory(_context);
        }

        private AccessorFactory CreateAccessorFactory()
        {
            return new AccessorFactory(_context, CreateUtilityFactory());
        }

        [TestMethod]
        public void HouseListTest()
        {
            var houseAccessor = CreateAccessorFactory().CreateAccessor<IHouseAccessor>();

            var list = houseAccessor.HouseList();

            var expected = 3;

            Assert.AreEqual(expected, list.Length);
        }

    }
}
