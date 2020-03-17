using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class EmperorPenguin : Animal
    {
        private int DancingAbility;
        private int SpyingAbility;

        public EmperorPenguin(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _DA, int _SpA, Enclosure _enclosureName, int _maxTemp, int _minTemp) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name, _enclosureName, "Emperor penguin", _maxTemp, _minTemp)
        {
            DancingAbility = _DA;
            SpyingAbility = _SpA;
        }

        public void PrintPenguin()
        {
            Console.WriteLine("Dancing ability: " + DancingAbility + "/10");
            Console.WriteLine("Spying ablility: " + SpyingAbility + "/10\n");
        }

        public void Dance()
        {
            //Ascii Art from https://textart.io/art/BJIy6PAHx28VEInIrj8ALQeF/dancing-penguin
            Console.WriteLine("                                    (\"r ^ ^^-.");
            Console.WriteLine("                                    | `-_   \",_");
            Console.WriteLine("                                  _ - '`+-_ `--`/");
            Console.WriteLine("                                , '_-     ``--\\");
            Console.WriteLine("                               (-_ ^ (\\:/)");
            Console.WriteLine("                               (-^^^^^\\");
            Console.WriteLine("                 _.-- ^ ^^-._     \\-_,._  ` `.");
            Console.WriteLine("              .-'        ` `._   )-   ( <._^`-.  `.");
            Console.WriteLine("          _.- '                `-_|- _  /^^ `^^^`-. `.");
            Console.WriteLine("        ({  |    \\ /   /      //-_-_+ /           `. \\");
            Console.WriteLine("         \\\\   _.-- -.          \\\\+-_ + _`}`-._         `.\\");
            Console.WriteLine("           `\"\")   .^\\    \\__..-^     `-_        `\\");
            Console.WriteLine("                    .   )  \\                  `.");
            Console.WriteLine("                   }   / /\\ `.....         ,    \\");
            Console.WriteLine("                  ;  _/ /  `--. _/   .'^`-..-    )");
            Console.WriteLine("                 ((  /     / /  _-'     ;     /");
            Console.WriteLine("                ( `. ``     / /  /       /._   /");
            Console.WriteLine("             __/ `. `._(_(  /^.     (, ,`./");
            Console.WriteLine("       _-:::::(    `._ `-......`,` ^.    ``--'");
            Console.WriteLine("      <::::::::\\      `-......-`   /:|.");
            Console.WriteLine("      < _`:;;::-\\                .|:::/^.");
            Console.WriteLine("       \\  ^      `-.__ __..--<:;,'^.  `.          _");
            Console.WriteLine("        \\  \\          ^^^^             `.  `.       / | /\\");
            Console.WriteLine("         )` `.                           `. .`-.   (  // / _");
            Console.WriteLine("         ) \\\\ \\                            `. / `._/ // /.' }");
            Console.WriteLine(" /^`-..'^ `_``_`^-.                         ( / _-_ <  /  _-'");
            Console.WriteLine("<__ _..._--_..__- )                     __\\ -_-_-.-_.-'");
            Console.WriteLine("    ^^     ^^     ^^                      /'   ___.---'");
            Console.WriteLine("                                         <.--''");
        }
    }

}
