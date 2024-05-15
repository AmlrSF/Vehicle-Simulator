using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vehicle_Simulator.Entity;

namespace Vehicle_Simulator.Entity
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GPS Gps { get; set; }

        public Vehicle(int id, string name)
        {
            Id = id;
            Name = name;
            Gps = new GPS();
            
        }

    }
}
