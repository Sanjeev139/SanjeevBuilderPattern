using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    public class Car
    {
        public string Chassis
        {
            get;
            set;
        }
        public string Engine
        {
            get;
            set;
        }
        public string Radiator
        {
            get;
            set;
        }
        public string Wheels
        {
            get;
            set;
        }
        public string Seats
        {
            get;
            set;
        }

        public string Doors
        {
            get;
            set;
        }
    }
    public class CarBuilder : CarInterFace
    {
        Car car = new Car();

        public void setChassis()
        {
            car.Chassis = "BTM";
        }

        public void setEngine()
        {
            car.Engine = "Engine";
        }

        public void setRadiators()
        {
            car.Radiator = "Sohan";
        }

        public void setWheels()
        {
            car.Wheels = "Lal";
        }

        public void setSeats()
        {
            car.Seats = "Seats";
        }

        public void setdoors()
        {
            car.Doors = "Doors";
        }

        public Car GetCarDetails()
        {
            return car;
        }
    }
}
