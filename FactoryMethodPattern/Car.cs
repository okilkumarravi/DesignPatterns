using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum CarType
{
    Micro, mini, luxry
}
enum Location
{
    other, India, USA
}
namespace FactoryMethod
{
  
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
            return "\n CarModel -" + Type;
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
            Console.WriteLine(" \nLuxry Car Generated\n");
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
            Console.WriteLine(" \nMini Car Generated\n");
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
            Console.WriteLine("\n Micro Car Generated\n");
        }
    }
    class IndiaCarFactory
    {
         public static Car Builder(CarType type)
        {
            Car car = null;
            switch (type)
            {
                case CarType.Micro:
                    car = new MicroCar(Location.India);
                    break;
                case CarType.mini:
                    car = new MiniCar(Location.India);
                    break;
                case CarType.luxry:
                    car = new LuxryCar(Location.India);
                    break;
            }
            return car;
        }

    }
    class USACarFactory
    {
        public static Car Builder(CarType type)
        {
            Car car = null;
            switch (type)
            {
                case CarType.Micro:
                    car = new MicroCar(Location.USA);
                    break;
                case CarType.mini:
                    car = new MiniCar(Location.USA);
                    break;
                case CarType.luxry:
                    car = new LuxryCar(Location.USA);
                    break;
            }
            return car;
        }

    }
    class OtherCarFactory
    {
        public static Car Builder(CarType type)
        {
            Car car = null;
            switch (type)
            {
                case CarType.Micro:
                    car = new MicroCar(Location.other);
                    break;
                case CarType.mini:
                    car = new MiniCar(Location.other);
                    break;
                case CarType.luxry:
                    car = new LuxryCar(Location.other);
                    break;
            }
            return car;
        }

    }

    class CarFactory
    {
        private CarFactory()
        {

        }
        public static Car BuildCar(CarType type)
        {
            Car car = null;
            Location location = Location.India;
            switch (location)
            {
                case Location.India:
                    car = IndiaCarFactory.Builder(type);
                    break;
                case Location.other:
                    car = OtherCarFactory.Builder(type);
                    break;
                case Location.USA:
                    car = USACarFactory.Builder(type);
                    break;
            }
            return car;
        }

    }


}
