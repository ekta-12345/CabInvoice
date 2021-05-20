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
        public void GivenDistanceaAndTime_ShouldReturnTotalFare() //creating method to calculate greater than minimum fare
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
        public void GivenDistanceaAndTime_ShouldReturnMinumumFare() //create method to print minimum fare
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
        //UC2:- Invoice generator should take in multiple rides and calculate aggregate total for all.
 
         [Test]

        public void GivenMultipleRides_ShouldReturnTotalFare() // Method to Calculate Aggregate Fare Of Multiple Rides
        {
            try
            {
                Rides[] ride = { new Rides(4.0, 5.0), new Rides(3.0, 5.0) }; // store multiple ride rideDistance, Ridetime
                double aggregateFare = this.cabInvoiceGenerator.MultipleRides(ride); //call GetMultipleRideFare method and calculat fare
                Assert.AreEqual(40.0, aggregateFare);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
         //UC3:- Test Method To Get Enhanced Invoice Summary With More Ride Details.
      
        [Test]
        public void WhenGivenMultipleRidesGetInvoiceDetails()
        {
            try
            {
                InvoiceDetails invoiceSummary = new InvoiceDetails(2, 605);
                Rides[] rides = { new Rides(30, 30), new Rides(25, 25) };
                InvoiceDetails invoiceSummaryOne = this.cabInvoiceGenerator.CalculateFare(rides);
                Assert.AreEqual(invoiceSummary, invoiceSummaryOne); // check value
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }






}