using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    class RideRepoUserId  // RideRepoUserId Class To Store Cab Rides And Get Cab Rides By User Id.
    {
        private static Dictionary<string, List<Rides>> userRideList = new Dictionary<string, List<Rides>>(); // Create Dictionary

        public static void AddRides(string userID, Rides[] ride) // Static Method For Adding Ride Details By User Id.
        {
            bool checkList = userRideList.ContainsKey(userID);

            if (checkList == false)
            {
                userRideList.Add(userID, new List<Rides>(ride)); //add ride
            }
        }
        public static Rides[] GetRides(string userId) // Static Method To Get Cab Rides Of User By User Id.
        {
            return userRideList[userId].ToArray(); //Cab Rides Of User
        }
    }
}

