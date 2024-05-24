namespace GildedRoseKata.Items
{
    internal class ConjuredItem : Item
    {
        private const int NumberOfQualityDecreases = 2;

        public ConjuredItem(int sellInDays, int quality)
        {
            Name = ProductNames.Conjured;
            SellInDays = sellInDays;
            Quality = quality;
        }

        public override void UpdateQuality()
        {
            for (int i = 0; i < NumberOfQualityDecreases; i++)
            {
                if (Quality > QualityCode.MinimalQuality)
                {
                    DecreaseQuality();
                }
            }
        }

        public override void UpdateSellInDays()
        {
            DecreaseSellInDays();
        }

        public override void UpdateQualityForSoldDue()
        {
            if (SellInDays < SellingDays.DaySoldDue
                &&
                Quality > QualityCode.MinimalQuality)
            {
                DecreaseQuality();
            }
        }
    }
}
