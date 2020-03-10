﻿using System;
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

}