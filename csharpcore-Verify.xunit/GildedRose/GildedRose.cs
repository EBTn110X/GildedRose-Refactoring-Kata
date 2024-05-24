using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose(IList<Item> Items)
    {
        private readonly IList<Item> _items = Items;

        public void UpdateItems()
        {
            foreach(var item in _items)
            {
                item.UpdateQuality();

                item.UpdateSellInDays();

                item.UpdateQualityForSoldDue();
            }
        }
    }
}
