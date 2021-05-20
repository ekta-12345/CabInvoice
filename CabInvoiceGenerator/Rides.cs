using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Rides // Rides Class is storing info of the rides
    {
        public double RideDistance; // Variable For Storing Ride Distance Of A Particular Ride.

        public double RideTime; // Variable For Storing Ride Time Of A Particular Ride.

        public Rides(double rideDistance, double rideTime) //Initializes a new instance 
        {
            this.RideDistance = rideDistance;  // Ride Distance Of A Ride
            this.RideTime = rideTime;            // Ride Time Of A Ride
        }
    }
}
