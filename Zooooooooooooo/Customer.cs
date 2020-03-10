using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Customer : Person
    {
        private string favouriteAnimal;
        private int happiness;
        private int money;

        //method to buy stuff from gift shop

        public Customer(string _favouriteAnimal, int _happiness, int _money, int _age) : base(_age)
        {
            favouriteAnimal = _favouriteAnimal;
            happiness = _happiness;
            money = _money;
        }
    }
}
