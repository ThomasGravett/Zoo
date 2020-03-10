using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class AsianGoldenCat : Animal
    {
        private int Cuteness;

        public AsianGoldenCat(string _enclosureName, double _weight, int _age, int _BA, string _gender, string _FT, string _IE, string _EH, int _hunger, string _name, int _cuteness) : base(_weight, _age, _BA, _gender, _FT, _IE, _EH, _hunger, _name, _enclosureName, "Asian golden Cat")
        {
            Cuteness = _cuteness;
        }

        public void PrintCat()
        {
            Console.WriteLine("Cuteness: " + Cuteness + "/10\n");
        }
    }
}
