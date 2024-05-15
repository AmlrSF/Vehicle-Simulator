using System;

namespace Vehicle_Simulator.Entity
{
    internal class GPS
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public DateTime Timestamp { get; private set; }

        private static Random random = new Random();

   
    
        public (double X, double Y, DateTime Timestamp) GenerateCoordinates()
        {
            X = random.NextDouble() * 100; 
            Y = random.NextDouble() * 100;
            Timestamp = DateTime.UtcNow;

            return (X, Y, Timestamp);
        }
    }
}
