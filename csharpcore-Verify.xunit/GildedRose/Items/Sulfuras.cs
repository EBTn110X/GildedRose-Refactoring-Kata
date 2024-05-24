namespace GildedRoseKata.Items
{
    internal class Sulfuras : Item
    {
        public Sulfuras(int sellInDays)
        {
            Name = ProductNames.Sulfuras;
            Quality = QualityCode.MaximumQualityForSulfuras;
            SellInDays = sellInDays;
        }
    }
}
