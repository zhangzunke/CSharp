using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Builders
{
    public class Car
    { 
        public string Make { get; set; }
        public string Colour { get; set; }
        public string ManifactureDate { get; set; }
    }

    public interface ICarBuilder
    {
        ICarBuilder SetMake(string make);

        ICarBuilder SetColour(string colour);

        ICarBuilder SetManifactureDate(string date);
    }

    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public ICarBuilder SetMake(string make)
        {
            _car.Make = make;
            return this;
        }

        public ICarBuilder SetColour(string colour)
        {
            _car.Colour = colour;
            return this;
        }

        public ICarBuilder SetManifactureDate(string date)
        {
            _car.ManifactureDate = date;
            return this;
        }

        public Car Build() => _car;
    }
}
