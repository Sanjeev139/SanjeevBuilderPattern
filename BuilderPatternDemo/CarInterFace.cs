using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    interface CarInterFace
    {
        void setChassis();
        void setEngine();
        void setRadiators();
        void setWheels();
        void setSeats();

        void setdoors();

        Car GetCarDetails();
    }
}
