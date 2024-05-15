using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Simulator.DTO
{
    internal class VehiclePositionDTO
    {
        public int VehicleId { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public DateTime Timestamp { get; set; }

        public VehiclePositionDTO(int vehicleId, double x, double y, DateTime timestamp)
        {
            VehicleId = vehicleId;
            X = x;
            Y = y;
            Timestamp = timestamp;
        }
    }
}
