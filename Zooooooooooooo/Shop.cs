using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooooooooooooo
{
    class Shop
    {
        class StockItem
        {
            public string name { get; set; }
            public int ammount { get; set; }
            public int price { get; set; }
        }

        private List<StockItem> stock = new List<StockItem> ();
        private string name;
        private int money; //The ammount of money the shop has earnt/can spend on new stock

        public Shop (string _name, int _money)
        {
            name = _name;
            money = _money;
        }

        public int GetPrice (string _name)
        {
            int temp = 0;

            for (int i = 0; i < stock.Count; i++)
            {
                if (stock[i].name == _name)
                {
                    temp = stock[i].price;
                }
            }

            return temp;
        }

        public void AddStock (string _name, int _ammount, int _price, int _cost)
        {
            Boolean add = true;
            for (int i = 0; i < stock.Count; i++)
            {
                if (stock[i].name == _name)
                {
                    stock[i].ammount += _ammount;
                    if (stock[i].price != _price)
                    {
                        string ans;
                        Console.WriteLine("This has a different price to other stock of this type.");
                        Console.WriteLine("Would you like to change the price from " + stock[i].price + " to " + _price + "? y/n");
                        ans = Console.ReadLine();

                        if (ans == "y")
                        {
                            stock[i].price = _price;
                        }
                    }

                    add = false;
                }
            }

            if (add == true)
            {
                StockItem temp = new StockItem();
                temp.name = _name;
                temp.ammount = _ammount;
                temp.price = _price;

                stock.Add(temp);
            }

            money -= _cost;
        }

        public void Sell (string _name, int _ammount)
        {
            for (int i = 0; i < stock.Count; i++)
            {
                if (stock[i].name == _name)
                {
                    stock[i].ammount -= _ammount;
                    money += stock[i].price;
                    Console.WriteLine(stock[i].name + " sold for " + stock[i].price);
                    i = stock.Count;
                }
            }
        }

        public void CheckStock()
        {
            for (int i = 0; i < stock.Count; i++)
            {
                Console.WriteLine("Name: " + stock[i].name);
                Console.WriteLine("Stock Left: " + stock[i].ammount);
                Console.WriteLine("Price: " + stock[i].ammount);
                Console.WriteLine();
            }
        }

    }
}
