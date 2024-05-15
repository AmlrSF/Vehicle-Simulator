

using System;
using Vehicle_Simulator.Entity;
using Vehicle_Simulator.Business;
using Vehicle_Simulator.DAOvehicle;


class Program
{
    static void Main(string[] args)
    {
        
        string connectionString = "server=localhost;user=root;database=VehicleSimu;port=3306;password=";

        IStockVehicleData vehicleData = new DAOVehicle(connectionString);
        VehicleManager vehicleManager = new VehicleManager(vehicleData);

        
        Vehicle vehicle = new Vehicle(1, "Vehicle1");

        vehicleManager.AddVehicle(vehicle);

        
        vehicleManager.StartSimulation();

        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

        
        vehicleManager.StopSimulation();
    }
}
