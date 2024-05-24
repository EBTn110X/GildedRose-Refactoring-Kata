namespace GildedRoseKata.Items
{
    internal class Brie : Item
    {
        public Brie(int sellInDays, int quality)
        {
            Name = ProductNames.Brie;
            SellInDays = sellInDays;
            Quality = quality;
        }

        public override void UpdateQuality()
        {
            if (Quality < QualityCode.MaximumQuality)
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
            if (SellInDays < SellingDays.DaySoldDue
                &&
                Quality < QualityCode.MaximumQuality)
            {
                IncreaseQuality();
            }
        }
    }
}
