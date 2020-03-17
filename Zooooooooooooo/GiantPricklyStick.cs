using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class GiantPricklyStick : Animal
    {
        private int Pricklyness;

        public GiantPricklyStick(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _Picklyness, Enclosure _enclosureName, int _maxTemp, int _minTemp) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name, _enclosureName, "Giant prickly stick", _maxTemp, _minTemp)
        {
            Pricklyness = _Picklyness;
        }

        public void PrintStick()
        {
            Console.WriteLine("Pricklyness: " + Pricklyness + "/10\n");
        }
    }
}
