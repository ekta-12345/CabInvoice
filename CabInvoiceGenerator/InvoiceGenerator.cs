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
    }
}
