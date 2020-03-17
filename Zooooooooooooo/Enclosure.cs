using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Enclosure
    {
        private string name;
        private int size;
        private int temperature;
        private int humidity;
        private int cost;
        private string environmentType;
        private List<Animal> animals;

        //environment cost (to run) to put more strain on the zoos budget

        public Enclosure (string _name, int _size, int _temperature, int _humidity, string _environmentType)
        {
            name = _name;
            size = _size;
            temperature = _temperature;
            humidity = _humidity;
            environmentType = _environmentType;
            CalculateCost();
        }

        public void CalculateCost()
        {
            cost = 1 * size;

            if (temperature >= 20)
            {
                cost = cost + ((temperature - 20) * 3);
            }
            else
            {
                cost = cost + ((20 - temperature) * 2);
            }

            if (humidity >= 50)
            {
                cost = cost + ((humidity - 50) * 5);
            }
            else
            {
                cost = cost + ((50 - humidity) * 4);
            }
        }

        public void Print ()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("Size: " + size);
            Console.WriteLine("Temperature: " + temperature);
            Console.WriteLine("Humidity: " + humidity);
            Console.WriteLine("Environment type: " + environmentType);
            Console.WriteLine();
        }

        public void AddAnimal(Animal _newAnimal)
        {
            animals.Add(_newAnimal);
        }

        public Animal LoseAnimal(string _lostAnimal)
        {
            Animal temp = animals[1]; //I have to set it to the first animal because otherwise there is an error

            for (int i = 0; i > animals.Count; i++)
            {
                if (animals [i].GetName() == _lostAnimal)
                {
                    temp = animals[i];
                    animals.RemoveAt(i);
                }
            }

            return temp;
        }

        public string GetName()
        {
            return name;
        }

        public int GetTemperature()
        {
            return temperature;
        }
    }
}
