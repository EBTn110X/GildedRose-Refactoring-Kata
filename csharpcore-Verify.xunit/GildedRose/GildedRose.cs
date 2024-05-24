using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateItems()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != ProductNames.Brie && Items[i].Name != ProductNames.BackstagePass)
                {
                    if (Items[i].Quality > Quality.MinimalQuality)
                    {
                        if (Items[i].Name != ProductNames.Sulfuras)
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < Quality.MidQuality)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == ProductNames.BackstagePass)
                        {
                            if (Items[i].SellInDays < SellingDays.DayEleven)
                            {
                                if (Items[i].Quality < Quality.MidQuality)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellInDays < SellingDays.DaySix)
                            {
                                if (Items[i].Quality < Quality.MidQuality)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != ProductNames.Sulfuras)
                {
                    Items[i].SellInDays = Items[i].SellInDays - 1;
                }

                if (Items[i].SellInDays < 0)
                {
                    if (Items[i].Name != ProductNames.Brie)
                    {
                        if (Items[i].Name != ProductNames.BackstagePass)
                        {
                            if (Items[i].Quality > Quality.MinimalQuality)
                            {
                                if (Items[i].Name != ProductNames.Sulfuras)
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < Quality.MidQuality)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
