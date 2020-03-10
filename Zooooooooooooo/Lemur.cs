using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Lemur : Animal
    {
        private int SingingAbility;

        public Lemur(double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _SA, string _enclosureName, int _maxTemp, int _minTemp) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name, _enclosureName, "Lemur", _maxTemp, _minTemp)
        {
            SingingAbility = _SA;
        }

        public void PrintLemur()
        {
            Console.WriteLine("SingingAbility: " + SingingAbility + "/10\n");
        }
    }
}
