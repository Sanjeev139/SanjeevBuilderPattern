using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    class CarCreator
    {
        private CarInterFace _carInterFace;


        public CarCreator(CarInterFace carIntearface)
        {
            _carInterFace = carIntearface;
        }

        public void BuildCar()
        {
            _carInterFace.setChassis();
            _carInterFace.setEngine();
            _carInterFace.setRadiators();
            _carInterFace.setSeats();
            _carInterFace.setdoors();
        }

        public Car GetCarDetails()
        {
            return _carInterFace.GetCarDetails();
        }
    }
}
