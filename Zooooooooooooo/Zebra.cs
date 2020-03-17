using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Zebra : Animal
    {
        private int NumberOfStripes;

        public Zebra(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _NoS, Enclosure _enclosureName, int _maxTemp, int _minTemp) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name, _enclosureName, "Zebra", _maxTemp, _minTemp)
        {
            NumberOfStripes = _NoS;
        }

        public void PrintZebra()
        {
            Console.WriteLine("Number of stripes: " + NumberOfStripes + "\n");
        }
    }
}
