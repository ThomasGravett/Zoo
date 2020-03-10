using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Program
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

        private class Zebra : Animal
        {
            private int NumberOfStripes;

            public Zebra(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _NoS) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name)
            {
                NumberOfStripes = _NoS;
            }

            public void PrintZebra()
            {
                Console.WriteLine("Number of stripes: " + NumberOfStripes + "\n");
            }
        }

        private class GiantPricklyStick : Animal
        {
            private int Pricklyness;

            public GiantPricklyStick(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _Picklyness) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name)
            {
                Pricklyness = _Picklyness;
            }

            public void PrintStick()
            {
                Console.WriteLine("Pricklyness: " + Pricklyness + "/10\n");
            }
        }

        private class Lemur : Animal
        {
            private int SingingAbility;

            public Lemur(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _SA) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name)
            {
                SingingAbility = _SA;
            }

            public void PrintLemur()
            {
                Console.WriteLine("SingingAbility: " + SingingAbility + "/10\n");
            }
        }


        private class AsianGoldenCat : Animal
        {
            private int Cuteness;

            public AsianGoldenCat(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _cuteness) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name)
            {
                Cuteness = _cuteness;
            }

            public void PrintCat()
            {
                Console.WriteLine("Cuteness: " + Cuteness + "/10\n");
            }
        }


        private class EmperorPenguin : Animal
        {
            private int DancingAbility;
            private int SpyingAbility;

            public EmperorPenguin(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _DA, int _SpA) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name)
            {
                DancingAbility = _DA;
                SpyingAbility = _SpA;
            }

            public void PrintPenguin()
            {
                Console.WriteLine("Dancing ability: " + DancingAbility + "/10");
                Console.WriteLine("Spying ablility: " + SpyingAbility + "/10\n");
            }
        }


        static void Main(string[] args)
        {
            Zebra zebra = new Zebra(5, 9, 10, "Male", "Grass", "GrassLand", "Daily", 10, "Jeff", 25);
            zebra.Print();
            zebra.PrintZebra();
            zebra.Eat();
            zebra.Mate();

            Console.WriteLine("\n------------------------------\n\n");

            GiantPricklyStick giantPricklyStick = new GiantPricklyStick(2, 10, 5, "Female", "Leaves", "Tree", "Daily", 2, "Barbra", 10);
            giantPricklyStick.Print();
            giantPricklyStick.PrintStick();
            giantPricklyStick.Eat();
            giantPricklyStick.Mate();

            Console.WriteLine("\n------------------------------\n\n");

            Lemur lemur = new Lemur(5, 15, 8, "Male", "Grass", "Madagascar", "Daily", 10, "Julian", 11);
            lemur.Print();
            lemur.PrintLemur();
            lemur.Eat();
            lemur.Mate();

            Console.WriteLine("\n------------------------------\n\n");

            AsianGoldenCat asianGoldenCat = new AsianGoldenCat(10, 20, 12, "Female", "Meat", "GrassLand", "Daily", 10, "Fluff", 9);
            asianGoldenCat.Print();
            asianGoldenCat.PrintCat();
            asianGoldenCat.Eat();
            asianGoldenCat.Mate();


            Console.ReadKey();
        }
    }
}
