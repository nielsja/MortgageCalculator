using MortgageCalculatorBackend.Client.Web.Controllers;
using System;

namespace MortgageCalculatorBackend.Client.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting ConsoleApp");

            Console.WriteLine("Enter the house amount:");
            var houseAmountString = Console.ReadLine();
            bool isHouseAmountNumeric = Decimal.TryParse(houseAmountString, out decimal houseAmount);

            Console.WriteLine("Enter the down payment amount:");
            var downPaymentString = Console.ReadLine();
            bool isDownPaymentNumeric = Decimal.TryParse(downPaymentString, out decimal downPayment);

            Console.WriteLine("Enter the annual interest rate:");
            var annualInterestRateString = Console.ReadLine();
            bool isInterestRateNumeric = Decimal.TryParse(annualInterestRateString, out decimal annualInterestRate);

            Console.WriteLine("Enter the loan period (in years):");
            var loanPeriodString = Console.ReadLine();
            bool isLoanPeriodNumeric = Decimal.TryParse(loanPeriodString, out decimal loanPeriod);

            if (isHouseAmountNumeric == true &&
                isDownPaymentNumeric == true &&
                isInterestRateNumeric == true &&
                isLoanPeriodNumeric == true)
            {
                HouseController controller = new HouseController();
                var payments = controller.CalculateMortgagePayment
                    (houseAmount, downPayment, annualInterestRate, loanPeriod);
                Console.WriteLine($"Monthly Payments are: {Decimal.Round(payments, 2)}");
            }
            else
            {
                Console.WriteLine("Error: something went wrong.");
            }

        }
    }
}
