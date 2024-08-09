namespace GildedRoseKata;

public class AgedBrieItem : Item
{
    public virtual void Update()
    {
        if (Quality < 50)
        {
            Quality += 1;
        }

        SellIn -= 1;

        if (SellIn < 0)
        {
            {
                if (Quality < 50)
                {
                    Quality += 1;
                }
            }
        }
    }
}