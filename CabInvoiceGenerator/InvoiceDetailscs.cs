using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
     //UC3:- The Invoice generator should now return Total Number Of Ride,Total Fare and Average Fare Per Ride
                
    public class InvoiceDetails
    {
        public int NumberOfRides;
        public double TotalFare;
        public double AverageFarePerRide;

        public InvoiceDetails(int numberOfRides, double totalFare) // Initializes a new instance
        {
            this.NumberOfRides = numberOfRides;
            this.TotalFare = totalFare;
            this.AverageFarePerRide = this.TotalFare / this.NumberOfRides; //calculate AverageFarePerRide
        }
        // Overriding Equals Method.

        public override bool Equals(object obj) => obj is InvoiceDetails summary &&
                   this.NumberOfRides == summary.NumberOfRides &&
                   this.TotalFare == summary.TotalFare &&
                   this.AverageFarePerRide == summary.AverageFarePerRide;


        // Overriding GetHashCode Method.

        public override int GetHashCode() => HashCode.Combine(this.NumberOfRides, this.TotalFare, this.AverageFarePerRide);
        //combines these three values intoa hash code
        //combines the hash code for multiple values into a single hash code
    }
}


