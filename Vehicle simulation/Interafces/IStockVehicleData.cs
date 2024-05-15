using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Simulator.DTO;

namespace Vehicle_Simulator.Interafces
{
    internal interface IStockVehicleData
    {
        void stockerCoordonnées(VehiclePositionDTO vehiclePosition);
    }
}
