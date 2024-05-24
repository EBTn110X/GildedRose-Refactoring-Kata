namespace GildedRoseKata
{
    public abstract class Item : IItem
    {
        public string Name { get; protected set; }
        public int SellInDays { get; protected set; }
        public int Quality { get; protected set; }

        protected void DecreaseQuality()
        {
            Quality--;
        }

        protected void IncreaseQuality()
        {
            Quality++;
        }

        protected void ResetQuality()
        {
            Quality = QualityCode.MinimalQuality;
        }

        protected void DecreaseSellInDays()
        {
            SellInDays--;
        }

        public virtual void UpdateQuality()
        {
        }

        public virtual void UpdateSellInDays()
        {
        }

        public virtual void UpdateQualityForSoldDue()
        {
        }
    }
}
