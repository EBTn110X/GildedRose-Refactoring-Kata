using System;
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
                UpdateQuality(Items[i]);

                UpdateSellInDays(Items[i]);

                if (Items[i].SellInDays < SellingDays.DaySoldDue)
                {
                    UpdateQualityForSoldDue(Items[i]);

                }
            }
        }

        private static void UpdateQuality(Item item)
        {
            if (IsQualityDecreaseAllowedFor(item.Name))
            {
                UpdateQualityForDecrease(item);
            }

            if (IsQualityIncreaseAllowedFor(item.Name))
            {
                UpdateQualityForIncrease(item);
            }
        }
        
        private void UpdateSellInDays(Item item)
        {
            if (IsSellingDaysDecreaseAllowedFor(item.Name))
            {
                item.SellInDays = Decrease(item.SellInDays);
            }
        }

        private void UpdateQualityForSoldDue(Item item)
        {
            if (IsQualityResetAllowedForSoldDue(item))
            {
                item.Quality = Quality.MinimalQuality;
            }

            if (IsQualityDecreaseAllowedForSoldDue(item))
            { 
                item.Quality = Decrease(item.Quality); 
            }

            if (IsQualityIncreaseAllowedForSoldDue(item))
            {
                item.Quality = Increase(item.Quality);
            }
        }

        private static bool IsQualityDecreaseAllowedForSoldDue(Item item)
            =>  item.Name != ProductNames.Brie && 
                item.Name != ProductNames.BackstagePass &&
                item.Name != ProductNames.Sulfuras &&
                item.Quality > Quality.MinimalQuality;

        private static bool IsQualityResetAllowedForSoldDue(Item item)
            => item.Name == ProductNames.BackstagePass;

        private static bool IsSellingDaysDecreaseAllowedFor(string name)
            => name != ProductNames.Sulfuras;

        private static bool IsQualityDecreaseAllowedFor(string name)
            => name != ProductNames.Brie && name != ProductNames.BackstagePass;

        private static bool IsQualityIncreaseAllowedFor(string name)
            => name == ProductNames.Brie || name == ProductNames.BackstagePass;

        private static void UpdateQualityForIncrease(Item item)
        {
            if (item.Quality < Quality.MidQuality)
            {
                item.Quality = Increase(item.Quality);

                if (item.Name == ProductNames.BackstagePass)
                {
                    if (item.SellInDays < SellingDays.DayEleven)
                    {
                        if (item.Quality < Quality.MidQuality)
                        {
                            item.Quality = Increase(item.Quality);
                        }
                    }

                    if (item.SellInDays < SellingDays.DaySix)
                    {
                        if (item.Quality < Quality.MidQuality)
                        {
                            item.Quality = Increase(item.Quality);
                        }
                    }
                }
            }
        }

        private static void UpdateQualityForDecrease(Item item)
        {
            if (item.Quality > Quality.MinimalQuality)
            {
                if (item.Name != ProductNames.Sulfuras)
                {
                    item.Quality = Decrease(item.Quality);
                }
            }
        }

        private static int Increase(int number)
            => ++number;

        private static int Decrease(int number)
            => --number;

        private static bool IsQualityIncreaseAllowedForSoldDue(Item item)
            => item.Name == ProductNames.Brie && item.Quality < Quality.MidQuality;
    }
}
