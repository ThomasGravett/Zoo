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

        public GiantPricklyStick(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _Picklyness, string _enclosureName) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name, _enclosureName)
        {
            Pricklyness = _Picklyness;
        }

        public void PrintStick()
        {
            Console.WriteLine("Pricklyness: " + Pricklyness + "/10\n");
        }
    }
}
