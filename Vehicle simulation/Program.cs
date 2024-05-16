using System;
using Vehicle_Simulator.DTO;
using Vehicle_Simulator.Entity;
using Vehicle_Simulator.Interafces;
using Vehicle_Simulator.DAOvehicle;
using Vehicle_Simulator.Business;


class Program
{
    static void Main(string[] args)
    {
        
        string connectionString 
            = "server=localhost;port=3306;user=root;database=vehiclesimu;Uid=root;";


        

        IStockVehicleData vehicleData = new DAOVehicle(connectionString);
        VehicleManager vehicleManager = new VehicleManager(vehicleData);

        
        Vehicle vehicle = new Vehicle(1, "Vehicle1");

        
        vehicleManager.AddVehicle(vehicle);

        
        vehicleManager.StartSimulation();
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

        
       
    }
}
