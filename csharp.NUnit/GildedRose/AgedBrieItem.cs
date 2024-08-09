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

    private void GeneralItemUpdate()
    {
        if (Quality > 0)
        {
            Quality -= 1;
        }

        SellIn -= 1;


        if (SellIn < 0 && Quality > 0)
        {
            Quality -= 1;
        }
    }

    private bool IsSulfuras()
    {
        return Name == "Sulfuras, Hand of Ragnaros";
    }

    private bool IsBackstagePasses()
    {
        return Name == "Backstage passes to a TAFKAL80ETC concert";
    }

    private bool IsAgedBrie()
    {
        return Name == "Aged Brie";
    }
}