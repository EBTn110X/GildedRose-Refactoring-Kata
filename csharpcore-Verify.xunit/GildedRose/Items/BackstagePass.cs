namespace GildedRoseKata.Items
{
    internal class BackstagePass : Item
    {
        public BackstagePass(int sellInDays, int quality)
        {
            Name =ProductNames.BackstagePass;
            SellInDays = sellInDays;
            Quality = quality;
        }

        public override void UpdateQuality()
        {
            if (Quality < QualityCode.MaximumQuality)
            {
                IncreaseQuality();
            }

            if (SellInDays < SellingDays.DayForDoubleQualityOfBackstagePass &&
                Quality < QualityCode.MaximumQuality)
            {
                IncreaseQuality();
            }

            if (SellInDays < SellingDays.DayForTripleQualityOfBackstagePass &&
                Quality < QualityCode.MaximumQuality)
            {
                IncreaseQuality();
            }
        }

        public override void UpdateSellInDays()
        {
            DecreaseSellInDays();
        }

        public override void UpdateQualityForSoldDue()
        {
            if (SellInDays < SellingDays.DaySoldDue)
            {
                ResetQuality();
            }
        }
    }
}
