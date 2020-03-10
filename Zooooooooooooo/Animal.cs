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
        private double Weight;
        private int Age;
        private int BreedingAge;
        private string Gender;
        private string FoodType;
        private string IdealEnvironment;
        private string EatingHabbit;
        private int Hunger;

        public Animal(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name)
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

            AnimalCount++;
        }

        public void Print()
        {
            Console.WriteLine("Animal Information:\n-------------------");
            Console.WriteLine("Name: " + Name);
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
    }
}
