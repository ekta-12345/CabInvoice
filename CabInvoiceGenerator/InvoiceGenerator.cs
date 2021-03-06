using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    //UC1
    public class InvoiceGenerator
    {
        private static readonly double CostPerKilometer = 10.0; // Declared variable 
        private static readonly double CostPerMinute = 1.0;
        private static readonly double MinimumFare = 5.0;
        private double totalFare = 0.0;   //declared variable    
        public double CalculateFare(double distance, double time) //created method for calculating Fare
        {
            this.totalFare = (distance * CostPerKilometer) + (time * CostPerMinute); //calculated fare
            return Math.Max(this.totalFare, MinimumFare); //return value
        }
        // UC2:- Multiple Rides.
                                 
        public double MultipleRides(Rides[] rides) // Method to Calculate Aggregate Fare Of Multiple Rides
        {
            double totalRidesFare = 0.0; //store fare
            foreach (Rides ride in rides) //itterate loop
            {
                totalRidesFare += this.CalculateFare(ride.RideDistance, ride.RideTime); //calculate fare
            }
            return totalRidesFare / rides.Length;
        }
        //UC3:- Test Method To Get Enhanced Invoice Summary With More Ride Details.
        
        public InvoiceDetails CalculateFare(Rides[] rides)  //  Method to Calculate Aggregate Fare Of Multiple Rides
        {
            double totalRidesFare = 0.0; //store fare
            foreach (Rides ride in rides) //itterate loop
            {
                totalRidesFare += this.CalculateFare(ride.RideDistance, ride.RideTime); //calculate fare
            }

            return new InvoiceDetails(rides.Length, totalRidesFare);//return value
        }
        public void MapRidesToUser(string userID, Rides[] rides) => RideRepoUserId.AddRides(userID, rides); //create MapRidesToUser method

        public InvoiceDetails GetInvoiceSummary(string userID) => this.CalculateFare(RideRepoUserId.GetRides(userID)); //create method GetInvoiceSummary


    }
}
