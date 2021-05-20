using NUnit.Framework;
using CabInvoiceGenerator;
using System;
namespace MSTestCabInvoice
{
    class CabInvoiceGeneratorTest
    {
        private InvoiceGenerator cabInvoiceGenerator;

        [SetUp]
        public void Setup() //SetUp Method.
        {
            this.cabInvoiceGenerator = new InvoiceGenerator();
        }
        // UC1.1:-  Test Method for calculating fare when fare is greater than minimum fare.

        [Test]
        public void GivenDistanceAndTime_FareGreaterThanMinimumFareShouldReturnFare() //creating method to calculate greater than minimum fare
        {
            try
            {
                double distance = 10.0; //declaring distance variable and value  // totalFare = (distance * CostPerKilometer) + (time * CostPerMinute);
                double time = 10;    //declaring time variable and value i.e.here we have (5.0 * 10.0) + (10 * 1.0)= 60
                double expected = 60; //total fare expected value
                double totalFare = this.cabInvoiceGenerator.CalculateFare(distance, time); //calling method and passing value
                Assert.AreEqual(expected, totalFare); //checking if equal or not
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        //UC1.2:- Test Method for calculating fare when fare is less than minimum fare.

        [Test]
        public void GivenDistanceAndTime_WhenTotalFareIsLessThanMinimumFare_ShouldReturnMinimumFare() //create method to print minimum fare
        {
            try
            {
                double distance = 0.1;
                double time = 1;             //here we have (0.1 * 10.0) + (1 * 1.0)=2
                double MinimumFare = 5.0;
                double totalFare = this.cabInvoiceGenerator.CalculateFare(distance, time);  //call method and passing value
                Assert.AreEqual(MinimumFare, totalFare); // check equal or not
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}