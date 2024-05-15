using System;
using MySql.Data.MySqlClient;
using Vehicle_Simulator.DTO;
using Vehicle_Simulator.Interafces;

namespace Vehicle_Simulator.DAOvehicle
{
    internal class DAOVehicle : IStockVehicleData
    {
        private readonly MySqlConnection _connection;

        public DAOVehicle(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
        }

        public void stockerCoordonnées(VehiclePositionDTO vehiclePosition)
        {
            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }

                string query = "INSERT INTO VehiclePositions (VehicleId, X, Y, Timestamp) VALUES (@VehicleId, @X, @Y, @Timestamp)";
                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@VehicleId", vehiclePosition.VehicleId);
                    command.Parameters.AddWithValue("@X", vehiclePosition.X);
                    command.Parameters.AddWithValue("@Y", vehiclePosition.Y);
                    command.Parameters.AddWithValue("@Timestamp", vehiclePosition.Timestamp);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }

      
    }
}
