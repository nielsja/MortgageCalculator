using MortgageCalculatorBackend.Accessors.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculatorBackend.Accessors
{
    class HouseAccessor : AccessorBase, IHouseAccessor
    {
        public decimal[] HouseList()
        {
            return new[] { 100000.0M, 150000.0M, 200000.0M };
        }
    }
}
