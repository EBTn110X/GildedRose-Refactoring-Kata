using System;
using System.Collections.Generic;
using GildedRoseKata.Items;

namespace GildedRoseKata
{
    public class Program
    {
        private const int MinimumDay = 0;
        private const int MaximumDay = 31;
        private const string StartYell = "OMGHAI!";

        public static void Main(string[] args)
        {
            Console.WriteLine(StartYell);

            IList<Item> Items = [
                new StandardItem(ProductNames.Vest, sellInDays: 10, quality: 20),
                new Brie(sellInDays: 2, quality: 0),
                new StandardItem(ProductNames.Elixir, sellInDays: 5, quality: 7),
                new Sulfuras(sellInDays: 0),
                new Sulfuras(sellInDays: -1),
                new BackstagePass(sellInDays: 15, quality: 20),
                new BackstagePass(sellInDays: 10, quality: 49),
                new BackstagePass(sellInDays: 5, quality: 49),
                new ConjuredItem(sellInDays: 3, quality: 6)
            ];

            var app = new GildedRose(Items);

            for (var i = MinimumDay; i < MaximumDay; i++)
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
