using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPAia1A_2_
{
    class Program
    {
        private static readonly int amountOfLoan;

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double amountOfLoan = -1;
            double annualInterestRate = -1;
            double monthlyInterestRate =-1;
            double monthlyPayment = -1;
            double totalAmountPaid = -1;
            double totalInterestPaid = -1;
            int numberOfYears = -1;
            int numberOfPayments = -1;
            //double numberOfPayments = -1;
            bool stillMore = false;
            do
            {
                // Ask all the needed information:
                Console.Write("Enter the amount of loan: ");
                string receivedValue = Console.ReadLine();
                //What if it was a fake value?
                while(!Double.TryParse(receivedValue, out amountOfLoan)||
                    amountOfLoan<0)
                {
                    Console.Write("Not a valid value, try again: ");
                    receivedValue = Console.ReadLine();
                }

                Console.Write("Enter the annual interest rate: ");
                receivedValue = Console.ReadLine();
                //What if it was a fake value?
                while (!Double.TryParse(receivedValue, out annualInterestRate) ||
                    annualInterestRate < 0)
                {
                    Console.Write("Not a valid value, try again: ");
                    receivedValue = Console.ReadLine();
                }
                // Calculate monthly interest rate (variable c in the formula)
                monthlyInterestRate = annualInterestRate / 12;
                // How many years do you plan to pay this stuff....?

                Console.Write("Enter the number of years: ");
                receivedValue = Console.ReadLine();
                //What if it was a fake value?
                while (!Int32.TryParse(receivedValue, out numberOfYears) ||
                    numberOfYears < 0)
                {
                    Console.Write("Not a valid value, try again: ");
                    receivedValue = Console.ReadLine();
                }
                // Calculate the number of payments:
                numberOfPayments=12*numberOfYears;
                //Now all the information needed is available!!
                monthlyPayment = (monthlyInterestRate *Math.Pow((1 + monthlyInterestRate), numberOfPayments)) / (Math.Pow((1 + monthlyInterestRate), numberOfPayments) - 1)*amountOfLoan;
                //Cálculate the total amount paid back:
                totalAmountPaid = numberOfPayments * monthlyPayment;
                //Calculate the total interest paid:
                totalInterestPaid = totalAmountPaid - amountOfLoan;

                Console.WriteLine("Monthly payments:{0:F2}", monthlyPayment);
                Console.WriteLine("Number of payments: {0}", numberOfPayments);
                Console.WriteLine("Total amount paid back: {0:F2}", totalAmountPaid);
                Console.WriteLine("Total interest paid back: {0:F2}", totalInterestPaid);

                // More of this or End this!?:
                Console.Write("More loan values to process (Y/N)?");
                String moreOfThis = Console.ReadLine();
                if (moreOfThis.StartsWith("Y") || moreOfThis.StartsWith("y"))
                    stillMore = true;
                else
                    stillMore = false;
            } while (stillMore);
        }
    }
}
