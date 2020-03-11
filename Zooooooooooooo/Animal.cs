using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Animal
    {
        public static int AnimalCount = 0;

        private string Name;
        private string species;
        private double Weight;
        private int Age;
        private int BreedingAge;
        private string Gender;
        private string FoodType;
        private string IdealEnvironment;
        private string EatingHabbit;
        private int Hunger;
        private string enclosureName;
        private int maxTemp;
        private int minTemp; //(If outside these boundaries go to vet)

        public Animal(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, string _enclosureName, string _species, int _maxTemp, int _minTemp)
        {
            Weight = _weight;
            Age = _age;
            BreedingAge = _BA;
            Gender = _gender;
            FoodType = _FT;
            IdealEnvironment = _IE;
            EatingHabbit = _EH;
            Hunger = _hunger;
            Name = _name;
            enclosureName = _enclosureName;
            species = _species;
            maxTemp = _maxTemp;
            minTemp = _minTemp;

            AnimalCount++;
        }

        public void Print()
        {
            Console.WriteLine("Animal Information:\n-------------------");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: " + species);
            Console.WriteLine("Enclosure: " + enclosureName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Weight: " + Weight + "Kg");
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Food type: " + FoodType);
            Console.WriteLine("Breeding age: " + BreedingAge);
            Console.WriteLine("Ideal environment: " + IdealEnvironment);
            Console.WriteLine("Eating habbit: " + EatingHabbit);
            Console.WriteLine("Hunger: " + Hunger + "/10");
            Console.WriteLine();
        }


        public void Eat()
        {
            if (Hunger < 3)
            {
                Console.WriteLine(Name + " needs to eat.");
            }
            else
            {
                Console.WriteLine(Name + " is not hungry.");
            }
        }

        public void Mate()
        {
            if (BreedingAge > Age)
            {
                Console.WriteLine(Name + " is too young to breed.");
            }
            else
            {
                Console.WriteLine(Name + " is old enough to breed.");
            }
        }

        public void ChangeEnclosure(string _enclosureName, List<Enclosure> enclosures)
        {
            Boolean temp = false;

            for (int i = 0; i < enclosures.Count; i++)
            {
                if (enclosures[i].GetName() == _enclosureName)
                {
                    if (enclosures[i].GetTemperature() < minTemp && enclosures[i].GetTemperature() > maxTemp)
                    {
                        Console.WriteLine(Name + " can't stand the temperature of this enclosure.");
                    }
                    else
                    {
                        enclosureName = _enclosureName;
                        Console.WriteLine(Name + " has been transferred successfully");
                    }
                    temp = true;
                }
            }

            if (temp == false)
            {
                Console.WriteLine("The enclosure " + _enclosureName + " can't be found");
            }
        }
    }
}
