using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Enclosure
    {
        private int size;
        private int temperature;
        private int humidity;
        private string environmentType;

        public Enclosure (int _size, int _temperature, int _humidity, string _environmentType)
        {
            size = _size;
            temperature = _temperature;
            humidity = _humidity;
            environmentType = _environmentType;
        }

        public void Print ()
        {
            Console.WriteLine("Size: " + size);
            Console.WriteLine("Temperature: " + temperature);
            Console.WriteLine("Humidity: " + humidity);
            Console.WriteLine("Environment type: " + environmentType);
            Console.WriteLine();
        }
    }
}
