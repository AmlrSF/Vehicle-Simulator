using System;

namespace Vehicle_Simulator.Entity
{
    internal class GPS
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public DateTime Timestamp { get; private set; }

        private static Random random = new Random();

        
        public double GenerateRandomX()
        {
            return random.NextDouble() * 100;
        }

        public double GenerateRandomY()
        {
            return random.NextDouble() * 100; 
        }

        public DateTime GetCurrentDateTime()
        {
            return DateTime.UtcNow; 
        }
     
    }
}
