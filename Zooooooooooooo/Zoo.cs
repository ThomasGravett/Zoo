using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Zoo
    {
        private string name;
        private DateTime openTime;
        private DateTime closeTime;
        private int ticketPrice;
        private int size;
        private int money;

        public Zoo(string _name, DateTime _openTime, DateTime _closeTime, int _ticketPrice, int _size, int _money)
        {
            name = _name;
            openTime = _openTime;
            closeTime = _closeTime;
            ticketPrice = _ticketPrice;
            size = _size;
            money = _money;
        }

        public void IncreaseSize(int _sizeIncrease, int _cost)
        {
            size += _sizeIncrease;
            money -= _cost;
        }

        public List<Customer> SellTicket(int _ammount)
        {
            List<Customer> listOfCustomers = new List<Customer> ();
            string favouriteAnimal;
            int happiness;
            int age;

            money += ticketPrice * _ammount;

            for (int i = 1; i < _ammount; i++)
            {
                Console.WriteLine("What is the favourite animal of customer" + i);
                favouriteAnimal = Console.ReadLine();
                Console.WriteLine("What is the happiness (/10) of customer" + i);
                happiness = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How much money does the customer have?" + i);
                money = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the age of customer" + i);
                age = Convert.ToInt32(Console.ReadLine());

                listOfCustomers.Add(new Customer(favouriteAnimal, happiness, money, age));
                Console.WriteLine();
            }

            return listOfCustomers;
        }
    }
}
