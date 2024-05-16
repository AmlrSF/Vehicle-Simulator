using System;
using System.Threading;
using Vehicle_Simulator.DTO;
using Vehicle_Simulator.Entity;
using Vehicle_Simulator.Interafces;


namespace Vehicle_Simulator.Business
{
    internal class VehicleManager
    {
        private List<Vehicle> vehicles;
        private List<Thread> threads;
        private IStockVehicleData _vehicleService;
        private Random random;

        public VehicleManager(IStockVehicleData service)
        {
            vehicles = new List<Vehicle>();
            threads = new List<Thread>();
            _vehicleService = service;
            random = new Random();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void StartSimulation()
        {
            foreach (var vehicle in vehicles)
            {
                Thread thread = new Thread(() => StartTrackingVehicle(vehicle));
                thread.Start();
                threads.Add(thread);
            }
        }

        public void StartTrackingVehicle(Vehicle v)
        {
            while (true)
            {
                GPS p = new GPS();
                
                double x = p.GenerateRandomX();
                double  y = p.GenerateRandomY();
                DateTime timestamp = p.Timestamp;
                
                

                VehiclePositionDTO vehiclePosition = new VehiclePositionDTO(v.Id, x, y, timestamp);

                
                _vehicleService.stockerCoordonnées(vehiclePosition);

                
                Console.WriteLine($"Vehicle ID: {v.Id} | X: {x} | Y: {y} | Timestamp: {timestamp}");

                
                int delay = random.Next(500, 2000);
                Thread.Sleep(delay);
            }
        }
    }
}
