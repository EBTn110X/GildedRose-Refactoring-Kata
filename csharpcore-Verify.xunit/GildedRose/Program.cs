using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item {Name = ProductNames.Vest, SellInDays = 10, Quality = 20},
                new Item {Name = ProductNames.Brie, SellInDays = 2, Quality = 0},
                new Item {Name = ProductNames.Elixir, SellInDays = 5, Quality = 7},
                new Item {Name = ProductNames.Sulfuras, SellInDays = 0, Quality = 80},
                new Item {Name = ProductNames.Sulfuras, SellInDays = -1, Quality = 80},
                new Item
                {
                    Name = ProductNames.BackstagePass,
                    SellInDays = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = ProductNames.BackstagePass,
                    SellInDays = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = ProductNames.BackstagePass,
                    SellInDays = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item {Name = ProductNames.Conjured, SellInDays = 3, Quality = 6}
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellInDays, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellInDays + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateItems();
            }
        }
    }
}
