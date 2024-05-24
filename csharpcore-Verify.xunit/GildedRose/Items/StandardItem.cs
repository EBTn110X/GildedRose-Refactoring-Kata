namespace GildedRoseKata.Items
{
    internal class StandardItem : Item
    {
        public StandardItem(string name, int sellInDays, int quality)
        {
            Name = name;
            SellInDays = sellInDays;
            Quality = quality;
        }

        public override void UpdateQuality()
        {
            if (Quality > QualityCode.MinimalQuality)
            {
                DecreaseQuality();
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
