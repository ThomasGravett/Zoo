using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Enclosure> enclosures = new List<Enclosure>;

//<<<<<<< HEAD
            Zebra zebra = new Zebra(5, 9, 10, "Male", "Grass", "GrassLand", "Daily", 10, "Jeff", 25, "Brian");
            zebra.Print();
            zebra.PrintZebra();
            zebra.Eat();
            zebra.Mate();

            Console.WriteLine("\n------------------------------\n\n");

            GiantPricklyStick giantPricklyStick = new GiantPricklyStick(2, 10, 5, "Female", "Leaves", "Tree", "Daily", 2, "Barbra", 10, "Brian");
            giantPricklyStick.Print();
            giantPricklyStick.PrintStick();
            giantPricklyStick.Eat();
            giantPricklyStick.Mate();

            Console.WriteLine("\n------------------------------\n\n");

            Lemur lemur = new Lemur(5, 15, 8, "Male", "Grass", "Madagascar", "Daily", 10, "Julian", 11, "Brian");
            lemur.Print();
            lemur.PrintLemur();
            lemur.Eat();
            lemur.Mate();

            Console.WriteLine("\n------------------------------\n\n");

            AsianGoldenCat asianGoldenCat = new AsianGoldenCat("Brian",10, 20, 12, "Female", "Meat", "GrassLand", "Daily", 10, "Fluff", 9);
            asianGoldenCat.Print();
            asianGoldenCat.PrintCat();
            asianGoldenCat.Eat();
            asianGoldenCat.Mate();


            Console.ReadKey();
//=======

//>>>>>>> 0f825dce0544c808fa79f8a20004c152ee9e896e
        }
    }
}
