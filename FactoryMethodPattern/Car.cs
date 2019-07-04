using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    enum CarType
    {
        Micro, mini, luxry
    }
    enum Location
    {
        other, India, USA
    }
    abstract class Car {
        
        
        private CarType Type ;
        private Location location;
        public Car(CarType Type,Location location)
        {
            this.Type = Type;
            this.location = location;
        }
        void setLocation(Location location)
        {
            this.location = location;
        }
        void setModel(CarType Type)
        {
            this.Type = Type;
        }

         Location getLocation()
        {
            return this.location;
        }
        CarType GetModel()
        {
            return this.Type;
        }
        public override string ToString()
        {
            return "CarModel -" + Type;
        }
        
    }
    class LuxryCar : Car
    {
        public LuxryCar(Location location) : base(CarType.luxry, location)
        {
            construct();
        }

        private void construct()
        {
            Console.WriteLine("Luxry Car Generated");
        }
    }

     class MiniCar : Car
    {
        public MiniCar(Location location) : base(CarType.mini, location)
        {
            construct();
        }

        private void construct()
        {
            Console.WriteLine("Mini Car Generated");
        }
    }

    class MicroCar : Car
    {
        public MicroCar(Location location) : base(CarType.Micro, location)
        {
            construct();
        }

        private void construct()
        {
            Console.WriteLine("Micro Car Generated");
        }
    }
    class IndiaCarfactory
    {


    }


}
